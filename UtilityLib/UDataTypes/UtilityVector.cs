﻿namespace UtilityLib.UDataTypes;

/// <summary>
/// Represents a generic vector interface.
/// </summary>
/// <typeparam name="T">The type of the vector components.</typeparam>
public interface IVector<T>
{
    /// <summary>
    /// Gets the zero vector for the specified type.
    /// </summary>
    public static T Zero { get; }

    /// <summary>
    /// Adds two vectors of the specified type.
    /// </summary>
    /// <param name="v1">The first vector.</param>
    /// <param name="v2">The second vector.</param>
    /// <returns>The sum of the two vectors.</returns>
    public static abstract T Add(T v1, T v2);

    /// <summary>
    /// Subtracts the second vector from the first vector.
    /// </summary>
    /// <param name="v1">The first vector.</param>
    /// <param name="v2">The second vector.</param>
    /// <returns>The result of subtracting the second vector from the first vector.</returns>
    public static abstract T Subtract(T v1, T v2);

    /// <summary>
    /// Multiplies two vectors of the specified type component-wise.
    /// </summary>
    /// <param name="v1">The first vector.</param>
    /// <param name="v2">The second vector.</param>
    /// <returns>The result of multiplying two vectors component-wise.</returns>
    public static abstract T Multiply(T v1, T v2);

    /// <summary>
    /// Divides the first vector by the second vector.
    /// </summary>
    /// <param name="v1">The numerator vector.</param>
    /// <param name="v2">The denominator vector.</param>
    /// <returns>The result of dividing the first vector by the second vector.</returns>
    public static abstract T Divide(T v1, T v2);

    /// <summary>
    /// Calculates the dot product of two vectors.
    /// </summary>
    /// <param name="v1">The first vector.</param>
    /// <param name="v2">The second vector.</param>
    /// <returns>The dot product of the two vectors.</returns>
    public static abstract double DotProduct(T v1, T v2);

    /// <summary>
    /// Calculates the angle (in radians) between two vectors.
    /// </summary>
    /// <param name="v1">The first vector.</param>
    /// <param name="v2">The second vector.</param>
    /// <returns>The angle (in radians) between the two vectors.</returns>
    public static abstract double AngleBetween(T v1, T v2);

    /// <summary>
    /// Gets a vector with components equal to the negation of the original vector.
    /// </summary>
    T Inverted { get; }

    /// <summary>
    /// Gets a vector with the same direction as the original vector but with a length of 1.
    /// </summary>
    T Normalized { get; }

    /// <summary>
    /// Gets the Euclidean length (magnitude) of the vector.
    /// </summary>
    double Length { get; }

    /// <summary>
    /// Adds the components of another vector to this vector.
    /// </summary>
    /// <param name="v">The vector to add.</param>
    /// <returns>The updated vector.</returns>
    T Add(T v);

    /// <summary>
    /// Subtracts the components of another vector from this vector.
    /// </summary>
    /// <param name="v">The vector to subtract.</param>
    /// <returns>The updated vector.</returns>
    T Subtract(T v);

    /// <summary>
    /// Divides the vector components by the components of another vector.
    /// </summary>
    /// <param name="v">The vector to divide by.</param>
    /// <returns>The updated vector.</returns>
    T Divide(T v);

    /// <summary>
    /// Multiplies the vector components by the components of another vector.
    /// </summary>
    /// <param name="v">The vector to multiply by.</param>
    /// <returns>The updated vector.</returns>
    T Multiply(T v);

    /// <summary>
    /// Inverts the sign of each vector component.
    /// </summary>
    /// <returns>The inverted vector.</returns>
    T Invert();

    /// <summary>
    /// Normalizes the vector to have a length of 1.
    /// </summary>
    /// <returns>The normalized vector.</returns>
    T Normalize();
}

/// <summary>
/// Represents a 3D vector with <see cref="X"/>, <see cref="Y"/>, and <see cref="Z"/> components.
/// </summary>
public class Vector3D : IVector<Vector3D>
{
    /// <summary>
    /// Gets or sets the <see cref="X"/> component of the vector.
    /// </summary>
    public double X { get; set; }

    /// <summary>
    /// Gets or sets the <see cref="Y"/> component of the vector.
    /// </summary>
    public double Y { get; set; }

    /// <summary>
    /// Gets or sets the <see cref="Z"/> component of the vector.
    /// </summary>
    public double Z { get; set; }

