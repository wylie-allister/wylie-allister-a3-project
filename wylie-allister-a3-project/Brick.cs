using System;
using System.Numerics;

namespace Game10003;

public class Brick
{
    public Vector2 position;
    public Vector2 size;
    public Color cloudColor;
    public bool isActive = true;

    public Brick()
    {
        size = new Vector2(22, 11);
        cloudColor = new Color(0xd5, 0xd6, 0xdb);
    }
    public void BrickPos(int x, int y)
    {
        //draws brick position
        position = new Vector2(x, y);
    }
    public void DrawBrick()
    {
        //Draws brick if active
        if (isActive == true)
        {
            //draws brick
            Draw.FillColor = cloudColor;
            Draw.LineColor = Color.Clear;
            Draw.Rectangle(position, size);
        }
    }
}

