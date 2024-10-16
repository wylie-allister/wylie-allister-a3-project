﻿/*////////////////////////////////////////////////////////////////////////
 * Copyright (c)
 * Mohawk College, 135 Fennell Ave W, Hamilton, Ontario, Canada L9C 0E5
 * Game Design (374): GAME 10003 Game Development Foundations
 *////////////////////////////////////////////////////////////////////////

using System;
using System.Numerics;

namespace Game10003
{
    /// <summary>
    ///     Generate random values.
    /// </summary>
    public static class Random
    {

        #region Fields

        /// <summary>
        ///     The underlying random number generator for all methods.
        /// </summary>
        private static readonly System.Random rng = new();

        #endregion

        #region Public Methods

        /// <summary>
        ///     Get a random angle in degrees as a floating-point number.
        /// </summary>
        /// <returns>
        ///     Returns a random value from 0.0f (inclusize) to 360.0f (exclusive).
        /// </returns>
        public static float AngleDegrees()
        {
            float angleDegrees = Float(0, 360);
            return angleDegrees;
        }

        /// <summary>
        ///     Get a random angle in radians as a floating-point number.
        /// </summary>
        /// <returns>
        ///     Returns a random value from 0.0f (inclusize) to 6.283185307f (exclusive).
        /// </returns>
        public static float AngleRadians()
        {
            float angleRadians = Float(0, MathF.Tau);
            return angleRadians;
        }

        /// <summary>
        ///     Get a random Boolean (true or false).
        /// </summary>
        /// <returns>
        ///     Returns a random value of either true or false.
        /// </returns>
        public static bool Bool()
        {
            bool value = rng.Next(2) == 1;
            return value;
        }

        /// <summary>
        ///     Get a random byte.
        /// </summary>
        /// <returns>
        ///     Returns a random value from 0 (inclusize) to 256 (exclusive).
        /// </returns>
        public static byte Byte() => (byte)rng.Next(256);

        /// <summary>
        ///     Get a random byte.
        /// </summary>
        /// <param name="max">The maximum value (excluded from range).</param>
        /// <returns>
        ///     Returns a random value from 0 (inclusize) to <paramref name="max"/> (exclusive).
        /// </returns>
        public static byte Byte(byte max) => (byte)rng.Next(max);

        /// <summary>
        ///     Get a random byte.
        /// </summary>
        /// <param name="min">The minimum value (included from range).</param>
        /// <param name="max">The maximum value (excluded from range).</param>
        /// <returns>
        ///     Returns a random value from <paramref name="min"/> (inclusize) to
        ///     <paramref name="max"/> (exclusive).
        /// </returns>
        public static byte Byte(byte min, byte max) => (byte)rng.Next(min, max);

        /// <summary>
        ///     Get a random Boolean (true or false).
        /// </summary>
        /// <returns>
        ///     Returns a random value of either true or false.
        /// </returns>
        public static bool CoinFlip()
            => Bool();

        /// <summary>
        ///     Get a random color.
        /// </summary>
        /// <returns>
        ///     Returns a random color with R, G, and B component values of different 
        ///     values from 0 (inclusize) to 256 (exclusive). A is always 255 (opaque).
        /// </returns>
        public static Color Color() => new(Byte(), Byte(), Byte());

        /// <summary>
        ///     Get a random direction vector.
        /// </summary>
        /// <returns>
        ///     Returns a random direction vector in any possible direction, where
        ///     the length of the vector is always exactly 1.0f.
        /// </returns>
        public static Vector2 Direction()
            => PointOnCircle();

        /// <summary>
        ///     Get a random grayscale color.
        /// </summary>
        /// <returns>
        ///     Returns a random color with R, G, and B component values of the same
        ///     value from 0 (inclusize) to 256 (exclusive). A is always 255 (opaque).
        /// </returns>
        public static Color GrayscaleColor() => new(Byte());

        /// <summary>
        ///     Get a random floating-point number.
        /// </summary>
        /// <returns>
        ///     Returns a random value from 0.0f (inclusize) to 1.0f (exclusive).
        /// </returns>
        public static float Float() => rng.NextSingle();

        /// <summary>
        ///     Get a random floating-point number.
        /// </summary>
        /// <param name="max">The maximum value (excluded from range).</param>
        /// <returns>
        ///     Returns a random value from 0.0f (inclusize) to <paramref name="max"/> (exclusive).
        /// </returns>
        public static float Float(float max) => rng.NextSingle() * max;

        /// <summary>
        ///     Get a random floating-point number.
        /// </summary>
        /// <param name="min">The minimum value (included from range).</param>
        /// <param name="max">The maximum value (excluded from range).</param>
        /// <returns>
        ///     Returns a random value from <paramref name="min"/> (inclusize) to <paramref name="max"/> (exclusive).
        /// </returns>
        public static float Float(float min, float max) => rng.NextSingle() * (max - min) + min;

