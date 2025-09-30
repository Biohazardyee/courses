# Recursion and Paradigms: Divide and Conquer

## Recursion

A subroutine (procedure or function) is **recursive** if it calls itself, either directly or indirectly.

To solve a problem recursively, we reduce it to a similar problem with lower complexity, until we reach a base case that can be solved directly.

A recursive subroutine typically calls itself with simpler parameters. Each call further reduces the problem, stacking calls in memory until a base case is reached. Once the base case is solved, the results are combined as the calls return, ultimately solving the original problem.

- The intermediate problems between the initial problem and the base case are called **subproblems**. These are managed in a memory structure called the **call stack**.
- As we return from the base case, we combine the results of the subproblems to obtain the final result.

**Example: Factorial of a number**

Recall:  
n! = n × (n-1) × (n-2) × ... × 3 × 2 × 1

Recursive definition:  
n! = n × (n-1)!

```python
def factorial(n):
    if n == 0 or n == 1:
        return 1
    else:
        return n * factorial(n - 1)
```

Example for n = 4:

```
factorial(4) = 4 × factorial(3)
             = 4 × (3 × factorial(2))
             = 4 × (3 × (2 × factorial(1)))
             = 4 × (3 × (2 × 1))
             = 24
```

Each call is stacked in memory until the base case (n = 1 or n = 0) is reached, then the calls are resolved in reverse order.

**Important:** Always define a stop condition (base case) to avoid infinite recursion.

**Incorrect example (no base case):**

```python
def factorialBad(n):
    return n * factorialBad(n - 1)
```

### Recursion vs Iteration

- An **iterative** subroutine does not call itself.
- Any recursive algorithm can be rewritten iteratively, and vice versa.
- Iterative algorithms are often faster and use less memory, but can be more complex to write.

**Example: Iterative factorial**

```python
def factorialIter(n):
    result = 1
    for i in range(2, n + 1):
        result *= i
    return result
```

### Why use recursion?

- Recursion can make code more elegant and readable, especially when dealing with complex data structures (trees, graphs, etc.).
- Some problems are naturally recursive and are easier to express this way.

### Downsides of recursion

- Recursive solutions can be memory-intensive.
- Deep recursion can cause stack overflow errors.
- For example, calculating 1000! recursively may cause a stack overflow due to too many nested calls.

### Mutual (Cross) Recursion

Functions that call each other recursively.

**Example: Even and Odd functions**

```python
def even(n):
    if n == 0:
        return True
    else:
        return odd(n - 1)

def odd(n):
    if n == 0:
        return False
    else:
        return even(n - 1)
```

This can be done more simply with a modulo operation, but serves as an example of mutual recursion.

### Multiple Recursion

A subroutine calls itself multiple times within its definition.

**Example: Binomial coefficients**

```python
def coeffs(n, k):
    if k == 0 or k == n:
        return 1
    else:
        return coeffs(n - 1, k - 1) + coeffs(n - 1, k)
```

### Nested Recursion

A recursive call is made with another recursive call as its argument.

**Example: McCarthy 91 function**

```python
def mcCarthy(n):
    if n > 100:
        return n - 10
    else:
        return mcCarthy(mcCarthy(n + 11))
```

## Paradigms: Divide and Conquer

- The previous algorithms used simple recursive definitions.
- More complex problems can be solved using recursive approaches that divide the problem into smaller subproblems, solve them recursively, and combine their results.

### The 3 Steps of Divide and Conquer

1. **Divide:** Split the initial data into smaller parts (subproblems).
2. **Conquer:** Solve each subproblem recursively (or directly if small enough).
3. **Combine:** Merge the results to obtain the final solution.

**Example: Find the maximum in a list**

- Recursively find the maximum in the first half and the second half, then compare them.
- The stopping condition is when the list contains only one element.

**Solution:**

1. Divide the list into two sublists of (almost) equal size.
2. Recursively find the maximum of each sublist. Stop when the sublist has only one element.
3. Return the larger of the two maximums.

```python
def maxRecursive(l, d, f):
    if d == f:
        return l[d]
    m = (d + f) // 2
    x = maxRecursive(l, d, m)
    y = maxRecursive(l, m + 1, f)
    return x if x > y else y

def maximum(l):
    return maxRecursive(l, 0, len(l) - 1)
```

- `l`: list of numbers
- `d`: start index
- `f`: end index
- Returns the maximum of `l[d]...l[f]`

**Example: Search for an element in a list**

- Recursively search for the element in both halves of the list, combining the results with OR.
- The stopping condition is when the list contains only one element.

**Solution:**

1. Divide the list in half.
2. Recursively search for the element in each half. Stop when the sublist has only one element.
3. Combine the results with OR.

```python
def search(l, d, f, x):
    if d == f:
        return l[d] == x
    m = (d + f) // 2
    return search(l, d, m, x) or search(l, m + 1, f, x)

def contains(l, x):
    return search(l, 0, len(l) - 1, x)
```

**Example: Search for an element in a sorted list**

- Use binary search: compare the middle element to the target, then recursively search only the relevant half.
- This approach is more efficient due to the sorted nature of the list.

