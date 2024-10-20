using System;
using System.Numerics;

namespace Game10003
{
    public class Ball
    {
        //ALL OF THIS WILL BE REPLACED, CURRENTLY USING TO TEST COLLISION, DON'T MIND IT
        //----------------------------------------------------------------------------------------------
        Vector2 velocity;
        Vector2 position;
        float radius;
        Color color;
        public Ball()
        {
            //set up ball
            velocity = Random.Direction() * 100;
            radius = 10;
            color = Random.Color();
            position = Random.Vector2(radius, Window.Width - radius, radius, Window.Height - radius);
        }

        public void UpdatePosition()
        {
            position += velocity * Time.DeltaTime;
        }

        public void Render()
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

            if (isTouchingTop || isTouchingBot)
            {
                velocity.Y = -velocity.Y;
            }

            if (isTouchingLeft || isTouchingRight)
            {
                velocity.X = -velocity.X;
            }
        }
        //------------------------------------------------------------------------------------------------
    }
}
