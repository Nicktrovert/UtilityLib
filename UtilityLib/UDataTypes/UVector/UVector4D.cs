namespace UtilityLib.UDataTypes.UVector;

/// <summary>
/// Represents a 4D vector with components <see cref="X"/>, <see cref="Y"/>, <see cref="Z"/>, and <see cref="W"/>.
/// </summary>
public struct UVector4D : IUVector<UVector4D>
{
    /// <summary>
    /// Gets a vector with all components set to zero.
    /// </summary>
    public static UVector4D Zero => new(0, 0, 0, 0);

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
    /// Initializes a new instance of the <see cref="UVector4D"/> class with specified components.
    /// </summary>
    /// <param name="x">The X component of the vector.</param>
    /// <param name="y">The Y component of the vector.</param>
    /// <param name="z">The Z component of the vector.</param>
    /// <param name="w">The W component of the vector.</param>
    public UVector4D(double x, double y, double z, double w) { X = x; Y = y; Z = z; W = w; }

    /// <summary>
    /// Gets a vector with components equal to the negation of the original vector.
    /// </summary>
    /// <returns>The inverted vector.</returns>
    public UVector4D Inverted => new(X * -1, Y * -1, Z * -1, W * -1);

    /// <summary>
    /// Gets a vector with the same direction as the original vector but with a length of 1.
    /// </summary>
    /// <returns>The normalized vector.</returns>
    public UVector4D Normalized
    {
        get
        {
            var length = Length;
            if (length != 0)
            {
                return new UVector4D(X * (1.0 / length), Y * (1.0 / length), Z * (1.0 / length), W * (1.0 / length));
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
    public static UVector4D Add(UVector4D v1, UVector4D v2) => new(v1.X + v2.X, v1.Y + v2.Y, v1.Z + v2.Z, v1.W + v2.W);

    /// <summary>
    /// Adds the specified values to the vector components.
    /// </summary>
    /// <param name="x">The value to add to the <see cref="X"/> component.</param>
    /// <param name="y">The value to add to the <see cref="Y"/> component.</param>
    /// <param name="z">The value to add to the <see cref="Z"/> component.</param>
    /// <param name="w">The value to add to the <see cref="W"/> component.</param>
    /// <returns>The updated vector.</returns>
    public UVector4D Add(double x, double y, double z, double w) { X += x; Y += y; Z += z; W += w; return this; }

    /// <summary>
    /// Adds the components of another vector to this vector.
    /// </summary>
    /// <param name="v">The vector to add.</param>
    /// <returns>The updated vector.</returns>
    public UVector4D Add(UVector4D v) { X += v.X; Y += v.Y; Z += v.Z; W += v.W; return this; }

    /// <summary>
    /// Divides the first vector by the second vector component-wise.
    /// </summary>
    /// <param name="v1">The numerator vector.</param>
    /// <param name="v2">The denominator vector.</param>
    /// <returns>The result of dividing the first vector by the second vector.</returns>
    public static UVector4D Divide(UVector4D v1, UVector4D v2) => new(v1.X / v2.X, v1.Y / v2.Y, v1.Z / v2.Z, v1.W / v2.W);

    /// <summary>
    /// Divides the vector components by the specified values.
    /// </summary>
    /// <param name="x">The value to divide the <see cref="X"/> component by.</param>
    /// <param name="y">The value to divide the <see cref="Y"/> component by.</param>
    /// <param name="z">The value to divide the <see cref="Z"/> component by.</param>
    /// <param name="w">The value to divide the <see cref="W"/> component by.</param>
    /// <returns>The updated vector.</returns>
    public UVector4D Divide(double x, double y, double z, double w) { X /= x; Y /= y; Z /= z; W /= w; return this; }

    /// <summary>
    /// Divides the vector components by the components of another vector.
    /// </summary>
    /// <param name="v">The vector to divide by.</param>
    /// <returns>The updated vector.</returns>
    public UVector4D Divide(UVector4D v) { X /= v.X; Y /= v.Y; Z /= v.Z; W /= v.W; return this; }

    /// <summary>
    /// Inverts the sign of each vector component.
    /// </summary>
    /// <returns>The inverted vector.</returns>
    public UVector4D Invert() { X *= -1; Y *= -1; Z *= -1; W *= -1; return this; }

    /// <summary>
    /// Multiplies two vectors component-wise.
    /// </summary>
    /// <param name="v1">The first vector.</param>
    /// <param name="v2">The second vector.</param>
    /// <returns>The result of multiplying two vectors component-wise.</returns>
    public static UVector4D Multiply(UVector4D v1, UVector4D v2) => new(v1.X * v2.X, v1.Y * v2.Y, v1.Z * v2.Z, v1.W * v2.W);

    /// <summary>
    /// Multiplies the vector components by the specified values.
    /// </summary>
    /// <param name="x">The value to multiply the <see cref="X"/> component by.</param>
    /// <param name="y">The value to multiply the <see cref="Y"/> component by.</param>
    /// <param name="z">The value to multiply the <see cref="Z"/> component by.</param>
    /// <param name="w">The value to multiply the <see cref="W"/> component by.</param>
    /// <returns>The updated vector.</returns>
    public UVector4D Multiply(double x, double y, double z, double w) { X *= x; Y *= y; Z *= z; W *= w; return this; }

    /// <summary>
    /// Multiplies the vector components by the components of another vector.
    /// </summary>
    /// <param name="v">The vector to multiply by.</param>
    /// <returns>The updated vector.</returns>
    public UVector4D Multiply(UVector4D v) { X *= v.X; Y *= v.Y; Z *= v.Z; W *= v.W; return this; }

    /// <summary>
    /// Normalizes the vector to have a length of 1.
    /// </summary>
    /// <returns>The normalized vector.</returns>
    public UVector4D Normalize()
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
    public static UVector4D Subtract(UVector4D v1, UVector4D v2) => new(v1.X - v2.X, v1.Y - v2.Y, v1.Z - v2.Z, v1.W - v2.W);

    /// <summary>
    /// Subtracts the specified values from the vector components.
    /// </summary>
    /// <param name="x">The value to subtract from the <see cref="X"/> component.</param>
    /// <param name="y">The value to subtract from the <see cref="Y"/> component.</param>
    /// <param name="z">The value to subtract from the <see cref="Z"/> component.</param>
    /// <param name="w">The value to subtract from the <see cref="W"/> component.</param>
    /// <returns>The updated vector.</returns>
    public UVector4D Subtract(double x, double y, double z, double w) { X -= x; Y -= y; Z -= z; W -= w; return this; }

    /// <summary>
    /// Subtracts the components of another vector from this vector.
    /// </summary>
    /// <param name="v">The vector to subtract.</param>
    /// <returns>The updated vector.</returns>
    public UVector4D Subtract(UVector4D v) { X -= v.X; Y -= v.Y; Z -= v.Z; W -= v.W; return this; }

    /// <summary>
    /// Calculates the dot product of two vectors.
    /// </summary>
    /// <param name="v1">The first vector.</param>
    /// <param name="v2">The second vector.</param>
    /// <returns>The dot product of the two vectors.</returns>
    public static double DotProduct(UVector4D v1, UVector4D v2) => v1.X * v2.X + v1.Y * v2.Y + v1.Z * v2.Z + v1.W * v2.W;

    /// <summary>
    /// Calculates the angle (in radians) between two vectors.
    /// </summary>
    /// <param name="v1">The first vector.</param>
    /// <param name="v2">The second vector.</param>
    /// <returns>The angle (in radians) between the two vectors.</returns>
    public static double AngleBetween(UVector4D v1, UVector4D v2)
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