using System;
using System.Numerics;

namespace Game10003
{
    public class Brick
    {
        Vector2 position = new Vector2(46, 200);
        float xPosition = 46;
        float yPosition = 200;

        public Brick()
        {

        }

        public void RenderBrick(float x, float y)
        {


            Draw.FillColor = Color.Black;
            Draw.LineColor = Color.Clear;

            for (int i = 0; i < 19; i++)
            {
            float xOffset = (i * 26);
            float yOffset = (i * 15);

                Draw.Rectangle(46 + xOffset, 200, 22, 11);
            }
        }

        //public void DrawBrickPosition()
        //{
        // for (int i = 0; i < 19; i++)
        //{
        //  int xOffset = i * 26;
        // Draw.FillColor = Color.Black;
        //Draw.LineColor = Color.Clear;
        //Draw.Rectangle(46 + xOffset, 200, 22, 11);

        //}

        // }
    }
}
