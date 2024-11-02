using System;
using System.Numerics;

namespace Game10003;

public class Ball
{
    Vector2 velocity;
    Vector2 position;
    float radius;
    Color color;
    int hp;

    public void UpdatePosition()
    {
        position += velocity * Time.DeltaTime;
    }

    public void DrawBall()
    {
        Draw.FillColor = color;
        Draw.Circle(position, radius);
    }

    public void TouchingWalls()
    {
        bool isTouchingTop = position.Y <= 0 + radius;
        bool isTouchingBot = position.Y >= Window.Height - radius;
        bool isTouchingLeft = position.X <= 0 + radius;
        bool isTouchingRight = position.X >= Window.Width - radius;

        if (isTouchingTop)
        {
            velocity.Y = -velocity.Y;
        }

        if (isTouchingLeft || isTouchingRight)
        {
            velocity.X = -velocity.X;
        }

        if (isTouchingBot)
        {
            //kill ball here
        }
    }
}