    /// <summary>
    /// Gets a vector with all components set to zero.
    /// </summary>
    public static Vector3D Zero => new(0, 0, 0);

    /// <summary>
    /// Adds two vectors.
    /// </summary>
    /// <param name="v1">The first vector.</param>
    /// <param name="v2">The second vector.</param>
    /// <returns>The sum of the two vectors.</returns>
    public static Vector3D Add(Vector3D v1, Vector3D v2) => new(v1.X + v2.X, v1.Y + v2.Y, v1.Z + v2.Z);

    /// <summary>
    /// Subtracts the second vector from the first vector.
    /// </summary>
    /// <param name="v1">The first vector.</param>
    /// <param name="v2">The second vector.</param>
    /// <returns>The result of subtracting the second vector from the first vector.</returns>
    public static Vector3D Subtract(Vector3D v1, Vector3D v2) => new(v1.X - v2.X, v1.Y - v2.Y, v1.Z - v2.Z);

    /// <summary>
    /// Divides the first vector by the second vector.
    /// </summary>
    /// <param name="v1">The numerator vector.</param>
    /// <param name="v2">The denominator vector.</param>
    /// <returns>The result of dividing the first vector by the second vector.</returns>
    public static Vector3D Divide(Vector3D v1, Vector3D v2) => new(v1.X / v2.X, v1.Y / v2.Y, v1.Z / v2.Z);

    /// <summary>
    /// Multiplies two vectors component-wise.
    /// </summary>
    /// <param name="v1">The first vector.</param>
    /// <param name="v2">The second vector.</param>
    /// <returns>The result of multiplying two vectors component-wise.</returns>
    public static Vector3D Multiply(Vector3D v1, Vector3D v2) => new(v1.X * v2.X, v1.Y * v2.Y, v1.Z * v2.Z);

    /// <summary>
    /// Calculates the dot product of two vectors.
    /// </summary>
    /// <param name="v1">The first vector.</param>
    /// <param name="v2">The second vector.</param>
    /// <returns>The dot product of the two vectors.</returns>
    public static double DotProduct(Vector3D v1, Vector3D v2) => v1.X * v2.X + v1.Y * v2.Y + v1.Z * v2.Z;

    /// <summary>
    /// Calculates the cross product of two vectors.
    /// </summary>
    /// <param name="v1">The first vector.</param>
    /// <param name="v2">The second vector.</param>
    /// <returns>The cross product of the two vectors.</returns>
    public static Vector3D CrossProduct(Vector3D v1, Vector3D v2) =>
        new(
            v1.Y * v2.Z - v1.Z * v2.Y,
            v1.Z * v2.X - v1.X * v2.Z,
            v1.X * v2.Y - v1.Y * v2.X
        );

    /// <summary>
    /// Calculates the angle (in radians) between two vectors.
    /// </summary>
    /// <param name="v1">The first vector.</param>
    /// <param name="v2">The second vector.</param>
    /// <returns>The angle (in radians) between the two vectors.</returns>
    public static double AngleBetween(Vector3D v1, Vector3D v2)
    {
        var dotProduct = DotProduct(v1, v2);
        var magnitudeProduct = v1.Length * v2.Length;

        // Ensure the denominator is not zero
        if (magnitudeProduct == 0) throw new InvalidOperationException("Cannot calculate the angle between vectors with zero magnitude.");
        var cosTheta = dotProduct / magnitudeProduct;
        return Math.Acos(cosTheta);

        // If the magnitude product is zero, the vectors are not well-defined
    }

    /// <summary>
    /// Initializes a new instance of the <see cref="Vector3D"/> class with specified components.
    /// </summary>
    /// <param name="x">The <see cref="X"/> component of the vector.</param>
    /// <param name="y">The <see cref="Y"/> component of the vector.</param>
    /// <param name="z">The <see cref="Z"/> component of the vector.</param>
    public Vector3D(double x = 0, double y = 0, double z = 0) { X = x; Y = y; Z = z; }

    /// <summary>
    /// Gets a vector with components equal to the negation of the original vector.
    /// </summary>
    /// <returns>The inverted vector.</returns>
    public Vector3D Inverted => new(-X, -Y, -Z);

    /// <summary>
    /// Gets a vector with the same direction as the original vector but with a length of 1.
    /// </summary>
    /// <returns>The normalized vector.</returns>
    public Vector3D Normalized
    {
        get
        {
            double length = Length;
            if (length != 0)
            {
                return new Vector3D(X * (1.0 / length), Y * (1.0 / length), Z * (1.0 / length));
            }
            throw new InvalidOperationException("Cannot normalize a vector with zero length.");
        }
    }

