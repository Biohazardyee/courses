# Sorting Algorithms

## Goal of Sorting Algorithms

- Given a numeric list, order the values from smallest to largest (ascending order).
- The list will be passed as a parameter and modified directly by the sorting function.
- No intermediate lists will be used; sorting will be done in place.

In Python, lists are mutable objects, so we can modify them directly within functions.

- Sorting is a classic problem in algorithm theory.
- Many algorithms exist to solve this problem, each with different time and space complexities.
- In this chapter, we will compare the efficiency of several sorting algorithms.

### Recommended Reading

*The Art of Computer Programming, Volume 3: Sorting and Searching* by Donald E. Knuth, which studies around 30 sorting algorithms in detail.

### Types of Algorithms Covered

- Iterative algorithms
- Recursive algorithms based on the divide and conquer paradigm

## Iterative Algorithms

### Selection Sort

Selection sort is mathematically intuitive: it places the smallest element in the first position, then the second smallest in the second position, and so on.

**Description:**

1. Find the smallest value in the list and swap it with the first element.
2. Find the smallest value in the remaining unsorted part of the list and swap it with the second element.
3. Repeat until the entire list is sorted.

### Bubble Sort

Bubble sort repeatedly steps through the list, compares adjacent elements, and swaps them if they are in the wrong order. This process is repeated until no swaps are needed.

**Description:**

1. Traverse the list, comparing each element with the next.
2. If the next element is smaller, swap them.
3. Repeat from the beginning until a complete pass is made without any swaps.

### Insertion Sort

Insertion sort is similar to the way card players sort a hand of cards. Elements are inserted one by one into their correct position in the sorted portion of the list.

**Description:**

1. Consider the first element as a sorted sublist.
2. Insert the second element into the sorted sublist, maintaining order.
3. Continue inserting each subsequent element into its correct position in the sorted sublist.

## Recursive Algorithms

### Merge Sort

Merge sort recursively divides the list into two halves, sorts each half, and then merges the sorted halves.

- It is a divide and conquer algorithm.

**Description:**

1. Divide the list into two sublists of (almost) equal size.
2. Recursively sort each sublist. Stop when a sublist has only one element.
3. Merge the two sorted sublists into a single sorted list.

### Quick Sort

Quick sort recursively partitions the list around a pivot element, placing smaller elements to the left and larger elements to the right.

- Both sublists are then sorted recursively.
- The recursion stops when a sublist contains only one element.

**Description:**

1. Select a pivot (here, the first element) and partition the list so that all elements less than the pivot are on the left, and all greater elements are on the right.
2. Recursively apply this process to the left and right sublists.
3. When all sublists have only one element, the list is sorted. No merging is required.

**Note:**  
The pivot choice affects the algorithm's efficiency. Using the first element is simple but not always optimal; other pivot selection strategies can improve performance.
