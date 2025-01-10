# Data Structures and Algorithms

- [Data Structures and Algorithms](#data-structures-and-algorithms)
  - [what is this about](#what-is-this-about)
  - [Structure of the course](#structure-of-the-course)
  - [Essential Data Types](#essential-data-types)
  - [Strings in C++](#strings-in-c)
  - [Introduction to Version Control](#introduction-to-version-control)
    - [Benefits of version control](#benefits-of-version-control)
    - [Basic Git Commands](#basic-git-commands)
  - [Fundamentals of REST APIs](#fundamentals-of-rest-apis)
  - [Non-algorithm](#non-algorithm)
  - [Search Algorithms](#search-algorithms)
  - [Sorting algorithms](#sorting-algorithms)
    - [Bubble sort](#bubble-sort)
  - [Merge sort algorithm](#merge-sort-algorithm)

## what is this about

- Learn the fundamentals of data structures and algorithms
- Theory and hands-on practice
- Understanding the essence of CS
- Focusing on clean, professional and efficient code
- Using C++ as our learning and coding tool

## Structure of the course

- Brief introduction to C++ and Git/GitHub
- REST APIs
- Algorithmic thinking, BIg O notation
- stacks, Queues and Lists
- Data structures in C++ STL
- Trees, Theory and algorithms
- Graphs , Theory and Algorithms
- C++ Optimization Techniques

Simple Hello World program

```c++
#include <stdio.h>

int main() {
    printf("Hello, World!\n");
    return 0;
}
```

## Essential Data Types

The void type describes an empty set of values.
    - No variable of type void can be specified.
    - The void type is used primarily to declare functions that return no values or to declare generic pointers to untyped or arbitrarily typed date.

The boolean type can have values true or false.
    - The size of the bool type is implementation-specific

The int type is the default basic integer type. It can represent all of the whole numbers over an implementation-specific range.

A signed integer representation is one that can hold both positive and negative values.

A size modifier specifies the width in bits of the integer representation used.

The language supports short, long, and long long modifiers.

A short type must be at least 16bits wide. A long type must be at least 32 bits wide. A long long type must be at least 64bits wide.

## Strings in C++

Same as in C
    - characters array with a twist

Dedicated data type: string
    - To use it, we must include an additional header the <string> library

The <string> library offers many functionalities.

## Introduction to Version Control

Version control, also know as source control, is the practice of tracking and managing chances to software code.

Version control systems are software tools that help software teams manage changes to source code over time.

As development environment have accelerated, version control systems help software teams work faster and smarter.

It keeps track of all modifications to the code in a special kind of database.

If a mistake is made, developers can turn back the clock and compare earlier versions of the code to help fix the mistake while minimizing disruption to all team members.

### Benefits of version control

1. A complete long-term change history of every file
2. Branching and merging
3. Traceability in project management

### Basic Git Commands

- Git is a version control system
- Git is not equal to GitHub
- git add, git status, git commit, git push, git pull, git branch, git checkout, etc...

## Fundamentals of REST APIs

A REST API is an application programming interface (API) that conforms to the design principles of the representation state transfer (REST) architectural style.

REST APIs provide a flexible, lightweight way to integrate applications and to connect components in micro-services architectures.

REST is a software architectural style for distributed hypermedia systems, used in the development of web services.

Distributed file systems send and receive data via REST.

Web services using REST are called RESTful APIs or REST APIs.

## Non-algorithm 

It may never stop, violating the finiteness property. 

The step randomly picking a positive integer is not sufficiently rigorous or unambiguous.
    - Out of the set of infinitely many positive integers, what is the meaning of 'randomly picking'? It violates the definiteness property.

Algorithm 2: Euclid's algorithm

## Search Algorithms

- Let's implement:
  - Brute force (linear) search
  - Binary search

which one is faster?
What does faster mean?

## Sorting algorithms

The sorting problem us a classic problem in computer science. The purpose of sorting is to adjust a sequence of "out-of-order" numbers into an ordered sequence of numbers.

- bubble sort,
- insertion sort,
- quick sort,
- heap sort
- merge sort...

### Bubble sort

- the name bubble sort comes from the fact that large numbers will gradually bubble up to the top. 

- In each round, compare every adjacent pair of numbers from left to right, and exchange the two numbers of a pair if the larger one is on the left side.

## Merge sort algorithm

- In the insertion sort algorithm, we divide the original problems into two unequal sub-problems, where one subproblem contains n - 1 integers and the other subproblem contains only one integer. 
- In another sorting algorithm, called the merge sort algorithm, we divide the original problem into two sub-problems, which deal with almost equal number of integers.