    /// <summary>
    /// Gets the Euclidean length (magnitude) of the vector.
    /// </summary>
    /// <returns>The length of the vector.</returns>
    public double Length => Math.Sqrt(X * X + Y * Y + Z * Z);

    /// <summary>
    /// Adds the specified values to the vector components.
    /// </summary>
    /// <param name="x">The value to add to the <see cref="X"/> component.</param>
    /// <param name="y">The value to add to the <see cref="Y"/> component.</param>
    /// <param name="z">The value to add to the <see cref="Z"/> component.</param>
    /// <returns>The updated vector.</returns>
    public Vector3D Add(double x = 0, double y = 0, double z = 0)
    {
        X += x; Y += y; Z += z;
        return this;
    }

    /// <summary>
    /// Adds the components of another vector to this vector.
    /// </summary>
    /// <param name="v">The vector to add.</param>
    /// <returns>The updated vector.</returns>
    public Vector3D Add(Vector3D v)
    {
        X += v.X; Y += v.Y; Z += v.Z;
        return this;
    }

    /// <summary>
    /// Subtracts the specified values from the vector components.
    /// </summary>
    /// <param name="x">The value to subtract from the <see cref="X"/> component.</param>
    /// <param name="y">The value to subtract from the <see cref="Y"/> component.</param>
    /// <param name="z">The value to subtract from the <see cref="Z"/> component.</param>
    /// <returns>The updated vector.</returns>
    public Vector3D Subtract(double x = 0, double y = 0, double z = 0)
    {
        X -= x; Y -= y; Z -= z;
        return this;
    }

    /// <summary>
    /// Subtracts the components of another vector from this vector.
    /// </summary>
    /// <param name="v">The vector to subtract.</param>
    /// <returns>The updated vector.</returns>
    public Vector3D Subtract(Vector3D v)
    {
        X -= v.X; Y -= v.Y; Z -= v.Z;
        return this;
    }

    /// <summary>
    /// Divides the vector components by the specified values.
    /// </summary>
    /// <param name="x">The value to divide the <see cref="X"/> component by.</param>
    /// <param name="y">The value to divide the <see cref="Y"/> component by.</param>
    /// <param name="z">The value to divide the <see cref="Z"/> component by.</param>
    /// <returns>The updated vector.</returns>
    public Vector3D Divide(double x = 0, double y = 0, double z = 0)
    {
        X /= x; Y /= y; Z /= z;
        return this;
    }

    /// <summary>
    /// Divides the vector components by the components of another vector.
    /// </summary>
    /// <param name="v">The vector to divide by.</param>
    /// <returns>The updated vector.</returns>
    public Vector3D Divide(Vector3D v)
    {
        X /= v.X; Y /= v.Y; Z /= v.Z;
        return this;
    }

    /// <summary>
    /// Multiplies the vector components by the specified values.
    /// </summary>
    /// <param name="x">The value to multiply the <see cref="X"/> component by.</param>
    /// <param name="y">The value to multiply the <see cref="Y"/> component by.</param>
    /// <param name="z">The value to multiply the <see cref="Z"/> component by.</param>
    /// <returns>The updated vector.</returns>
    public Vector3D Multiply(double x = 0, double y = 0, double z = 0)
    {
        X *= x; Y *= y; Z *= z;
        return this;
    }

    /// <summary>
    /// Multiplies the vector components by the components of another vector.
    /// </summary>
    /// <param name="v">The vector to multiply by.</param>
    /// <returns>The updated vector.</returns>
    public Vector3D Multiply(Vector3D v)
    {
        X *= v.X; Y *= v.Y; Z *= v.Z;
        return this;
    }

    /// <summary>
    /// Inverts the sign of each vector component.
    /// </summary>
    /// <returns>The inverted vector.</returns>
    public Vector3D Invert()
    {
        X = -X; Y = -Y; Z = -Z;
        return this;
    }

    /// <summary>
    /// Normalizes the vector to have a length of 1.
    /// </summary>
    /// <returns>The normalized vector.</returns>
    public Vector3D Normalize()
    {
        var length = Length;
        if (length == 0) throw new InvalidOperationException("Cannot normalize a vector with zero length.");
        X *= 1.0 / length; Y *= 1.0 / length; Z *= 1.0 / length;
        return this;
    }
}

