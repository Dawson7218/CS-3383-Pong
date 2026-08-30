using UnityEngine;

public class GameManager : MonoBehaviour
{
    public Ball ball;
    public Paddle paddle;
    public WinScreen winscreen;
    public static Vector2 bottomLeft;
    public static Vector2 topRight;

    void Start()
    {
        bottomLeft = Camera.main.ScreenToWorldPoint(new Vector2(0, 0));
        topRight = Camera.main.ScreenToWorldPoint(new Vector2(Screen.width, Screen.height));

        var ballObj = Instantiate(ball);
        ballObj.winScreen = winscreen;

        //Instantiate(pauseMenu);
        var paddle1 = Instantiate(paddle) as Paddle;
        var paddle2  = Instantiate(paddle)as Paddle;

        paddle1.Init(true); //right
        paddle2.Init(false); //left


    }
    
}
