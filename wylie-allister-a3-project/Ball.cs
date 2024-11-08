using System;
using System.Numerics;
using System.Security.Cryptography.X509Certificates;

namespace Game10003;

public class Ball
{
    public Vector2 velocity;
    public Vector2 ballPosition;
    public Vector2 ballSize;
    Color ballColor;
    public int hp = 3;

    public Ball()
    {
        ballColor = new Color(0x80, 0xdf, 0xcf);
        velocity = Random.Direction() * 200;
        ballSize = new Vector2(7, 7);
    }

    public void UpdatePosition()
    {
        //ball moves
        ballPosition += velocity * Time.DeltaTime;
    }
    public void DrawBall()
    {
        //draws ball
        Draw.FillColor = ballColor;
        Draw.Rectangle(ballPosition, ballSize);
    }

    public bool TouchingWalls()
    {
        //Wall collision
        float ballLeftEdge = ballPosition.X;
        float ballRightEdge = ballPosition.X + ballSize.X;
        float ballTopEdge = ballPosition.Y;
        float ballBotEdge = ballPosition.Y + ballSize.Y;

        bool leftOfWindow = ballLeftEdge <= 0;
        bool rightOfWindow = ballRightEdge >= Window.Width;
        bool topOfWindow = ballTopEdge <= 0;
        bool bottomOfWindow = ballBotEdge >= Window.Height;

        if (topOfWindow)
        {
            velocity.Y = -velocity.Y;
        }
        if (leftOfWindow || rightOfWindow)
        {
            velocity.X = -velocity.X;
        }
        //resets ball if it hits the bottom
        if (bottomOfWindow == true)
        {
            ballPosition.X = Window.Width / 2;
            ballPosition.Y = Window.Height - 150;
            --hp;
        }
        if (!topOfWindow || ! bottomOfWindow || !leftOfWindow || !rightOfWindow)
        {
            return true;
        }
        return false;
    }
    public bool BrickCollision(Brick brick)
    {
        //variables for brick collision
        float leftEdge = brick.position.X;
        float rightEdge = brick.position.X + brick.size.X;
        float topEdge = brick.position.Y;
        float botEdge = brick.position.Y + brick.size.Y;

        float ballLeftEdge = ballPosition.X;
        float ballRightEdge = ballPosition.X + ballSize.X;
        float ballTopEdge = ballPosition.Y;
        float ballBotEdge = ballPosition.Y + ballSize.Y;

        bool doesOverlapLeft = leftEdge < ballRightEdge;
        bool doesOverlapRight = rightEdge > ballLeftEdge;
        bool doesOverlapTop = topEdge < ballBotEdge;
        bool doesOverlapBot = botEdge > ballTopEdge;

        bool isWithinBrick = doesOverlapLeft && doesOverlapRight && doesOverlapTop && doesOverlapBot;
        //bounces brick back
        if (isWithinBrick == true)
        {
            velocity.X = -velocity.X;
            velocity.Y = -velocity.Y;
            return isWithinBrick;
        }
        else
        {
            return false;
        }
    }
}