/// <summary>
/// Represents a 2D vector with <see cref="X"/> and <see cref="Y"/> components.
/// </summary>
public class Vector2D : IVector<Vector2D>
{
    /// <summary>
    /// Gets or sets the <see cref="X"/> component of the vector.
    /// </summary>
    public double X { get; set; }

    /// <summary>
    /// Gets or sets the <see cref="Y"/> component of the vector.
    /// </summary>
    public double Y { get; set; }

    /// <summary>
    /// Gets a vector with all components set to zero.
    /// </summary>
    public static Vector2D Zero => new(0, 0);

    /// <summary>
    /// Initializes a new instance of the <see cref="Vector2D"/> class with specified components.
    /// </summary>
    /// <param name="x">The <see cref="X"/> component of the vector.</param>
    /// <param name="y">The <see cref="Y"/> component of the vector.</param>
    public Vector2D(double x = 0, double y = 0) { X = x; Y = y; }

    /// <summary>
    /// Gets a vector with components equal to the negation of the original vector.
    /// </summary>
    /// <returns>The inverted vector.</returns>
    public Vector2D Inverted => new(-X, -Y);

    /// <summary>
    /// Gets a vector with the same direction as the original vector but with a length of 1.
    /// </summary>
    /// <returns>The normalized vector.</returns>
    public Vector2D Normalized
    {
        get
        {
            double length = Length;
            if (length != 0)
            {
                return new Vector2D(X * (1.0 / length), Y * (1.0 / length));
            }
            throw new InvalidOperationException("Cannot normalize a vector with zero length.");
        }
    }

    /// <summary>
    /// Adds two vectors.
    /// </summary>
    /// <param name="v1">The first vector.</param>
    /// <param name="v2">The second vector.</param>
    /// <returns>The sum of the two vectors.</returns>
    public static Vector2D Add(Vector2D v1, Vector2D v2) => new(v1.X + v2.X, v1.Y + v2.Y);

    /// <summary>
    /// Subtracts the second vector from the first vector.
    /// </summary>
    /// <param name="v1">The first vector.</param>
    /// <param name="v2">The second vector.</param>
    /// <returns>The result of subtracting the second vector from the first vector.</returns>
    public static Vector2D Subtract(Vector2D v1, Vector2D v2) => new(v1.X - v2.X, v1.Y - v2.Y);

    /// <summary>
    /// Multiplies two vectors component-wise.
    /// </summary>
    /// <param name="v1">The first vector.</param>
    /// <param name="v2">The second vector.</param>
    /// <returns>The result of multiplying two vectors component-wise.</returns>
    public static Vector2D Multiply(Vector2D v1, Vector2D v2) => new(v1.X * v2.X, v1.Y * v2.Y);

    /// <summary>
    /// Divides the first vector by the second vector.
    /// </summary>
    /// <param name="v1">The numerator vector.</param>
    /// <param name="v2">The denominator vector.</param>
    /// <returns>The result of dividing the first vector by the second vector.</returns>
    public static Vector2D Divide(Vector2D v1, Vector2D v2) => new(v1.X / v2.X, v1.Y / v2.Y);

    /// <summary>
    /// Calculates the dot product of two vectors.
    /// </summary>
    /// <param name="v1">The first vector.</param>
    /// <param name="v2">The second vector.</param>
    /// <returns>The dot product of the two vectors.</returns>
    public static double DotProduct(Vector2D v1, Vector2D v2) => v1.X * v2.X + v1.Y * v2.Y;

    /// <summary>
    /// Calculates the angle (in radians) between two vectors.
    /// </summary>
    /// <param name="v1">The first vector.</param>
    /// <param name="v2">The second vector.</param>
    /// <returns>The angle (in radians) between the two vectors.</returns>
    public static double AngleBetween(Vector2D v1, Vector2D v2)
    {
        var dotProduct = DotProduct(v1, v2);
        var magnitudeProduct = v1.Length * v2.Length;

        // Ensure the denominator is not zero
        if (magnitudeProduct == 0) throw new InvalidOperationException("Cannot calculate the angle between vectors with zero magnitude.");
        var cosTheta = dotProduct / magnitudeProduct;
        return Math.Acos(cosTheta);

        // If the magnitude product is zero, the vectors are not well-defined
    }

