namespace UtilityLib.UData.UVector;

/// <summary>
/// Represents a generic vector interface.
/// </summary>
/// <typeparam name="T">The type of the vector components.</typeparam>
public interface IUVector<T>
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