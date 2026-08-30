using UnityEngine;

public class Paddle : MonoBehaviour
{
    [SerializeField]
    float speed;
    float height;
    string input;
    public bool isRight;   

    void Start()
    {
        height = transform.localScale.y;
        speed = 5f;
    }
    public void Init(bool isRightPaddle)
    {
        isRight = isRightPaddle;
        var pos = Vector2.zero;

        // Initialize values based off if object is left or right paddle
        if (isRightPaddle)
        {
            pos = new Vector2(GameManager.topRight.x, 0);
            pos -= Vector2.right * transform.localScale.x;

            input = "PaddleRight";
        }
        else
        {
            pos = new Vector2(GameManager.bottomLeft.x, 0);
            pos += Vector2.right * transform.localScale.x;

            input = "PaddleLeft";
        }

        transform.position = pos;

        transform.name = input;
    }

    void Update()
    {
        // Get axis is 1 or -1 for up or down, delta time to account for frames
        float move = Input.GetAxis(input) * Time.deltaTime * speed;

        // Stop paddles going out of bounds
        if (transform.position.y < GameManager.bottomLeft.y + height / 2 && move < 0)
        {
            move = 0;
        }
        if (transform.position.y > GameManager.topRight.y - height / 2 && move > 0)
        {
            move = 0;
        }

        transform.Translate(move * Vector2.up);
    }
}
