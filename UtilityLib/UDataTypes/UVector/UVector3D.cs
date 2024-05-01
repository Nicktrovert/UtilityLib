namespace UtilityLib.UDataTypes.UVector;

/// <summary>
/// Represents a 3D vector with <see cref="X"/>, <see cref="Y"/>, and <see cref="Z"/> components.
/// </summary>
public struct UVector3D : IUVector<UVector3D>
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
    public static UVector3D Zero => new(0, 0, 0);

    /// <summary>
    /// Adds two vectors.
    /// </summary>
    /// <param name="v1">The first vector.</param>
    /// <param name="v2">The second vector.</param>
    /// <returns>The sum of the two vectors.</returns>
    public static UVector3D Add(UVector3D v1, UVector3D v2) => new(v1.X + v2.X, v1.Y + v2.Y, v1.Z + v2.Z);

    /// <summary>
    /// Subtracts the second vector from the first vector.
    /// </summary>
    /// <param name="v1">The first vector.</param>
    /// <param name="v2">The second vector.</param>
    /// <returns>The result of subtracting the second vector from the first vector.</returns>
    public static UVector3D Subtract(UVector3D v1, UVector3D v2) => new(v1.X - v2.X, v1.Y - v2.Y, v1.Z - v2.Z);

    /// <summary>
    /// Divides the first vector by the second vector.
    /// </summary>
    /// <param name="v1">The numerator vector.</param>
    /// <param name="v2">The denominator vector.</param>
    /// <returns>The result of dividing the first vector by the second vector.</returns>
    public static UVector3D Divide(UVector3D v1, UVector3D v2) => new(v1.X / v2.X, v1.Y / v2.Y, v1.Z / v2.Z);

    /// <summary>
    /// Multiplies two vectors component-wise.
    /// </summary>
    /// <param name="v1">The first vector.</param>
    /// <param name="v2">The second vector.</param>
    /// <returns>The result of multiplying two vectors component-wise.</returns>
    public static UVector3D Multiply(UVector3D v1, UVector3D v2) => new(v1.X * v2.X, v1.Y * v2.Y, v1.Z * v2.Z);

    /// <summary>
    /// Calculates the dot product of two vectors.
    /// </summary>
    /// <param name="v1">The first vector.</param>
    /// <param name="v2">The second vector.</param>
    /// <returns>The dot product of the two vectors.</returns>
    public static double DotProduct(UVector3D v1, UVector3D v2) => v1.X * v2.X + v1.Y * v2.Y + v1.Z * v2.Z;

    /// <summary>
    /// Calculates the cross product of two vectors.
    /// </summary>
    /// <param name="v1">The first vector.</param>
    /// <param name="v2">The second vector.</param>
    /// <returns>The cross product of the two vectors.</returns>
    public static UVector3D CrossProduct(UVector3D v1, UVector3D v2) =>
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
    public static double AngleBetween(UVector3D v1, UVector3D v2)
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
    /// Initializes a new instance of the <see cref="UVector3D"/> class with specified components.
    /// </summary>
    /// <param name="x">The <see cref="X"/> component of the vector.</param>
    /// <param name="y">The <see cref="Y"/> component of the vector.</param>
    /// <param name="z">The <see cref="Z"/> component of the vector.</param>
    public UVector3D(double x = 0, double y = 0, double z = 0) { X = x; Y = y; Z = z; }

    /// <summary>
    /// Gets a vector with components equal to the negation of the original vector.
    /// </summary>
    /// <returns>The inverted vector.</returns>
    public UVector3D Inverted => new(-X, -Y, -Z);

    /// <summary>
    /// Gets a vector with the same direction as the original vector but with a length of 1.
    /// </summary>
    /// <returns>The normalized vector.</returns>
    public UVector3D Normalized
    {
        get
        {
            double length = Length;
            if (length != 0)
            {
                return new UVector3D(X * (1.0 / length), Y * (1.0 / length), Z * (1.0 / length));
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
    public UVector3D Add(double x = 0, double y = 0, double z = 0)
    {
        X += x; Y += y; Z += z;
        return this;
    }

    /// <summary>
    /// Adds the components of another vector to this vector.
    /// </summary>
    /// <param name="v">The vector to add.</param>
    /// <returns>The updated vector.</returns>
    public UVector3D Add(UVector3D v)
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
    public UVector3D Subtract(double x = 0, double y = 0, double z = 0)
    {
        X -= x; Y -= y; Z -= z;
        return this;
    }

    /// <summary>
    /// Subtracts the components of another vector from this vector.
    /// </summary>
    /// <param name="v">The vector to subtract.</param>
    /// <returns>The updated vector.</returns>
    public UVector3D Subtract(UVector3D v)
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
    public UVector3D Divide(double x = 0, double y = 0, double z = 0)
    {
        X /= x; Y /= y; Z /= z;
        return this;
    }

    /// <summary>
    /// Divides the vector components by the components of another vector.
    /// </summary>
    /// <param name="v">The vector to divide by.</param>
    /// <returns>The updated vector.</returns>
    public UVector3D Divide(UVector3D v)
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
    public UVector3D Multiply(double x = 0, double y = 0, double z = 0)
    {
        X *= x; Y *= y; Z *= z;
        return this;
    }

    /// <summary>
    /// Multiplies the vector components by the components of another vector.
    /// </summary>
    /// <param name="v">The vector to multiply by.</param>
    /// <returns>The updated vector.</returns>
    public UVector3D Multiply(UVector3D v)
    {
        X *= v.X; Y *= v.Y; Z *= v.Z;
        return this;
    }

    /// <summary>
    /// Inverts the sign of each vector component.
    /// </summary>
    /// <returns>The inverted vector.</returns>
    public UVector3D Invert()
    {
        X = -X; Y = -Y; Z = -Z;
        return this;
    }

    /// <summary>
    /// Normalizes the vector to have a length of 1.
    /// </summary>
    /// <returns>The normalized vector.</returns>
    public UVector3D Normalize()
    {
        var length = Length;
        if (length == 0) throw new InvalidOperationException("Cannot normalize a vector with zero length.");
        X *= 1.0 / length; Y *= 1.0 / length; Z *= 1.0 / length;
        return this;
    }
}