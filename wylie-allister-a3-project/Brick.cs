using System;
using System.Numerics;

namespace Game10003
{
    public class Brick
    {
        public void DrawBrickPosition()
        {
            for (int i = 0; i < 19; i++)
            {
                int xOffset = i * 26;
                Draw.FillColor = Color.Black;
                Draw.LineColor = Color.Clear;
                Draw.Rectangle(46 + xOffset, 200, 22, 11);

            }
        }
    }
}