    /// <summary>
    /// Gets the Euclidean length (magnitude) of the vector.
    /// </summary>
    /// <returns>The length of the vector.</returns>
    public double Length => Math.Sqrt(X * X + Y * Y);

    /// <summary>
    /// Adds the specified values to the vector components.
    /// </summary>
    /// <param name="x">The value to add to the <see cref="X"/> component.</param>
    /// <param name="y">The value to add to the <see cref="Y"/> component.</param>
    /// <returns>The updated vector.</returns>
    public Vector2D Add(double x = 0, double y = 0)
    {
        X += x; Y += y;
        return this;
    }

    /// <summary>
    /// Adds the components of another vector to this vector.
    /// </summary>
    /// <param name="v">The vector to add.</param>
    /// <returns>The updated vector.</returns>
    public Vector2D Add(Vector2D v)
    {
        X += v.X; Y += v.Y;
        return this;
    }

    /// <summary>
    /// Subtracts the specified values from the vector components.
    /// </summary>
    /// <param name="x">The value to subtract from the <see cref="X"/> component.</param>
    /// <param name="y">The value to subtract from the <see cref="Y"/> component.</param>
    /// <returns>The updated vector.</returns>
    public Vector2D Subtract(double x = 0, double y = 0)
    {
        X -= x; Y -= y;
        return this;
    }

    /// <summary>
    /// Subtracts the components of another vector from this vector.
    /// </summary>
    /// <param name="v">The vector to subtract.</param>
    /// <returns>The updated vector.</returns>
    public Vector2D Subtract(Vector2D v)
    {
        X -= v.X; Y -= v.Y;
        return this;
    }

    /// <summary>
    /// Divides the vector components by the specified values.
    /// </summary>
    /// <param name="x">The value to divide the <see cref="X"/> component by.</param>
    /// <param name="y">The value to divide the <see cref="Y"/> component by.</param>
    /// <returns>The updated vector.</returns>
    public Vector2D Divide(double x = 0, double y = 0)
    {
        X /= x; Y /= y;
        return this;
    }

    /// <summary>
    /// Divides the vector components by the components of another vector.
    /// </summary>
    /// <param name="v">The vector to divide by.</param>
    /// <returns>The updated vector.</returns>
    public Vector2D Divide(Vector2D v)
    {
        X /= v.X; Y /= v.Y;
        return this;
    }

    /// <summary>
    /// Multiplies the vector components by the specified values.
    /// </summary>
    /// <param name="x">The value to multiply the <see cref="X"/> component by.</param>
    /// <param name="y">The value to multiply the <see cref="Y"/> component by.</param>
    /// <returns>The updated vector.</returns>
    public Vector2D Multiply(double x = 0, double y = 0)
    {
        X *= x; Y *= y;
        return this;
    }

    /// <summary>
    /// Multiplies the vector components by the components of another vector.
    /// </summary>
    /// <param name="v">The vector to multiply by.</param>
    /// <returns>The updated vector.</returns>
    public Vector2D Multiply(Vector2D v)
    {
        X *= v.X; Y *= v.Y;
        return this;
    }

    /// <summary>
    /// Inverts the sign of each vector component.
    /// </summary>
    /// <returns>The inverted vector.</returns>
    public Vector2D Invert()
    {
        X = -X; Y = -Y;
        return this;
    }

    /// <summary>
    /// Normalizes the vector to have a length of 1.
    /// </summary>
    /// <returns>The normalized vector.</returns>
    public Vector2D Normalize()
    {
        double length = Length;
        if (length != 0)
        {
            X *= 1.0 / length; Y *= 1.0 / length;
            return this;
        }
        throw new InvalidOperationException("Cannot normalize a vector with zero length.");
    }
}

/// <summary>
/// Represents a 4D vector with components <see cref="X"/>, <see cref="Y"/>, <see cref="Z"/>, and <see cref="W"/>.
/// </summary>
public class Vector4D : IVector<Vector4D>
{
    /// <summary>
    /// Gets a vector with all components set to zero.
    /// </summary>
    public static Vector4D Zero => new(0, 0, 0, 0);

    /// <summary>
    /// Gets or sets the X component of the vector.
    /// </summary>
    public double X { get; set; }

    /// <summary>
    /// Gets or sets the Y component of the vector.
    /// </summary>
    public double Y { get; set; }

    /// <summary>
    /// Gets or sets the Z component of the vector.
    /// </summary>
    public double Z { get; set; }

