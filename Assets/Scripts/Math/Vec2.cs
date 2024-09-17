using System;
using System.Runtime.CompilerServices;

namespace Physics2DLibrary.Math
{
    /// <summary>
    /// Represents a 2D vector and provides methods for vector operations.
    /// </summary>
    public struct Vec2
    {
        public float x;
        public float y;

        /// <summary>
        /// Initializes a new instance of the <see cref="Vec2"/> struct with the specified x and y components.
        /// </summary>
        /// <param name="x">The x component of the vector.</param>
        /// <param name="y">The y component of the vector.</param>
        public Vec2(float x, float y)
        {
            this.x = x;
            this.y = y;
        }

        /// <summary>
        /// Gets the magnitude (length) of the vector.
        /// </summary>
        public readonly float Magnitude()
        {
            return (float)System.Math.Sqrt(x * x + y * y);
        }

        /// <summary>
        /// Gets the squared magnitude of the vector. This is more efficient than <see cref="Magnitude"/> when comparing lengths.
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly float SqrMagnitude()
        {
            return x * x + y * y;
        }

        /// <summary>
        /// Normalizes the vector, returning a unit vector in the same direction.
        /// </summary>
        public readonly Vec2 Normalize()
        {
            float magnitude = Magnitude();
            if (magnitude > 0)
            {
                float inverseMagnitude = 1.0f / magnitude; // Avoid division
                return new Vec2(x * inverseMagnitude, y * inverseMagnitude);
            }
            return new Vec2(0, 0);
        }

        /// <summary>
        /// Adds two vectors.
        /// </summary>
        /// <param name="a">The first vector.</param>
        /// <param name="b">The second vector.</param>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vec2 operator +(Vec2 a, Vec2 b)
        {
            return new Vec2(a.x + b.x, a.y + b.y);
        }

        /// <summary>
        /// Subtracts one vector from another.
        /// </summary>
        /// <param name="a">The vector to subtract from.</param>
        /// <param name="b">The vector to subtract.</param>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vec2 operator -(Vec2 a, Vec2 b)
        {
            return new Vec2(a.x - b.x, a.y - b.y);
        }

        /// <summary>
        /// Multiplies a vector by a scalar.
        /// </summary>
        /// <param name="v">The vector.</param>
        /// <param name="scalar">The scalar value.</param>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vec2 operator *(Vec2 v, float scalar)
        {
            return new Vec2(v.x * scalar, v.y * scalar);
        }

        /// <summary>
        /// Divides a vector by a scalar.
        /// </summary>
        /// <param name="v">The vector.</param>
        /// <param name="scalar">The scalar value.</param>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vec2 operator /(Vec2 v, float scalar)
        {
            return new Vec2(v.x / scalar, v.y / scalar);
        }

        /// <summary>
        /// Calculates the dot product of two vectors.
        /// </summary>
        /// <param name="a">The first vector.</param>
        /// <param name="b">The second vector.</param>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float Dot(Vec2 a, Vec2 b)
        {
            return a.x * b.x + a.y * b.y;
        }

        /// <summary>
        /// Calculates the cross product of two vectors. In 2D, this returns a scalar representing the magnitude of the 3D cross product.
        /// </summary>
        /// <param name="a">The first vector.</param>
        /// <param name="b">The second vector.</param>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float Cross(Vec2 a, Vec2 b)
        {
            return a.x * b.y - a.y * b.x;
        }

        /// <summary>
        /// Calculates the angle in radians between two vectors.
        /// </summary>
        /// <param name="a">The first vector.</param>
        /// <param name="b">The second vector.</param>
        public static float AngleBetween(Vec2 a, Vec2 b)
        {
            float dot = Dot(a, b);
            float magnitudeProduct = (float)System.Math.Sqrt(a.SqrMagnitude() * b.SqrMagnitude());
            return (float)System.Math.Acos(dot / magnitudeProduct);
        }

        /// <summary>
        /// Returns a string representation of the vector.
        /// </summary>
        public override readonly string ToString()
        {
            return $"({x}, {y})";
        }
    }
}
