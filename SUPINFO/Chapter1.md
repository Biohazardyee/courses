# First Steps

## Algorithms and Python Programming

### What is an Algorithm?

- An algorithm is a clear, step-by-step procedure for solving a problem in a finite number of steps.
- It takes specific inputs and produces the required outputs.
- The steps should be general enough to apply to a range of data, not just specific examples.

#### Example: Recipe

**Problem:** How to prepare crepe batter?

**Steps:**

1. Mix three eggs with 250g of flour.
2. Stir until combined.
3. Gradually add 1/2 liter of milk while mixing.
4. Add a tablespoon of oil and blend thoroughly.

#### History

- The term "algorithm" originates from the Persian mathematician Abu Abdullah Muhammad ibn Musa al-Khwarizmi.
- His name was adapted to "algoritmi" in Latin during the Middle Ages.
- The concept of algorithms has existed since ancient times.

#### Example: Interest Rate

**Problem:** How many years are needed to double an initial amount with an annual interest rate T?

**Steps:**

1. Let `t` be the interest rate, set `a = 0` (years), and `b = 1` (initial amount).
2. While `b < 2`:
   - Update `b` to `b * (1 + t)`.
   - Increment `a` by 1.
3. When the loop ends, `a` is the number of years required to double the amount.

### From Algorithm to Program

- Algorithms are often first written informally, such as on paper.
- These instructions are then translated into a programming language.
  - Problem → Algorithm → Program
- The algorithm defines the logic and abstraction behind the program.

```python
def years(t):
    a, b = 0, 1
    while b < 2:
        b = b * (1 + t)
        a = a + 1
    return a
```

## Python Programming

### Variables

- A variable is a named storage location for data (such as numbers or text) whose value can change during program execution.
- Each variable has a type, which determines the kind of values it can hold and the operations allowed.

| Type    | Description                     |
| ------- | ------------------------------- |
| int     | Integer values                  |
| float   | Decimal (floating-point) values |
| complex | Complex numbers                 |
| bool    | Boolean values (True/False)     |
| str     | Strings (text)                  |

### Assigning Values

- Simple assignment: `beast = 666`
- Multiple assignment: `pi, e = 3.14, 2.71`

### Useful Functions

- `type(...)`: Returns the type of a variable.
- `id(...)`: Returns the memory address of a variable.

### Output and Input

- Output: `print(expr1, expr2, ..., exprN, sep=' ', end='\n')`
- Input: `var = input(prompt)`

The `input` function returns a string.

To keep the numeric value of an input, you need to convert it using the `eval` function or explicitly with `int` or `float`.

### Arithmetic operations
| Operation | Result                                      |
| --------- | ------------------------------------------- |
| x += y    | Add y to x (same as x = x + y)              |
| x -= y    | Subtract y from x (same as x = x - y)       |
| x *= y    | Multiply x by y (same as x = x * y)         |
| x **= y   | Raise x to the power of y (x = x ** y)      |
| x /= y    | Divide x by y (float result, x = x / y)     |
| x //= y   | Integer divide x by y (x = x // y)          |
| x %= y    | Set x to remainder of x divided by y        |

### Comparison Operators

| Operator | Description                | Example      | Result      |
|----------|----------------------------|--------------|-------------|
| `==`     | Equal to                   | `x == y`     | True/False  |
| `!=`     | Not equal to               | `x != y`     | True/False  |
| `>`      | Greater than               | `x > y`      | True/False  |
| `<`      | Less than                  | `x < y`      | True/False  |
| `>=`     | Greater than or equal to   | `x >= y`     | True/False  |
| `<=`     | Less than or equal to      | `x <= y`     | True/False  |

### Logical Operators

| Operator | Description           | Example           | Result      |
|----------|-----------------------|-------------------|-------------|
| `and`    | Logical AND           | `x > 1 and y < 5` | True/False  |
| `or`     | Logical OR            | `x == 0 or y > 2` | True/False  |
| `not`    | Logical NOT           | `not x == y`      | True/False  |

### Truth Table for Logical Operators

| x     | y     | `x and y` | `x or y` | `not x` |
|-------|-------|-----------|----------|---------|
| True  | True  | True      | True     | False   |
| True  | False | False     | True     | False   |
| False | True  | False     | True     | True    |
| False | False | False     | False    | True    |