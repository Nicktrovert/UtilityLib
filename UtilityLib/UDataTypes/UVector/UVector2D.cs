namespace UtilityLib.UDataTypes.UVector;

/// <summary>
/// Represents a 2D vector with <see cref="X"/> and <see cref="Y"/> components.
/// </summary>
public struct UVector2D : IUVector<UVector2D>
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
    public static UVector2D Zero => new(0, 0);

    /// <summary>
    /// Initializes a new instance of the <see cref="UVector2D"/> class with specified components.
    /// </summary>
    /// <param name="x">The <see cref="X"/> component of the vector.</param>
    /// <param name="y">The <see cref="Y"/> component of the vector.</param>
    public UVector2D(double x = 0, double y = 0) { X = x; Y = y; }

    /// <summary>
    /// Gets a vector with components equal to the negation of the original vector.
    /// </summary>
    /// <returns>The inverted vector.</returns>
    public UVector2D Inverted => new(-X, -Y);

    /// <summary>
    /// Gets a vector with the same direction as the original vector but with a length of 1.
    /// </summary>
    /// <returns>The normalized vector.</returns>
    public UVector2D Normalized
    {
        get
        {
            double length = Length;
            if (length != 0)
            {
                return new UVector2D(X * (1.0 / length), Y * (1.0 / length));
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
    public static UVector2D Add(UVector2D v1, UVector2D v2) => new(v1.X + v2.X, v1.Y + v2.Y);

    /// <summary>
    /// Subtracts the second vector from the first vector.
    /// </summary>
    /// <param name="v1">The first vector.</param>
    /// <param name="v2">The second vector.</param>
    /// <returns>The result of subtracting the second vector from the first vector.</returns>
    public static UVector2D Subtract(UVector2D v1, UVector2D v2) => new(v1.X - v2.X, v1.Y - v2.Y);

    /// <summary>
    /// Multiplies two vectors component-wise.
    /// </summary>
    /// <param name="v1">The first vector.</param>
    /// <param name="v2">The second vector.</param>
    /// <returns>The result of multiplying two vectors component-wise.</returns>
    public static UVector2D Multiply(UVector2D v1, UVector2D v2) => new(v1.X * v2.X, v1.Y * v2.Y);

    /// <summary>
    /// Divides the first vector by the second vector.
    /// </summary>
    /// <param name="v1">The numerator vector.</param>
    /// <param name="v2">The denominator vector.</param>
    /// <returns>The result of dividing the first vector by the second vector.</returns>
    public static UVector2D Divide(UVector2D v1, UVector2D v2) => new(v1.X / v2.X, v1.Y / v2.Y);

    /// <summary>
    /// Calculates the dot product of two vectors.
    /// </summary>
    /// <param name="v1">The first vector.</param>
    /// <param name="v2">The second vector.</param>
    /// <returns>The dot product of the two vectors.</returns>
    public static double DotProduct(UVector2D v1, UVector2D v2) => v1.X * v2.X + v1.Y * v2.Y;

    /// <summary>
    /// Calculates the angle (in radians) between two vectors.
    /// </summary>
    /// <param name="v1">The first vector.</param>
    /// <param name="v2">The second vector.</param>
    /// <returns>The angle (in radians) between the two vectors.</returns>
    public static double AngleBetween(UVector2D v1, UVector2D v2)
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
    public UVector2D Add(double x = 0, double y = 0)
    {
        X += x; Y += y;
        return this;
    }

    /// <summary>
    /// Adds the components of another vector to this vector.
    /// </summary>
    /// <param name="v">The vector to add.</param>
    /// <returns>The updated vector.</returns>
    public UVector2D Add(UVector2D v)
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
    public UVector2D Subtract(double x = 0, double y = 0)
    {
        X -= x; Y -= y;
        return this;
    }

    /// <summary>
    /// Subtracts the components of another vector from this vector.
    /// </summary>
    /// <param name="v">The vector to subtract.</param>
    /// <returns>The updated vector.</returns>
    public UVector2D Subtract(UVector2D v)
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
    public UVector2D Divide(double x = 0, double y = 0)
    {
        X /= x; Y /= y;
        return this;
    }

    /// <summary>
    /// Divides the vector components by the components of another vector.
    /// </summary>
    /// <param name="v">The vector to divide by.</param>
    /// <returns>The updated vector.</returns>
    public UVector2D Divide(UVector2D v)
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
    public UVector2D Multiply(double x = 0, double y = 0)
    {
        X *= x; Y *= y;
        return this;
    }

    /// <summary>
    /// Multiplies the vector components by the components of another vector.
    /// </summary>
    /// <param name="v">The vector to multiply by.</param>
    /// <returns>The updated vector.</returns>
    public UVector2D Multiply(UVector2D v)
    {
        X *= v.X; Y *= v.Y;
        return this;
    }

    /// <summary>
    /// Inverts the sign of each vector component.
    /// </summary>
    /// <returns>The inverted vector.</returns>
    public UVector2D Invert()
    {
        X = -X; Y = -Y;
        return this;
    }

    /// <summary>
    /// Normalizes the vector to have a length of 1.
    /// </summary>
    /// <returns>The normalized vector.</returns>
    public UVector2D Normalize()
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