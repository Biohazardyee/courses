# Programs and Subroutines

## General Concepts of Algorithms

- A **subroutine** is a block of instructions that performs a specific task.
- It has a name, can accept parameters, and may return a result.
- A well-structured script typically contains a main program and several subroutines.

When a subroutine is called, program execution jumps to the subroutine, executes it, and then returns to the point where it was called. The main program is suspended during the subroutine's execution.

**Advantages of using subroutines:**
- Avoid code duplication
- Enable code reuse
- Improve program design

### Parameters

- Subroutines are used to perform generic operations.
- These operations depend on data, which can vary with each call.
- These data items are called **parameters**; they are passed to the subroutine when it is called.

When implementing a subroutine, you define all the parameters it needs. When calling a subroutine, you provide values for these parameters. Inside the subroutine, these parameters are treated as local variables.

### Best Practices

- If a subroutine needs data from the main program, it is better to pass them as parameters rather than using global variables.
- This increases code reusability and maintainability.

### Types of Subroutines

- **Procedures:** Modify the program state but do not return a value.
- **Functions:** Return a value and can be used in expressions.

Not all programming languages distinguish between procedures and functions:
- In Python, C, and C++, only functions exist, though documentation may distinguish them by behavior.
- In Pascal or PL/SQL, procedures and functions are clearly distinguished.

## Python Subroutines

### Defining a Function

```python
def my_function(param1, param2, ..., paramN):
    # block of instructions
    ...
    return result
```

### Defining a Procedure

```python
def my_procedure(param1, param2, ..., paramN):
    # block of instructions
    ...
    return
```

### Using Subroutines

- Call the subroutine by its name and provide values for its parameters.
- Parameters can be variables or explicit values.
- For functions, ensure you use the returned value by assigning it to a variable, using it in an expression, or outputting it.

**Example: Calculating the area and perimeter of a rectangle**

```python
def rectangle(x, y):
    print("Perimeter:", 2 * (x + y), "Area:", x * y)

rectangle(5, 2)
length, width = 3, 4
rectangle(length, width)
```

### Example: Calculating the Golden Ratio

```python
from math import sqrt

def print_golden_ratio():
    print(round((1 + sqrt(5)) / 2, 2))

print_golden_ratio()
```

### Example: Calculating the Cube of a Number

```python
def cube(x):
    return x * x * x

print(cube(3))
```

- A function can return multiple values, separated by commas.
- A function can contain multiple return statements, but only one will be executed per call.

**Example: Calculating the minimum and maximum of two numbers**

```python
def calc_min_max(a, b):
    if a < b:
        return a, b
    else:
        return b, a

a, b = 5, -2
mini, maxi = calc_min_max(a, cube(b))
print("Minimum is", mini, "Maximum is", maxi)
```

### Duck Typing

In Python, parameter and return types are not specified in the subroutine definition.

This means you can use a subroutine with parameters of any type, as long as the operations inside the subroutine are compatible with those types.

**Example:**

```python
def add(x, y):
    return x + y

print(add(666, 1))

a, b = "Hello ", "World!"
print(add(a, b))
```

### Default Parameter Values

- You can define default values for parameters in the subroutine definition. These defaults are used if no value is provided when the subroutine is called.
- Only parameters at the end of the parameter list can have default values.

**Example:**

```python
def rectangle(x, y=1):
    print("Perimeter:", 2 * (x + y), "Area:", x * y)

rectangle(5)
rectangle(5, 2)
```

### Immutable Parameters

- Types like `int`, `bool`, `float`, `str`, and `complex` are immutable.
- If you pass a variable of one of these types to a subroutine, the subroutine cannot modify the variable's value in the main program.

**Example:**

```python
def doubler1(x):
    x = x * 2
    return x

y = 3
print("Before:", y)
doubler1(y)
print("After:", y)

def doubler2(x):
    return x * 2

z = 3
print("Before:", z)
z = doubler2(z)
print("After:", z)
```

### Local Variables

```python
def sum_integers(n):
    s = 0
    for i in range(n + 1):
        s = s + i
    return s
```

- The variables `s` and `i` are local to the function and are not accessible outside of it.

### Modules

- A **module** is a `.py` file containing Python code, often grouping related subroutines.
- To use a module, you must import it.

#### Three Ways to Import a Module

Import everything:

```python
from MyModule import *
import MyModule
```

Import a specific subroutine:

```python
from MyModule import my_subroutine
```

- Modules can be standard libraries (like `math`, `tkinter`), third-party libraries, or your own code.
- Using `import myModule` requires you to prefix subroutine calls with the module name: `myModule.my_subroutine()`.
- This is preferred when multiple modules may have subroutines with the same name.

**Examples:**

```python
from math import *
print(sqrt(25))
```

```python
import math
print(math.sqrt(25))
```

```python
from math import pi
print(pi)
```
