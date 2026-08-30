using UnityEngine;

public class Ball : MonoBehaviour
{
    [SerializeField]
    float speed;
    float radius;
    Vector2 direction;
    public WinScreen winScreen;
    
    void Start()
    {
        direction = Vector2.one.normalized;
        radius = transform.localScale.x / 2;
    }

    void Update()
    {
        // Update pos
        transform.Translate(direction * speed * Time.deltaTime);

        // Bounce off top and bottom of screen
        if (transform.position.y < GameManager.bottomLeft.y + radius && direction.y < 0)
        {
            direction.y = -direction.y;
        }
        if (transform.position.y > GameManager.topRight.y - radius && direction.y > 0)
        {
            direction.y = -direction.y;
        } 

        if (transform.position.x < GameManager.bottomLeft.x + radius && direction.x < 0)
        {
            Debug.Log("Right Player Won!");
            winScreen.RightWin();
            Time.timeScale = 0;
            enabled = false;
        }
        if (transform.position.x > GameManager.topRight.x - radius && direction.x > 0)
        {
            Debug.Log("Left Player Won!");
            winScreen.LeftWin();
            Time.timeScale = 0;
            enabled = false;
        }
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        // Change direction if collided with paddle
        // Simplified code from tutorial, it had unessecary check for left
        // and right paddle for same behavior
        if (other.tag == "Paddle")
        {
            direction.x = -direction.x;
        }
    }
}
