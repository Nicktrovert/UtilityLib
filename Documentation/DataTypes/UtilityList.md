# UList Namespace Documentation

## UList<T> struct
Represents a generic List structure.

### - Type Parameters
- `T`: The type of the List.

### - Properties
- `Length` | `Size` | `Count`: Gets the amount of elements in the `List`.

### - Methods
- `Add(T obj)`: Adds `obj` `T` to the `List`.
- `Add(T[] objs)`: Adds all elements in `objs` `T[]` to the `List`.
- `GetAmountOf(T obj)`: Gets an `int` with the number of times `obj` `T` appears in the `List`. 
- `RemoveAt(int index)`: Removes the element at position `int` `index` from the `List`.
- `Remove(T obj, bool DeleteAll)`: Removes either first`DeleteAll = false` 
or all`DeleteAll = true` instances of `T` `obj` from the `List`.

### - Constructor
- `UList()`: Initializes a new **empty** `UList`.
- `UList(T[] objs)`: Initializes a new `UList` with `T[]` `objs` in it.

## Examples:

- ### Empty List Initialization
  ```C#
  using UtilityLib.UDataTypes;
  
  ...
  
  public void Main(String[] args){
    UList<int> MyList = new UList<int>();
  }
  ```
  
---

- ### List Initialization with elements
  ```C#
  using UtilityLib.UDataTypes;
  
  ...
  
  public void Main(String[] args){
    int[] IntArray = new int[5] {0, 1, 2, 3, 4};
    UList<int> MyList = new UList<int>(IntArray);
  }
  ```