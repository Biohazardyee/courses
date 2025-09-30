# Other Data Structures

## Set

- Non-sequential data structure implementing the concept of a mathematical set.
- Two types of sets:
    - `set`: mutable
    - `frozenset`: immutable
- A set is a collection of unique elements. Duplicates are automatically removed when creating or updating a set.
- Sets are not indexed; elements are accessed by value, not by position.

### Syntax

```python
my_set = {item1, item2, item3}
my_set = set(other_structure)        # create set from another iterable
my_frozenset = frozenset(other_structure)  # create frozenset from another iterable
```

### Membership Operators

| Operator        | Description                                   |
| --------------- | --------------------------------------------- |
| `x in s`        | True if x is an element of s                  |
| `x not in s`    | True if x is not an element of s              |
| `len(s)`        | Number of elements in s                       |
| `s.isdisjoint(t)` | True if s and t have no elements in common  |
| `s.issubset(t)` | True if every element in s is in t            |
| `s <= t`        | Equivalent to `s.issubset(t)`                 |
| `s.issuperset(t)` | True if every element in t is in s          |
| `s >= t`        | Equivalent to `s.issuperset(t)`               |

### Set Operators

| Operator                  | Description                                         |
| ------------------------- | --------------------------------------------------- |
| `s.union(t)` or `s \| t`  | New set with elements from both s and t             |
| `s.intersection(t)` or `s & t` | New set with elements common to s and t      |
| `s.difference(t)` or `s - t` | New set with elements in s but not in t         |
| `s.symmetric_difference(t)` or `s ^ t` | New set with elements in either s or t but not both |

### Iterating Over Elements

- You can iterate over a set or frozenset using a loop:

```python
for x in my_set:
        print(x)
```

- The order of elements is not guaranteed and may differ from the insertion order.

### Set Update Operators

| Operator                         | Description                                         |
| --------------------------------- | --------------------------------------------------- |
| `s.update(t)` or `s \|= t`        | Add elements from t to s                            |
| `s.intersection_update(t)` or `s &= t` | Keep only elements also in t                   |
| `s.difference_update(t)` or `s -= t` | Remove elements found in t from s                |
| `s.symmetric_difference_update(t)` or `s ^= t` | Keep elements in either s or t but not both |

### Adding and Removing Elements

| Method         | Description                                                    |
| -------------- | -------------------------------------------------------------- |
| `s.add(x)`     | Add element x to set s                                         |
| `s.remove(x)`  | Remove x from s (raises error if not found)                    |
| `s.discard(x)` | Remove x from s (no error if not found)                        |
| `s.pop()`      | Remove and return an arbitrary element from s (error if empty) |
| `s.clear()`    | Remove all elements from s                                     |

### Set Comprehension

```python
{expression(x) for x in my_set if condition(x)}
```

Example:

```python
my_set = range(0, 10)
my_set = {x**2 for x in my_set if x % 2 == 0}
print(my_set)  # {0, 4, 16, 36, 64}
```

## Dictionary

- Mutable, non-sequential data structure for storing key/value pairs.
- Values are accessed by key, not by index.
- Keys must be immutable (e.g., string, number, tuple, frozenset) and unique.
- Values can be of any type and may be duplicated.

### Syntax

```python
my_dict = {key1: value1, key2: value2, key3: value3}
my_dict = dict([(key1, value1), (key2, value2)])  # from list of tuples
my_dict = dict(((key1, value1), (key2, value2)))  # from tuple of tuples
my_dict = dict(zip([key1, key2], [value1, value2]))  # from zipped lists
```

### Adding or Updating a Key/Value Pair

```python
my_dict[key4] = value4
```

- If `key4` does not exist, a new pair is added.
- If `key4` exists, its value is updated.

### Common Dictionary Operations

| Operator      | Description                                 |
| ------------- | ------------------------------------------- |
| `x in d`      | True if x is a key in d                     |
| `x not in d`  | True if x is not a key in d                 |
| `len(d)`      | Number of key/value pairs in d              |
| `d[key]`      | Value associated with key in d              |
| `del d[x]`    | Remove key x and its value                  |
| `d.clear()`   | Remove all key/value pairs                   |
| `d.update(t)` | Add key/value pairs from t to d             |

### Dictionary Methods

| Method                | Description                                                               |
| --------------------- | ------------------------------------------------------------------------- |
| `d.get(x)`            | Value for key x (None if not found)                                       |
| `d.get(x, default)`   | Value for key x (default if not found)                                    |
| `d.pop(x)`            | Remove key x and return its value (error if not found)                    |
| `d.pop(x, default)`   | Remove key x and return its value (default if not found)                  |
| `d.setdefault(x, y)`  | Return value for x; if not found, add x with value y and return y         |

### Iterating Over Keys

```python
for key in my_dict:
        print(key, my_dict[key])

for key in my_dict.keys():
        print(key, my_dict[key])
```

- Iteration order is the insertion order of key/value pairs.

### Iterating Over Values

```python
for value in my_dict.values():
        print(value)
```

### Iterating Over Key/Value Pairs

```python
for key, value in my_dict.items():
        print(key, value)
```

### Dictionary Comprehension

```python
{key(x, y): value(x, y) for x in my_set if condition(x, y)}
```

Example:

```python
my_dict1 = {chr(i+64): i for i in range(1, 6)}
my_dict2 = {v: k for k, v in my_dict1.items()}

print(my_dict1)  # {'A': 1, 'B': 2, 'C': 3, 'D': 4, 'E': 5}
print(my_dict2)  # {1: 'A', 2: 'B', 3: 'C', 4: 'D', 5: 'E'}
```

## Files

### Objectives of File Management

- Store data persistently (beyond program execution).
- In this context, a file is a medium for mass data storage.

### Two Main Types of Files

- **Text file**: Organized as lines of characters, each ending with `\n`.
- **Binary file**: Sequence of bytes, representing any data type (e.g., MP3, image, video).

### Opening a File

```python
my_file = open(file_name, mode)
```

Modes:

- `'r'`: Read-only (default). File must exist.
- `'w'`: Write-only. Creates a new file or overwrites an existing one.
- `'a'`: Append. Adds data to the end of the file or creates it if it doesn't exist.

- By default, files are opened in the script's directory. Use a path to specify another location.

### Closing a File

```python
my_file.close()
```

- Releases the file for use by other applications.

### Reading a File

| Command                | Description                                    |
| ---------------------- | ---------------------------------------------- |
| `my_file.read(size)`   | Read up to `size` characters (or bytes)        |
| `my_file.readline()`   | Read one line (up to `\n` or EOF)              |
| `my_file.readlines()`  | Read all lines and return as a list            |

- If no argument is passed to `read()`, the entire file is read.
- Reading with a size argument helps avoid memory issues with large files.
- The file pointer advances after each read.

### Reading a File in a Loop

```python
for line in my_file:
        print(line)
```

### Writing to a File

```python
my_file.write(string)
my_file.writelines(list_of_strings)
```

- Multiple writes append strings sequentially.
- Data must be a string; convert other types before writing.

