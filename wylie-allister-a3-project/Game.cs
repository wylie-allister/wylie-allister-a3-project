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
        Ball ball;
        int brickCount = 19;
        Brick[] bricks;

        /// <summary>
        ///     Setup runs once before the game loop begins.
        /// </summary>
        public void Setup()
        {
            Window.SetTitle("Weatherbuster");
            Window.SetSize(600, 600);

            Vector2 centre = Window.Size / 2;
            ball = new Ball();
             bricks = new Brick[19];

            for (int i = 0; i < bricks.Length; i++)
            {
               bricks[i] = new Brick();
            }
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

            BrickRenderer();
        }

        void BrickRenderer()
        {
            //Renders cloud bricks
            //also kind of ugly
            bricks[12].RenderBrick(85, 144);
            bricks[11].RenderBrick(72, 160);
            bricks[10].RenderBrick(59, 176);
            bricks[1].RenderBrick(46, 192);
            bricks[2].RenderBrick(46, 208);
            bricks[3].RenderBrick(46, 224);            
            bricks[4].RenderBrick(46, 240);
            bricks[5].RenderBrick(46, 256);
            bricks[6].RenderBrick(46, 272);
            bricks[7].RenderBrick(59, 288);
            bricks[8].RenderBrick(72, 304);
            bricks[9].RenderBrick(85, 320);
        }
    }
}
