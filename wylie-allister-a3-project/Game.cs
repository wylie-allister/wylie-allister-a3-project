// Include code libraries you need below (use the namespace).
using System;
using System.IO;
using System.Numerics;

// The namespace your code is in.
namespace Game10003
{
    /// <summary>
    ///     Your game code goes inside this class!
    /// </summary>
    public class Game
    {
        // Place your variables here:
        Brick brick;
        Ball ball;


        /// <summary>
        ///     Setup runs once before the game loop begins.
        /// </summary>
        public void Setup()
        {
            Window.SetTitle("Weatherbuster");
            Window.SetSize(600, 600);
            Vector2 centre = Window.Size / 2;
            brick = new Brick();
            ball = new Ball(); 
        }

        /// <summary>
        ///     Update runs every frame.
        /// </summary>
        public void Update()
        {
            Window.ClearBackground(Color.OffWhite);
            //draw test ball
            ball.UpdatePosition();
            ball.Render();
            ball.TouchingWalls();

            //draw bricks in row
            brick.DrawBrickPosition();

        }
    }
}
