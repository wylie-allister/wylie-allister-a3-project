using System;
using System.Numerics;

namespace Game10003;

public class Platform
{
    public Vector2 platPosition;
    public Vector2 platSize;
    public float speed;
    Color color;

    public void DrawPlatform()
    {
        platSize = new Vector2 (100, 10);
        color = Color.Blue;
        Draw.FillColor = color;
        Draw.Rectangle(platPosition, platSize);
    }

    public void MovePlatform()
    {
        if (Input.IsKeyboardKeyDown(KeyboardInput.Left))
        {
            platPosition.X -= speed * Time.DeltaTime;
        }
        if (Input.IsKeyboardKeyDown(KeyboardInput.Right))
        {
            platPosition.X += speed * Time.DeltaTime;
        }
    }

    //public bool Collision(Ball ball)
   // {

   // }
}
