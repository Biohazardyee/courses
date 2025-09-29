# Sequential Data Structures

## Sequential Structures

- Combine multiple values of the same type into a single variable.
- The goal is to optimize operations such as searching and sorting algorithms.

- This data grouping can be achieved in several ways:
    - Sequential structures
    - Sets
    - Dictionaries
    - Classes
    - Graphs
    - Trees

- Each element can be accessed by its position, typically referred to as rank or index.

- Every element except the first has a predecessor, and every element except the last has a successor.

### The Three Main Types of Sequences

1. **Lists**
     - Mutable
     - Elements can be of different types
     - Ordered
     - Allow duplicates
2. **Tuples**
     - Immutable
     - Elements can be of different types
     - Ordered
     - Allow duplicates
3. **Strings**
     - Immutable
     - Elements are characters
     - Ordered
     - Allow duplicates

### Syntax for Creating Sequences

```python
myList = [item1, item2, ..., itemN]        # List
myList = list(otherStructure)              # List from another structure
myTuple = (item1, item2, ..., itemN)       # Tuple
myTuple = tuple(otherStructure)            # Tuple from another structure
myString = "my string"                     # String
```

### Accessing Sequence Elements

| Operation | Result                                           |
| --------- | ------------------------------------------------ |
| s[i]      | i-th element of s                                |
| s[i:j]    | Subsequence from index i to j-1                  |
| s[i:j:k]  | Subsequence from index i to j-1 with step k      |

### Common Sequence Operations

| Operation      | Result                                  |
| -------------- | --------------------------------------- |
| x in s         | Checks if x is in s                     |
| x not in s     | Checks if x is not in s                 |
| s + t          | Concatenates sequences s and t          |
| s * n          | Repeats sequence s n times              |
| len(s)         | Length of sequence s                    |
| min(s)         | Minimum element of s                    |
| max(s)         | Maximum element of s                    |
| s.index(x)     | Index of the first occurrence of x in s |
| s.count(x)     | Number of occurrences of x in s         |

### Iterating Over Elements vs Indices

```python
for x in mySequence:
        # process x

for i in range(len(mySequence)):
        # process mySequence[i]
```

- Iteration by index is often preferred.

### Iterating Over Pairs and Multiple Sequences

```python
for i, x in enumerate(mySequence):
        # process i (index) and x (element)

for x, y in zip(sequence1, sequence2):
        # process x (from sequence1) and y (from sequence2)
```

## Lists

### Consequences of List Mutability

1. List elements can be modified, added, or removed.
2. Passing a list as a parameter allows it to be modified within a subroutine.

**Example: Modifying a List in a Function**

```python
def swap(l, i, j):
        l[i], l[j] = l[j], l[i]

myList = [1, 2, 3, 4, 5]
print("Before swap:", myList)
swap(myList, 0, 3)
print("After swap:", myList)
```

### List Operations

| Operation      | Result                                                  |
| -------------- | ------------------------------------------------------- |
| s.append(x)    | Adds x to the end of list s                             |
| s.insert(i, x) | Inserts x at index i in s                               |
| s.remove(x)    | Removes the first occurrence of x in s                  |
| s.pop(i)       | Removes and returns the element at index i in s         |
| s.clear()      | Removes all elements from s                             |
| s.sort()       | Sorts s in place                                        |
| s.reverse()    | Reverses s in place                                     |
| s.extend(t)    | Appends all elements of t to s                          |
| s.copy()       | Returns a shallow copy of s                             |
| s.count(x)     | Counts occurrences of x in s                            |
| s.index(x)     | Returns index of first occurrence of x in s             |

### List Comprehensions

```python
[expression(x) for x in mySequence if condition]
```

**Example:**

```python
mySequence = tuple(range(0, 10))
myList = [x**2 for x in mySequence if x % 2 == 0]
print(myList)  # Output: [0, 4, 16, 36, 64]
```

### Multidimensional Lists

- Lists can contain other lists, enabling multidimensional structures (e.g., matrices).

**Accessing elements in a 2D list:**

```python
myList[i][j]
```

**Example:**

```python
board = [[0] * 3 for i in range(4)]  # 4x3 matrix of zeros
board[3][2] = 666
for i in range(4):
        for j in range(3):
                print(board[i][j], end=' ')
        print('\n')
```

### Copying Lists

- Assigning with `list2 = list1` creates an alias, not a new list.
- Both names refer to the same memory address; changes via one affect the other.

**To copy a list:**

```python
myList2 = myList1[:]
myList2 = list(myList1)

import copy
myList2 = copy.copy(myList1)  # Shallow copy

myList2 = []
myList2.extend(myList1)
```

#### Deep Copy

- For nested lists, use a deep copy:

```python
import copy
myList2 = copy.deepcopy(myList1)
```

## Strings

### String-Specific Operations

| Operation         | Result                                         |
| ----------------- | ---------------------------------------------- |
| ord(c)            | ASCII value of character c                     |
| chr(n)            | Character for ASCII value n                    |
| s.lower()         | Returns a lowercase copy of s                  |
| s.upper()         | Returns an uppercase copy of s                 |

### Splitting and Joining Strings

```python
myText.split(sep)  # Default sep is None
sep.join(myList)
```

## Tuples

### Consequences of Tuple Immutability

1. Tuple elements cannot be modified, added, or removed.
2. Passing a tuple as a parameter does not allow modification within a subroutine.

**Example: Attempting to Modify a Tuple**

```python
def swap(t, i, j):
        t[i], t[j] = t[j], t[i]  # Raises an error

myTuple = (1, 2, 3, 4, 5)
print("Before swap:", myTuple)
swap(myTuple, 0, 3)
print("After swap:", myTuple)
```

### Tuple Use Cases

- Use tuples for sequences of data that should not be modified (e.g., constants).
- Iterating over tuples is faster than lists.
- Functions can return multiple values as a tuple.
- Tuples can be used as dictionary keys; lists cannot.

**Example: Counting Vowel Occurrences with a Tuple**

```python
def vowels(word):
        t = ('a', 'e', 'i', 'o', 'u', 'y')
        s = 0
        word = word.lower()
        for x in t:
                s += word.count(x)
        return s

print(vowels("Hello World!"))  # Output: 3
```
