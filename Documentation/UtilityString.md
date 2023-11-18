### Disclaimer: this Documentation was written by ChatGPT

# UtilityString Class

## Namespace: UtilityLib.UString

Provides utility methods for string manipulations.

### UpperFirstChar Method

Converts the first character of the input string to uppercase.

#### Parameters

- `input` (string): The input string.

#### Returns

- `string`: A new string with the first letter in uppercase.

### UpperFirstChar Method (Overloaded)

Converts the first character of each string in the input list to uppercase.

#### Parameters

- `input` (IList<string>): The input list of strings.

#### Returns

- `IList<string>`: A list of strings with the first letter in uppercase.

### UpperEachFirstChar Method

Converts the first character of each word in the input string to uppercase.

#### Parameters

- `input` (string): The input string.
- `SymbolsAsWordSeparators` (bool, optional): Specifies whether symbols should be considered as word separators. Default is `false`.

#### Returns

- `string`: A new string with the first letter of each word in uppercase.

### UpperEachFirstChar Method (Overloaded)

Converts the first character of each word in each string in the input list to uppercase.

#### Parameters

- `input` (IList<string>): The input list of strings.
- `SymbolsAsWordSeparators` (bool, optional): Specifies whether symbols should be considered as word separators. Default is `false`.

#### Returns

- `IList<string>`: A list of strings with the first letter of each word in uppercase.

## Conclusion

The `UtilityString` class provides convenient methods for capitalizing the first letter of a string or the first letter of each word in a string or a list of strings. These methods are useful for formatting and displaying text in a more visually appealing way.
