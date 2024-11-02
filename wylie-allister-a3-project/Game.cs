// Include code libraries you need below (use the namespace).
using System;
using System.IO;
using System.Numerics;

// The namespace your code is in.
namespace Game10003;

/// <summary>
///     Your game code goes inside this class!
/// </summary>
public class Game
{
    // Place your variables here:
    //creates amount of bricks needed
    Brick[] bricks = new Brick[283];
    // rowY: Y axis positions, brickRowNumber: Number of bricks in each row, rowX: X axis positions, offsetX: Offsets X axis
    int[] rowY = [320, 304, 288, 272, 256, 240, 224, 208, 192, 176, 160, 144, 128, 112, 96, 80, 64, 48, 32];
    int[] brickRowNumber = [16, 17, 18, 19, 13, 12, 10, 9, 7, 6];
    int[] rowX = [46, 73, 100, 127, 154, 181, 208, 235, 262, 289, 316, 343, 370, 397, 424, 451, 478, 505, 532];
    int[] offsetX = [39, 26, 15, 79, 93, 120, 134, 161, 175];


    /// <summary>
    ///     Setup runs once before the game loop begins.
    /// </summary>
    public void Setup()
    {
        Window.SetTitle("Weatherbuster");
        Window.SetSize(600, 600);
        for (int i = 0; i < bricks.Length; i++)
        {
            Brick brick = new Brick();
            bricks[i] = brick;

        }
    }

    /// <summary>
    ///     Update runs every frame.
    /// </summary>
    public void Update()
    {
        Window.ClearBackground(Color.OffWhite);
        DrawCloud();
    }

    public void DrawCloud()
    {
        //draws bricks into cloud shaped pattern
        for (int i = 0; i < brickRowNumber[0]; i++)
        {
            bricks[i].DrawBrick(rowX[i] + offsetX[0], rowY[0]);
            bricks[i].DrawBrick(rowX[i] + offsetX[0], rowY[11]);
        }
        for (int i = 0; i < brickRowNumber[1]; i++)
        {
            bricks[i].DrawBrick(rowX[i] + offsetX[1], rowY[1]);
            bricks[i].DrawBrick(rowX[i] + offsetX[1], rowY[10]);
        }
        for (int i = 0; i < brickRowNumber[2]; i++)
        {
            bricks[i].DrawBrick(rowX[i] + offsetX[2], rowY[2]);
            bricks[i].DrawBrick(rowX[i] + offsetX[2], rowY[9]);
        }
        for (int i = 0; i < brickRowNumber[3]; i++)
        {
            bricks[i].DrawBrick(rowX[i], rowY[3]);
            bricks[i].DrawBrick(rowX[i], rowY[4]);
            bricks[i].DrawBrick(rowX[i], rowY[5]);
            bricks[i].DrawBrick(rowX[i], rowY[6]);
            bricks[i].DrawBrick(rowX[i], rowY[7]);
            bricks[i].DrawBrick(rowX[i], rowY[8]);
        }
        for (int i = 0; i < brickRowNumber[4]; i++)
        {
            bricks[i].DrawBrick(rowX[i] + offsetX[3], rowY[12]);
        }
        for (int i = 0; i < brickRowNumber[5]; i++)
        {
            bricks[i].DrawBrick(rowX[i] + offsetX[4], rowY[13]);
        }
        for (int i = 0; i < brickRowNumber[6]; i++)
        {
            bricks[i].DrawBrick(rowX[i] + offsetX[5], rowY[14]);
            bricks[i].DrawBrick(rowX[i] + offsetX[5], rowY[15]);
        }
        for (int i = 0; i < brickRowNumber[7]; i++)
        {
            bricks[i].DrawBrick(rowX[i] + offsetX[6], rowY[16]);
        }
        for (int i = 0; i < brickRowNumber[8]; i++)
        {
            bricks[i].DrawBrick(rowX[i] + offsetX[7], rowY[17]);
        }
        for (int i = 0; i < brickRowNumber[9]; i++)
        {
            bricks[i].DrawBrick(rowX[i] + offsetX[8], rowY[18]);
        }
    }
}