        /// <summary>
        ///     Get a random integer.
        /// </summary>
        /// <returns>
        ///     Returns a random value from 0 (inclusize) to 2,147,483,647 (exclusive).
        /// </returns>
        public static int Integer() => rng.Next();

        /// <summary>
        ///     Get a random integer.
        /// </summary>
        /// <param name="max">The maximum value (excluded from range).</param>
        /// <returns>
        ///     Returns a random value from 0 (inclusize) to <paramref name="max"/> (exclusive).
        /// </returns>
        public static int Integer(int max) => rng.Next(max);

        /// <summary>
        ///     Get a random integer.
        /// </summary>
        /// <param name="min">The minimum value (included from range).</param>
        /// <param name="max">The maximum value (excluded from range).</param>
        /// <returns>
        ///     Returns a random value from <paramref name="min"/> (inclusize) to <paramref name="max"/> (exclusive).
        /// </returns>
        public static int Integer(int min, int max) => rng.Next(min, max);

        /// <summary>
        ///     Get a random point inside a unit circle.
        /// </summary>
        /// <returns>
        ///     Returns a random value from (-1.0f, -1.0f) (exclusive) to
        ///     (1.0f, 1.0f) (exclusive), where the max length of the vector
        ///     is 1.0f.
        /// </returns>
        public static Vector2 PointInCircle()
        {
            Vector2 direction = PointOnCircle();
            float magnitude = Float();
            Vector2 pointInCircle = direction * magnitude;
            return pointInCircle;
        }

        /// <summary>
        ///     Get a random point on a unit circle.
        /// </summary>
        /// <returns>
        ///     Returns a random point on a circle, where the length of the vector
        ///     is always exactly 1.0f.
        /// </returns>
        public static Vector2 PointOnCircle()
        {
            float angle = AngleRadians();
            Vector2 pointOnCircle = new(MathF.Cos(angle), MathF.Sin(angle));
            return pointOnCircle;
        }

        /// <summary>
        ///     Get a random Vector2.
        /// </summary>
        /// <returns>
        ///     Returns a random value from (0.0f, 0.0f) (inclusize) to 
        ///     (1.0f, 1.0f) (exclusive).
        /// </returns>
        public static Vector2 Vector2() => new(Float(), Float());

        /// <summary>
        ///     Get a random Vector2.
        /// </summary>
        /// <param name="max">The maximum value (excluded from range).</param>
        /// <returns>
        ///     Returns a random value from (0.0f, 0.0f) (inclusize) to 
        ///     (<paramref name="max"/>, <paramref name="max"/>) (exclusive).
        /// </returns>
        public static Vector2 Vector2(Vector2 max) => new(Float(max.X), Float(max.Y));

        /// <summary>
        ///     Get a random Vector2.
        /// </summary>
        /// <param name="maxX">The maximum X value (excluded from range).</param>
        /// <param name="maxY">The maximum Y value (excluded from range).</param>
        /// <returns>
        ///     Returns a random value from (0.0f, 0.0f) (inclusize) to 
        ///     (<paramref name="maxX"/>, <paramref name="maxY"/>) (exclusive).
        /// </returns>
        public static Vector2 Vector2(float maxX, float maxY) => new(Float(maxX), Float(maxY));

        /// <summary>
        ///     Get a random Vector2.
        /// </summary>
        /// <param name="min">The minimum value (included from range).</param>
        /// <param name="max">The maximum value (excluded from range).</param>
        /// <returns>
        ///     Returns a random value from (<paramref name="min"/>, <paramref name="min"/>)
        ///     (inclusize) to (<paramref name="max"/>, <paramref name="max"/>) (exclusive).
        /// </returns>
        public static Vector2 Vector2(Vector2 min, Vector2 max) => new(Float(min.X, max.X), Float(min.Y, max.Y));

        /// <summary>
        ///     Get a random Vector2.
        /// </summary>
        /// <param name="minX">The minimum X value (excluded from range).</param>
        /// <param name="minY">The minimum Y value (excluded from range).</param>
        /// <param name="maxX">The maximum X value (excluded from range).</param>
        /// <param name="maxY">The maximum Y value (excluded from range).</param>
        /// <returns>
        ///     Returns a random value from (<paramref name="minX"/>, <paramref name="minY"/>)
        ///     (inclusize) to (<paramref name="maxX"/>, <paramref name="maxY"/>) (exclusive).
        /// </returns>
        public static Vector2 Vector2(float minX, float maxX, float minY, float maxY) => new(Float(minX, maxX), Float(minY, maxY));

        #endregion

    }
}
