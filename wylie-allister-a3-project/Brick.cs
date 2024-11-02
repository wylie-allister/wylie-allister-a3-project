using System;
using System.Numerics;

namespace Game10003;

public class Brick
{

    
    public Vector2 size;
    public Color color;
  //  int[] rowY = [46, 59, 72, 85, 126, 140, 166, 180, 206, 220];
  //  int[] brickRowNumber = [19, 18, 17, 16, 13, 12, 10, 9, 7, 6];
    //int[] rowX = [320, 304, 288, 272, 256, 240, 224, 208, 192, 176, 160, 144, 129, 114, 99, 84, 69, 54, 39];

    public Brick()
    {
        size = new Vector2(22, 11);
        color = Color.Black;
    }
    public void DrawBrick(int x, int y)
    {
        //draws brick
        Vector2 position = new Vector2(x, y);
        Draw.FillColor = Color.Black;
        Draw.LineColor = Color.Clear;
        Draw.Rectangle(position, size);
    }



    //  public void RenderBrick(float x, float y)
    // {

    //ugly as sin code to render the bricks


    // if (x == 46)
    // {
    //     for (int i = 0; i < 19; i++)
    //     {
    //        float xOffset = i * 27;

    //DrawBrick(46 + xOffset, y, 22, 11);
    //    }
    // }
    // else if (x == 59)
    // {
    //    for (int i = 0; i < 18; i++)
    //    {
    //        float xOffset = i * 27;

    // DrawBrick(59 + xOffset, y, 22, 11);
    //     }
    //}
    //  else if (x == 72)
    //  {
    //      for (int i = 0; i < 17; i++)
    //      {
    //          float xOffset = i * 27;

    // DrawBrick(72 + xOffset, y, 22, 11);
    //     }
    //  }
    //  else if (x == 85)
    //  {
    //      for (int i = 0; i < 16; i++)
    //      {
    //          float xOffset = i * 27;

    //DrawBrick(85 + xOffset, y, 22, 11);
    //  }
    //  }
    //  }
}

