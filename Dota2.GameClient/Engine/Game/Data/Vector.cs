﻿/*
    This file heavily based off of the nora project.
    See https://github.com/dschleck/nora/blob/master/lara/state/Vectors.cs
*/

namespace Dota2.Engine.Game.Data
{
    /// <summary>
    ///     x,y,z coordinate in the game world
    /// </summary>
    public struct Vector
    {
        public readonly float X, Y, Z;

        public Vector(float x, float y, float z)
        {
            X = x;
            Y = y;
            Z = z;
        }

        public static bool operator ==(Vector a, Vector b)
        {
            return a.X == b.X && a.Y == b.Y && a.Z == b.Z;
        }

        public static bool operator !=(Vector a, Vector b)
        {
            return a.X != b.X || a.Y != b.Y || a.Z != b.Z;
        }

        public override bool Equals(object obj)
        {
            if (!(obj is Vector))
            {
                return false;
            }
            var o = (Vector) obj;
            return X == o.X && Y == o.Y && Z == o.Z;
        }

        public override int GetHashCode()
        {
            var hash = 17;
            hash = hash*23 + X.GetHashCode();
            hash = hash*23 + Y.GetHashCode();
            hash = hash*23 + Z.GetHashCode();
            return hash;
        }

        public override string ToString()
        {
            return $"<{X}, {Y}, {Z}>";
        }
    }

    public struct VectorXy
    {
        public readonly float X, Y;

        public VectorXy(float x, float y)
        {
            X = x;
            Y = y;
        }

        public override string ToString()
        {
            return $"<{X}, {Y}>";
        }
    }
}