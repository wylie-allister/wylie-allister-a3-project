using System;
using System.Numerics;

namespace Game10003;

public class Brick
{
    public Vector2 position;
    public Vector2 size;
    public Color color;
    public bool isActive = true;

    public Brick()
    {
        size = new Vector2(22, 11);
        color = Color.Black;
    }
    public void BrickPos(int x, int y)
    {
        //draws brick
        position = new Vector2(x, y);
    }
    public void DrawBrick()
    {
        //Draws brick if active
        if (isActive == true)
        {
            //draws brick
            Draw.FillColor = Color.Black;
            Draw.LineColor = Color.Clear;
            Draw.Rectangle(position, size);
        }
    }
}

