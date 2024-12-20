﻿// Include code libraries you need below (use the namespace).
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
    Color skyColor = new Color(0x1d, 0x1c, 0x3a);
    Ball ball = new Ball();
    Platform platform = new Platform();
    //creates amount of bricks needed
    Brick[] bricks = new Brick[289];
    int brickCount = 282;
    // brickRowNumber: Number of bricks in each row, offsetX: Offsets X axis, brickPos: sets x and y of bricks
    int[] brickRowNumber = [16, 17, 18, 19, 13, 12, 10, 9, 7, 6];
    int[] offsetX = [39, 26, 15, 79, 93, 120, 134, 161, 175];
    int[][] brickPos = [[46, 320], [73, 304], [100, 288], [127, 272], [154, 256], [181, 240], [208, 224], [235, 208], [262, 192], [289, 176], [316, 160], [343, 144], [370, 128], [397, 112], [424, 96], [451, 80], [478, 64], [505, 48], [532, 32]];

    /// <summary>
    ///     Setup runs once before the game loop begins.
    /// </summary>
    public void Setup()
    {
        //sets title, size, ball position, and generates bricks
        Window.SetTitle("Weatherbuster");
        Window.SetSize(600, 600);
        for (int i = 0; i < bricks.Length; i++)
        {
            Brick brick = new Brick();
            bricks[i] = brick;
        }
        for (int b = 0; b < bricks.Length; b++)
        {
            //draws bricks into cloud shaped pattern
            for (int i = 0; i < brickRowNumber[0]; i++)
            {
                bricks[i].BrickPos(brickPos[i][0] + offsetX[0], brickPos[0][1]);
                bricks[i + 16].BrickPos(brickPos[i][0] + offsetX[0], brickPos[11][1]);
            }
            for (int i = 0; i < brickRowNumber[1]; i++)
            {
                bricks[i + 33].BrickPos(brickPos[i][0] + offsetX[1], brickPos[1][1]);
                bricks[i + 50].BrickPos(brickPos[i][0] + offsetX[1], brickPos[10][1]);
            }
            for (int i = 0; i < brickRowNumber[2]; i++)
            {
                bricks[i + 68].BrickPos(brickPos[i][0] + offsetX[2], brickPos[2][1]);
                bricks[i + 86].BrickPos(brickPos[i][0] + offsetX[2], brickPos[9][1]);
            }
            for (int i = 0; i < brickRowNumber[3]; i++)
            {
                bricks[i + 105].BrickPos(brickPos[i][0], brickPos[3][1]);
                bricks[i + 124].BrickPos(brickPos[i][0], brickPos[4][1]);
                bricks[i + 143].BrickPos(brickPos[i][0], brickPos[5][1]);
                bricks[i + 162].BrickPos(brickPos[i][0], brickPos[6][1]);
                bricks[i + 181].BrickPos(brickPos[i][0], brickPos[7][1]);
                bricks[i + 200].BrickPos(brickPos[i][0], brickPos[8][1]);
            }
            for (int i = 0; i < brickRowNumber[4]; i++)
            {
                bricks[i + 219].BrickPos(brickPos[i][0] + offsetX[3], brickPos[12][1]);
            }
            for (int i = 0; i < brickRowNumber[5]; i++)
            {
                bricks[i + 233].BrickPos(brickPos[i][0] + offsetX[4], brickPos[13][1]);
            }
            for (int i = 0; i < brickRowNumber[6]; i++)
            {
                bricks[i + 245].BrickPos(brickPos[i][0] + offsetX[5], brickPos[14][1]);
                bricks[i + 255].BrickPos(brickPos[i][0] + offsetX[5], brickPos[15][1]);
            }
            for (int i = 0; i < brickRowNumber[7]; i++)
            {
                bricks[i + 266].BrickPos(brickPos[i][0] + offsetX[6], brickPos[16][1]);
            }
            for (int i = 0; i < brickRowNumber[8]; i++)
            {
                bricks[i + 275].BrickPos(brickPos[i][0] + offsetX[7], brickPos[17][1]);
            }
            for (int i = 0; i < brickRowNumber[9]; i++)
            {
              bricks[i + 282].BrickPos(brickPos[i][0] + offsetX[8], brickPos[18][1]);
            }
        }
        //generates ball and platform position & speed
        ball.ballPosition.X = Window.Width / 2;
        ball.ballPosition.Y = Window.Height - 100;
        platform.platPosition.X = Window.Width / 2;
        platform.platPosition.Y = Window.Height - 50;
        platform.speed = 400;
    }

    /// <summary>
    ///     Update runs every frame.
    /// </summary>
    public void Update()
    {
        Window.ClearBackground(skyColor);
        //Draws platform and lets it move and have collision
        platform.DrawPlatform();
        platform.MovePlatform();
        platform.Collision(ball);
        //draws ball and adds wall collision
        ball.UpdatePosition();
        ball.DrawBall();
        ball.TouchingWalls();
        //Disables bricks upon collision
        for (int i = 0; i < bricks.Length; i++)
        {
            bool doesBallCollide = false;
            if (bricks[i].isActive == true)
            {
                bricks[i].DrawBrick();
                doesBallCollide = ball.BrickCollision(bricks[i]);
            }
            if (doesBallCollide == true)
            {
                --brickCount;
                bricks[i].isActive = false;
            }
        }
        //hide incorrectly drawn brick
        Draw.FillColor = skyColor;
        Draw.Rectangle(0, 0, 25, 13);
        //win screen
        if (brickCount == 0)
        {
            Window.ClearBackground(Color.Black);
            Draw.FillColor = Color.Black;
            Draw.Rectangle(0, 0, 600, 600);
            Text.Color = Color.White;
            Text.Draw($"You win!", 200, 300);
        }
        //lose screen
        if (ball.hp <= 0)
        {
            Window.ClearBackground(Color.Black);
            Draw.FillColor = Color.Black;
            Draw.Rectangle(0, 0, 600, 600);
            Text.Color = Color.Red;
            Text.Draw($"You lose :(", 200, 300);
        }
    }
}


