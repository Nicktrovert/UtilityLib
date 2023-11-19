### Disclaimer: this Documentation was written by ChatGPT

# MathUnits Namespace Documentation

## IVector<T> Interface

Represents a generic vector interface.

### Type Parameters

- `T`: The type of the vector components.

### Properties

- `Zero`: Gets the zero vector for the specified type.

### Methods

- `Add(T v1, T v2)`: Adds two vectors of the specified type.
- `Subtract(T v1, T v2)`: Subtracts the second vector from the first vector.
- `Multiply(T v1, T v2)`: Multiplies two vectors component-wise.
- `Divide(T v1, T v2)`: Divides the first vector by the second vector.

### Additional Properties

- `Inverted`: Gets a vector with components equal to the negation of the original vector.
- `Normalized`: Gets a vector with the same direction as the original vector but with a length of 1.
- `Length`: Gets the Euclidean length (magnitude) of the vector.

### Additional Methods

- `Add(T v)`: Adds the components of another vector to this vector.
- `Subtract(T v)`: Subtracts the components of another vector from this vector.
- `Divide(T v)`: Divides the vector components by the components of another vector.
- `Multiply(T v)`: Multiplies the vector components by the components of another vector.
- `Invert()`: Inverts the sign of each vector component.
- `Normalize()`: Normalizes the vector to have a length of 1.

## Vector3D Class

Represents a 3D vector with X, Y, and Z components.

### Properties

- `X`: Gets or sets the X component of the vector.
- `Y`: Gets or sets the Y component of the vector.
- `Z`: Gets or sets the Z component of the vector.

### Static Properties

- `Zero`: Gets a vector with all components set to zero.

### Static Methods

- `Add(Vector3D v1, Vector3D v2)`: Adds two vectors.
- `Subtract(Vector3D v1, Vector3D v2)`: Subtracts the second vector from the first vector.
- `Divide(Vector3D v1, Vector3D v2)`: Divides the first vector by the second vector.
- `Multiply(Vector3D v1, Vector3D v2)`: Multiplies two vectors component-wise.

### Constructors

- `Vector3D(double x = 0, double y = 0, double z = 0)`: Initializes a new instance of the Vector3D class with specified components.

### Additional Properties

- `Inverted`: Gets a vector with components equal to the negation of the original vector.
- `Normalized`: Gets a vector with the same direction as the original vector but with a length of 1.
- `Length`: Gets the Euclidean length (magnitude) of the vector.

### Additional Methods

- `Add(double x = 0, double y = 0, double z = 0)`: Adds the specified values to the vector components.
- `Add(Vector3D v)`: Adds the components of another vector to this vector.
- `Subtract(double x = 0, double y = 0, double z = 0)`: Subtracts the specified values from the vector components.
- `Subtract(Vector3D v)`: Subtracts the components of another vector from this vector.
- `Divide(double x = 0, double y = 0, double z = 0)`: Divides the vector components by the specified values.
- `Divide(Vector3D v)`: Divides the vector components by the components of another vector.
- `Multiply(double x = 0, double y = 0, double z = 0)`: Multiplies the vector components by the specified values.
- `Multiply(Vector3D v)`: Multiplies the vector components by the components of another vector.
- `Invert()`: Inverts the sign of each vector component.
- `Normalize()`: Normalizes the vector to have a length of 1.

## Vector2D Class

Represents a 2D vector with X and Y components.

### Properties

- `X`: Gets or sets the X component of the vector.
- `Y`: Gets or sets the Y component of the vector.

### Static Properties

- `Zero`: Gets a vector with all components set to zero.

### Static Methods

- `Add(Vector2D v1, Vector2D v2)`: Adds two vectors.
- `Subtract(Vector2D v1, Vector2D v2)`: Subtracts the second vector from the first vector.
- `Multiply(Vector2D v1, Vector2D v2)`: Multiplies two vectors component-wise.
- `Divide(Vector2D v1, Vector2D v2)`: Divides the first vector by the second vector.

### Constructors

- `Vector2D(double x = 0, double y = 0)`: Initializes a new instance of the Vector2D class with specified components.

