using System;
using System.Numerics;

namespace Game10003;

public class Platform
{
    public Vector2 platPosition;
    public Vector2 platSize;
    public float speed;
    Color color;
    
    public void DrawPlatform()
    {
        platSize = new Vector2 (100, 10);
        color = Color.Blue;
        Draw.FillColor = color;
        Draw.Rectangle(platPosition, platSize);
    }

    public void MovePlatform()
    {
        if (Input.IsKeyboardKeyDown(KeyboardInput.Left))
        {
            platPosition.X -= speed * Time.DeltaTime;
        }
        if (Input.IsKeyboardKeyDown(KeyboardInput.Right))
        {
            platPosition.X += speed * Time.DeltaTime;
        }
        if (platPosition.X < 0)
        {
            platPosition.X = 0;
        }
        if (platPosition.X + platSize.X >= Window.Width)
        {
            platPosition.X = Window.Width - platSize.X;
        }
    }

    public bool Collision(Ball ball)
   {
        float ballLeftEdge = ball.ballPosition.X;
        float ballRightEdge = ball.ballPosition.X + ball.ballSize.X;
        float ballTopEdge = ball.ballPosition.Y;
        float ballBotEdge = ball.ballPosition.Y + ball.ballSize.Y;

        float platLeftEdge = platPosition.X;
        float platRightEdge = platPosition.X + platSize.X;
        float platTopEdge = platPosition.Y;
        float platBotEdge = platPosition.Y + platSize.Y;

        bool doesOverlapLeft = platLeftEdge < ballRightEdge;
        bool doesOverlapRight = platRightEdge > ballLeftEdge;
        bool doesOverlapTop = platTopEdge < ballBotEdge;
        bool doesOverlapBot = platBotEdge > ballTopEdge;

        bool isWithinPlat = doesOverlapLeft && doesOverlapRight && doesOverlapTop && doesOverlapBot;

        if (isWithinPlat == true)
        {
            //ball.velocity.X = -ball.velocity.X;
            ball.velocity.Y = -ball.velocity.Y;
            return isWithinPlat;
        }
        else
        {
            return false;
        }
    }
}
