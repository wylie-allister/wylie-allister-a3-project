﻿using System;
using System.Numerics;
using System.Security.Cryptography.X509Certificates;

namespace Game10003;

public class Ball
{
    Vector2 velocity;
    //Vector2 point;
    public Vector2 ballPosition;
    Vector2 ballSize;
    //float radius;
    Color color;
    public int hp = 3;

    public Ball()
    {
        color = Color.Red;
       // radius = 7;
        velocity = Random.Direction() * 100;
        ballSize = new Vector2(7, 7);
    }

    public void UpdatePosition()
    {
    ballPosition += velocity * Time.DeltaTime;
    }
    public void DrawBall()
    {
        Draw.FillColor = color;
        //Draw.Circle(circlePosition, radius);
        Draw.Rectangle(ballPosition, ballSize);
    }

    public bool TouchingWalls()
    {
        // bool isTouchingTop = ballPosition.Y <= 0 + radius;
        //  bool isTouchingBot = ballPosition.Y >= Window.Height - radius;
        // bool isTouchingLeft = ballPosition.X <= 0 + radius;
        // bool isTouchingRight = ballPosition.X >= Window.Width - radius;
        float ballLeftEdge = ballPosition.X;
        float ballRightEdge = ballPosition.X + ballSize.X;
        float ballTopEdge = ballPosition.Y;
        float ballBotEdge = ballPosition.Y + ballSize.Y;

        bool leftOfWindow = ballLeftEdge <= 0;
        bool rightOfWindow = ballRightEdge >= Window.Width;
        bool topOfWindow = ballTopEdge <= 0;
        bool bottomOfWindow = ballBotEdge >= Window.Height;

        if (topOfWindow || bottomOfWindow)
        {
            velocity.Y = -velocity.Y;
        }

        if (leftOfWindow || rightOfWindow)
        {
            velocity.X = -velocity.X;
        }

        if (!topOfWindow || !bottomOfWindow || !leftOfWindow || !rightOfWindow)
        {
            return true;
        }

        return false;
       // if (isTouchingBot)
      //  {
            //kill ball here
       // }
    }
        public bool BrickCollision(Brick brick)
        {

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

        if (isWithinBrick == true)
        {
            Console.WriteLine("ping");
           --hp;
            return true;
        }
        else
        {
            return false; 
        }
        }
    
}