    /// <summary>
    /// Gets or sets the W component of the vector.
    /// </summary>
    public double W { get; set; }

    /// <summary>
    /// Initializes a new instance of the <see cref="Vector4D"/> class with specified components.
    /// </summary>
    /// <param name="x">The X component of the vector.</param>
    /// <param name="y">The Y component of the vector.</param>
    /// <param name="z">The Z component of the vector.</param>
    /// <param name="w">The W component of the vector.</param>
    public Vector4D(double x, double y, double z, double w) { X = x; Y = y; Z = z; W = w; }

    /// <summary>
    /// Gets a vector with components equal to the negation of the original vector.
    /// </summary>
    /// <returns>The inverted vector.</returns>
    public Vector4D Inverted => new(X * -1, Y * -1, Z * -1, W * -1);

    /// <summary>
    /// Gets a vector with the same direction as the original vector but with a length of 1.
    /// </summary>
    /// <returns>The normalized vector.</returns>
    public Vector4D Normalized
    {
        get
        {
            var length = Length;
            if (length != 0)
            {
                return new Vector4D(X * (1.0 / length), Y * (1.0 / length), Z * (1.0 / length), W * (1.0 / length));
            }
            throw new InvalidOperationException("Cannot normalize a vector with zero length.");
        }
    }

    /// <summary>
    /// Gets the Euclidean length (magnitude) of the vector.
    /// </summary>
    /// <returns>The length of the vector.</returns>
    public double Length => Math.Sqrt(X * X + Y * Y + Z * Z + W * W);

    /// <summary>
    /// Adds two vectors component-wise.
    /// </summary>
    /// <param name="v1">The first vector.</param>
    /// <param name="v2">The second vector.</param>
    /// <returns>The sum of the two vectors.</returns>
    public static Vector4D Add(Vector4D v1, Vector4D v2) => new(v1.X + v2.X, v1.Y + v2.Y, v1.Z + v2.Z, v1.W + v2.W);

    /// <summary>
    /// Adds the specified values to the vector components.
    /// </summary>
    /// <param name="x">The value to add to the <see cref="X"/> component.</param>
    /// <param name="y">The value to add to the <see cref="Y"/> component.</param>
    /// <param name="z">The value to add to the <see cref="Z"/> component.</param>
    /// <param name="w">The value to add to the <see cref="W"/> component.</param>
    /// <returns>The updated vector.</returns>
    public Vector4D Add(double x, double y, double z, double w) { X += x; Y += y; Z += z; W += w; return this; }

    /// <summary>
    /// Adds the components of another vector to this vector.
    /// </summary>
    /// <param name="v">The vector to add.</param>
    /// <returns>The updated vector.</returns>
    public Vector4D Add(Vector4D v) { X += v.X; Y += v.Y; Z += v.Z; W += v.W; return this; }

    /// <summary>
    /// Divides the first vector by the second vector component-wise.
    /// </summary>
    /// <param name="v1">The numerator vector.</param>
    /// <param name="v2">The denominator vector.</param>
    /// <returns>The result of dividing the first vector by the second vector.</returns>
    public static Vector4D Divide(Vector4D v1, Vector4D v2) => new(v1.X / v2.X, v1.Y / v2.Y, v1.Z / v2.Z, v1.W / v2.W);

    /// <summary>
    /// Divides the vector components by the specified values.
    /// </summary>
    /// <param name="x">The value to divide the <see cref="X"/> component by.</param>
    /// <param name="y">The value to divide the <see cref="Y"/> component by.</param>
    /// <param name="z">The value to divide the <see cref="Z"/> component by.</param>
    /// <param name="w">The value to divide the <see cref="W"/> component by.</param>
    /// <returns>The updated vector.</returns>
    public Vector4D Divide(double x, double y, double z, double w) { X /= x; Y /= y; Z /= z; W /= w; return this; }

    /// <summary>
    /// Divides the vector components by the components of another vector.
    /// </summary>
    /// <param name="v">The vector to divide by.</param>
    /// <returns>The updated vector.</returns>
    public Vector4D Divide(Vector4D v) { X /= v.X; Y /= v.Y; Z /= v.Z; W /= v.W; return this; }

    /// <summary>
    /// Inverts the sign of each vector component.
    /// </summary>
    /// <returns>The inverted vector.</returns>
    public Vector4D Invert() { X *= -1; Y *= -1; Z *= -1; W *= -1; return this; }

