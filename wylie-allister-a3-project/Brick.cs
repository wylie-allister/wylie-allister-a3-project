using System;
using System.Numerics;

namespace Game10003
{
    public class Brick
    {

        Vector2 RectangleSize1;

        public Brick()
        {

        }

        public void BrickCollision()
        {
        Vector2 RectanglePosition1;

            float leftEdge = RectanglePosition1.X;
            float rightEdge = RectanglePosition1.X + RectangleSize1.X;
            float topEdge = RectanglePosition1.Y;
            float botEdge = RectanglePosition1.Y + RectangleSize1.Y;
        }
        public void DrawBrick(float x, float y, float w, float h)
        {
            //draws brick

            Draw.FillColor = Color.Black;
            Draw.LineColor = Color.Clear;

            Draw.Rectangle(x, y, 22, 11);


        }
        public void RenderBrick(float x, float y)
        {

            //ugly as sin code to render the bricks


            if (x == 46)
            {
                for (int i = 0; i < 19; i++)
                {
                    float xOffset = i * 27;

                    DrawBrick(46 + xOffset, y, 22, 11);
                }
            }
            else if (x == 59)
            {
                for (int i = 0; i < 18; i++)
                {
                    float xOffset = i * 27;

                    DrawBrick(59 + xOffset, y, 22, 11);
                }
            }
            else if (x == 72)
            {
                for (int i = 0; i < 17; i++)
                {
                    float xOffset = i * 27;

                    DrawBrick(72 + xOffset, y, 22, 11);
                }
            }
            else if (x == 85)
            {
                for (int i = 0; i < 16; i++)
                {
                    float xOffset = i * 27;

                    DrawBrick(85 + xOffset, y, 22, 11);
                }
            }
        }
    }
}
