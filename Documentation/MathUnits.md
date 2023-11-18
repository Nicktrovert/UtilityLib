### Disclaimer this Documentation was written by ChatGPT

# MathUnits Library

## Namespace: UtilityLib.MathUnits

### IVector<T> Interface

Represents a generic vector interface.

#### Properties

- `T Zero`: Gets the zero vector for the specified type.
- `T Inverted`: Gets a vector with components equal to the negation of the original vector.
- `T Normalized`: Gets a vector with the same direction as the original vector but with a length of 1.
- `double Length`: Gets the Euclidean length (magnitude) of the vector.

#### Methods

- `T Add(T v1, T v2)`: Adds two vectors of the specified type.
- `T Subtract(T v1, T v2)`: Subtracts the second vector from the first vector.
- `T Multiply(T v1, T v2)`: Multiplies two vectors of the specified type component-wise.
- `T Divide(T v1, T v2)`: Divides the first vector by the second vector.
- `T Add(T v)`: Adds the components of another vector to this vector.
- `T Subtract(T v)`: Subtracts the components of another vector from this vector.
- `T Divide(T v)`: Divides the vector components by the components of another vector.
- `T Multiply(T v)`: Multiplies the vector components by the components of another vector.
- `T Invert()`: Inverts the sign of each vector component.
- `T Normalize()`: Normalizes the vector to have a length of 1.

### Vector3D Class

Represents a 3D vector with X, Y, and Z components.

#### Properties

- `double X`: Gets or sets the X component of the vector.
- `double Y`: Gets or sets the Y component of the vector.
- `double Z`: Gets or sets the Z component of the vector.
- `static Vector3D Zero`: Gets a vector with all components set to zero.
- `Vector3D Inverted`: Gets a vector with components equal to the negation of the original vector.
- `Vector3D Normalized`: Gets a vector with the same direction as the original vector but with a length of 1.
- `double Length`: Gets the Euclidean length (magnitude) of the vector.

#### Methods

- `Vector3D Add(Vector3D v1, Vector3D v2)`: Adds two vectors.
- `Vector3D Subtract(Vector3D v1, Vector3D v2)`: Subtracts the second vector from the first vector.
- `Vector3D Divide(Vector3D v1, Vector3D v2)`: Divides the first vector by the second vector.
- `Vector3D Multiply(Vector3D v1, Vector3D v2)`: Multiplies two vectors component-wise.
- `Vector3D Add(double x, double y, double z)`: Adds the specified values to the vector components.
- `Vector3D Add(Vector3D v)`: Adds the components of another vector to this vector.
- `Vector3D Subtract(double x, double y, double z)`: Subtracts the specified values from the vector components.
- `Vector3D Subtract(Vector3D v)`: Subtracts the components of another vector from this vector.
- `Vector3D Divide(double x, double y, double z)`: Divides the vector components by the specified values.
- `Vector3D Divide(Vector3D v)`: Divides the vector components by the components of another vector.
- `Vector3D Multiply(double x, double y, double z)`: Multiplies the vector components by the specified values.
- `Vector3D Multiply(Vector3D v)`: Multiplies the vector components by the components of another vector.
- `Vector3D Invert()`: Inverts the sign of each vector component.
- `Vector3D Normalize()`: Normalizes the vector to have a length of 1.

### Vector2D Class

Represents a 2D vector with X and Y components.

#### Properties

- `double X`: Gets or sets the X component of the vector.
- `double Y`: Gets or sets the Y component of the vector.
- `static Vector2D Zero`: Gets a vector with all components set to zero.
- `Vector2D Inverted`: Gets a vector with components equal to the negation of the original vector.
- `Vector2D Normalized`: Gets a vector with the same direction as the original vector but with a length of 1.
- `double Length`: Gets the Euclidean length (magnitude) of the vector.

#### Methods

- `Vector2D Add(Vector2D v1, Vector2D v2)`: Adds two vectors.
- `Vector2D Subtract(Vector2D v1, Vector2D v2)`: Subtracts the second vector from the first vector.
- `Vector2D Divide(Vector2D v1, Vector2D v2)`: Divides the first vector by the second vector.
- `Vector2D Multiply(Vector2D v1, Vector2D v2)`: Multiplies two vectors component-wise.
- `Vector2D Add(double x, double y)`: Adds the specified values to the vector components.
- `Vector2D Add(Vector2D v)`: Adds the components of another vector to this vector.
- `Vector2D Subtract(double x, double y)`: Subtracts the specified values from the vector components.
- `Vector2D Subtract(Vector2D v)`: Subtracts the components of another vector from this vector.
- `Vector2D Divide(double x, double y)`: Divides the vector components by the specified values.
- `Vector2D Divide(Vector2D v)`: Divides the vector components by the components of another vector.
- `Vector2D Multiply(double x, double y)`: Multiplies the vector components by the specified values.
- `Vector2D Multiply(Vector2D v)`: Multiplies the vector components by the components of another vector.
- `Vector2D Invert()`: Inverts the sign of each vector component.
- `Vector2D Normalize()`: Normalizes the vector to have a length of 1.

## Conclusion

The MathUnits library provides a set of classes and interfaces for working with vectors in 2D and 3D space. The `IVector<T>` interface defines common vector operations, and the `Vector2D` and `Vector3D` classes implement these operations for 2D and 3D vectors, respectively. These classes provide a convenient and efficient way to perform vector arithmetic in mathematical and computer graphics applications.