    /// <summary>
    /// Multiplies two vectors component-wise.
    /// </summary>
    /// <param name="v1">The first vector.</param>
    /// <param name="v2">The second vector.</param>
    /// <returns>The result of multiplying two vectors component-wise.</returns>
    public static Vector4D Multiply(Vector4D v1, Vector4D v2) => new(v1.X * v2.X, v1.Y * v2.Y, v1.Z * v2.Z, v1.W * v2.W);

    /// <summary>
    /// Multiplies the vector components by the specified values.
    /// </summary>
    /// <param name="x">The value to multiply the <see cref="X"/> component by.</param>
    /// <param name="y">The value to multiply the <see cref="Y"/> component by.</param>
    /// <param name="z">The value to multiply the <see cref="Z"/> component by.</param>
    /// <param name="w">The value to multiply the <see cref="W"/> component by.</param>
    /// <returns>The updated vector.</returns>
    public Vector4D Multiply(double x, double y, double z, double w) { X *= x; Y *= y; Z *= z; W *= w; return this; }

    /// <summary>
    /// Multiplies the vector components by the components of another vector.
    /// </summary>
    /// <param name="v">The vector to multiply by.</param>
    /// <returns>The updated vector.</returns>
    public Vector4D Multiply(Vector4D v) { X *= v.X; Y *= v.Y; Z *= v.Z; W *= v.W; return this; }

    /// <summary>
    /// Normalizes the vector to have a length of 1.
    /// </summary>
    /// <returns>The normalized vector.</returns>
    public Vector4D Normalize()
    {
        double length = Length;
        if (length != 0)
        {
            X *= (1.0 / length); Y *= (1.0 / length); Z *= (1.0 / length); W *= (1.0 / length);
            return this;
        }
        throw new InvalidOperationException("Cannot normalize a vector with zero length.");
    }

    /// <summary>
    /// Subtracts the second vector from the first vector.
    /// </summary>
    /// <param name="v1">The first vector.</param>
    /// <param name="v2">The second vector.</param>
    /// <returns>The result of subtracting the second vector from the first vector.</returns>
    public static Vector4D Subtract(Vector4D v1, Vector4D v2) => new(v1.X - v2.X, v1.Y - v2.Y, v1.Z - v2.Z, v1.W - v2.W);

    /// <summary>
    /// Subtracts the specified values from the vector components.
    /// </summary>
    /// <param name="x">The value to subtract from the <see cref="X"/> component.</param>
    /// <param name="y">The value to subtract from the <see cref="Y"/> component.</param>
    /// <param name="z">The value to subtract from the <see cref="Z"/> component.</param>
    /// <param name="w">The value to subtract from the <see cref="W"/> component.</param>
    /// <returns>The updated vector.</returns>
    public Vector4D Subtract(double x, double y, double z, double w) { X -= x; Y -= y; Z -= z; W -= w; return this; }

    /// <summary>
    /// Subtracts the components of another vector from this vector.
    /// </summary>
    /// <param name="v">The vector to subtract.</param>
    /// <returns>The updated vector.</returns>
    public Vector4D Subtract(Vector4D v) { X -= v.X; Y -= v.Y; Z -= v.Z; W -= v.W; return this; }

    /// <summary>
    /// Calculates the dot product of two vectors.
    /// </summary>
    /// <param name="v1">The first vector.</param>
    /// <param name="v2">The second vector.</param>
    /// <returns>The dot product of the two vectors.</returns>
    public static double DotProduct(Vector4D v1, Vector4D v2) => v1.X * v2.X + v1.Y * v2.Y + v1.Z * v2.Z + v1.W * v2.W;

    /// <summary>
    /// Calculates the angle (in radians) between two vectors.
    /// </summary>
    /// <param name="v1">The first vector.</param>
    /// <param name="v2">The second vector.</param>
    /// <returns>The angle (in radians) between the two vectors.</returns>
    public static double AngleBetween(Vector4D v1, Vector4D v2)
    {
        double dotProduct = DotProduct(v1, v2);
        double magnitudeProduct = v1.Length * v2.Length;

        // Ensure the denominator is not zero
        if (magnitudeProduct != 0)
        {
            double cosTheta = dotProduct / magnitudeProduct;
            return Math.Acos(cosTheta);
        }

        // If the magnitude product is zero, the vectors are not well-defined
        throw new InvalidOperationException("Cannot calculate the angle between vectors with zero magnitude.");
    }

}