### Additional Properties

- `Inverted`: Gets a vector with components equal to the negation of the original vector.
- `Normalized`: Gets a vector with the same direction as the original vector but with a length of 1.
- `Length`: Gets the Euclidean length (magnitude) of the vector.

### Additional Methods

- `Add(double x = 0, double y = 0)`: Adds the specified values to the vector components.
- `Add(Vector2D v)`: Adds the components of another vector to this vector.
- `Subtract(double x = 0, double y = 0)`: Subtracts the specified values from the vector components.
- `Subtract(Vector2D v)`: Subtracts the components of another vector from this vector.
- `Divide(double x = 0, double y = 0)`: Divides the vector components by the specified values.
- `Divide(Vector2D v)`: Divides the vector components by the components of another vector.
- `Multiply(double x = 0, double y = 0)`: Multiplies the vector components by the specified values.
- `Multiply(Vector2D v)`: Multiplies the vector components by the components of another vector.
- `Invert()`: Inverts the sign of each vector component.
- `Normalize()`: Normalizes the vector to have a length of 1.

## Vector4D Class

Represents a 4D vector with X, Y, Z, and W components.

### Properties

- `X`: Gets or sets the X component of the vector.
- `Y`: Gets or sets the Y component of the vector.
- `Z`: Gets or sets the Z component of the vector.
- `W`: Gets or sets the W component of the vector.

### Static Properties

- `Zero`: Gets a vector with all components set to zero.

### Static Methods

- `Add(Vector4D v1, Vector4D v2)`: Adds two vectors.
- `Subtract(Vector4D v1, Vector4D v2)`: Subtracts the second vector from the first vector.
- `Divide(Vector4D v1, Vector4D v2)`: Divides the first vector by the second vector.
- `Multiply(Vector4D v1, Vector4D v2)`: Multiplies two vectors component-wise.

### Constructors

- `Vector4D(double x = 0, double y = 0, double z = 0, double w = 0)`: Initializes a new instance of the Vector4D class with specified components.

### Additional Properties

- `Inverted`: Gets a vector with components equal to the negation of the original vector.
- `Normalized`: Gets a vector with the same direction as the original vector but with a length of 1.
- `Length`: Gets the Euclidean length (magnitude) of the vector.

### Additional Methods

- `Add(double x = 0, double y = 0, double z = 0, double w = 0)`: Adds the specified values to the vector components.
- `Add(Vector4D v)`: Adds the components of another vector to this vector.
- `Subtract(double x = 0, double y = 0, double z = 0, double w = 0)`: Subtracts the specified values from the vector components.
- `Subtract(Vector4D v)`: Subtracts the components of another vector from this vector.
- `Divide(double x = 0, double y = 0, double z = 0, double w = 0)`: Divides the vector components by the specified values.
- `Divide(Vector4D v)`: Divides the vector components by the components of another vector.
- `Multiply(double x = 0, double y = 0, double z = 0, double w = 0)`: Multiplies the vector components by the specified values.
- `Multiply(Vector4D v)`: Multiplies the vector components by the components of another vector.
- `Invert()`: Inverts the sign of each vector component.
- `Normalize()`: Normalizes the vector to have a length of 1.

### Static Methods

- `DotProduct(IVector v1, IVector v2)`: Computes the dot product of two vectors.
- `CrossProduct(Vector3D v1, Vector3D v2)`: Computes the cross product of two 3D vectors.
- `AngleBetween(IVector v1, IVector v2)`: Computes the angle (in radians) between two vectors.

# Conclusion

The `MathUnits` namespace provides a flexible and comprehensive set of classes and interfaces for working with vectors in both 2D and 3D space. The `IVector<T>` interface defines common vector operations, and the `Vector2D`, `Vector3D`, and `Vector4D` classes implement these operations for 2D, 3D, and 4D vectors, respectively. The `VectorOperations` class contains additional static methods for performing vector-specific operations. These classes can be used in various mathematical and computational scenarios where vector manipulation is required.

For more detailed usage examples and guidelines, refer to the inline comments in the source code.
