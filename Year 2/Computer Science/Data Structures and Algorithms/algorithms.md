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
  - [What is data structure?](#what-is-data-structure)
    - [On data Structures](#on-data-structures)
  - [Known Data Structures - Array](#known-data-structures---array)
    - [List](#list)
    - [Record](#record)
    - [Hash Table](#hash-table)
    - [Stack/Queue](#stackqueue)
    - [Tree/Graph](#treegraph)
  - [Data structures in C++ STL](#data-structures-in-c-stl)
  - [Vectors](#vectors)
  - [What is a tree?](#what-is-a-tree)
    - [Properties](#properties)
    - [Balanced trees](#balanced-trees)
    - [Types of tress](#types-of-tress)
  - [Heaps](#heaps)
  - [Decision trees](#decision-trees)
    - [Tree traversal algorithms](#tree-traversal-algorithms)
  - [What is a graph?](#what-is-a-graph)
    - [Types of graphs](#types-of-graphs)
    - [Representation of graphs](#representation-of-graphs)
    - [Spanning trees](#spanning-trees)
      - [Minimum spanning trees](#minimum-spanning-trees)
  - [Shortest Path](#shortest-path)
  - [Depth first search](#depth-first-search)
  - [Breadth First Search](#breadth-first-search)

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
    - To use it, we must include an additional header the `<string>` library

The `<string>` library offers many functionalities.

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

## What is data structure?

- In computer science, a data structure is a data organization and storage format that is usually chosen for efficient access to data.
- More precisely, a data structure is a collection of data values, the relationships among them, and the functions or operations that can be applied to the data.

### On data Structures

Data structures serve as the basis for abstract data types (ADT)

- the ADT defines the logical form of the data type. The data structure implements the physical form of the data type.

Different types of data structures are suited to different kinds of applications, and some are highly specialized to specific tasks.

- For example, relational databases commonly use B-tree indexes for data retrieval, while compiler implementations usually use hash tables to look up identifiers.
- Data structures provide a means to manage large amounts of data efficiently for uses such as large databases and internet indexing services.
- Usually, efficient data structures are key to designing efficient algorithms.
- Data structures can be used to organize the storage and retrieval of information stored in both main memory and secondary memory.

## Known Data Structures - Array

- An array is a number of elements in a specific order, typically all of the same type (depending on the language, individual elements may either all be forcer to be the same type, or may be of almost any type).
- Elements are accessed using an integer index to specify which element is required
- Typical implementations allocate contiguous memory words for the elements of array (but this is not always a necessity).
- Arrays may be fixed-length or resizable.

### List

- A linked list (also just called list) is a linear collection of data elements of any type, called nodes, where each node has itself a value, and points to the next node in the linked list.
- The principal advantage of a linked list over an array is that values can always be efficiently inserted and removed without relocating the rest of the list.
- Certain other operations, such as  random access to a certain element, are however slower on lists than on arrays.

### Record

- A record (also called tuple or struct) is an aggregate data structure. a record is a value that contains other values, typically in fixed number and sequence and typically indexed by names.
- The elements of records are usually called fields or members, In the context of Object Oriented Programming, records are known as plain old data structures to distinguish them from objects.

### Hash Table

- Hash tables, also known as hash maps, are data structures that provide fast retrieval of values based on keys.
- They use a hashing function to map keys to indexes in an array, allowing for constant-time access in the average case.
- Hash tables are commonly used in dictionaries, caches, and database indexing.
- However, hash collisions can occur, which can impact their performance. Techniques like chaining and open addressing are employed to handle collisions.

### Stack/Queue

- Stacks and queues are abstract data types that can be implemented using arrays or linked lists.
- A stack has two primary operations: push (adds an element to the top of the stack) and pop (removes the topmost element from the stack), that follows the Last In, First Out (LIFO) principle.
- Queues have two main operations: enqueue (adds an element to the rear of the queue) and dequeue (removes an element from the front of the queue), this follows the First In, First Out (FIFO) principle

### Tree/Graph

- Trees represent a hierarchical organization of elements. A tree consists of nodes connected by edges, with one node being the root and all other nodes forming sub-tress. Trees are widely used in various algorithms and data storage scenarios.
- Graphs are collections of nodes connected by edges, representing relationships between entities. Graphs can be used to model social networks, computer networks, and transportation networks, among other things.

## Data structures in C++ STL

- the key components of the STL consist of containers, iterators and algorithms and the relationship between them:
  - Containers are data structures that provides a way to store data, like vectors, lists etc..
  - Iterators are object used to access elements of a data structure.
  - Algorithms include functions, like sort() and find(), that perform operations on data structures through iterators.

## Vectors

```c++

#include <iostream>
#include <vector>

int main(){
  std::vector<int> v = {8,4,5,9}

  v.push_back(6);
  v.push_back(9);

  v[2] = -1;

  for (int n : v)
    std::cout << n << ' ';
  std::cout << "/n";
}

```

## What is a tree?

A tree is a special type of graph that is connected and acyclic, meaning it has no cycles or loops. It consists of nodes (vertices) and edges (connection between nodes), where there is exactly one path between any two nodes.

In other words, a tree is a graph where, for any two nodes, you can traverse from one to the other without retracing any edge, and there are no circular path.

### Properties

- Connectivity
  - A tree is connected graph, meaning there is a connexion between two vertices. Unlike general graphs

- Acyclic
  - A tree is acyclic

- Depth
  - The depth of a tree is the length of the longest path from the route to any leaf. The depth of a tree gives insight into its hierarchy and its important

- Height
  - The height of a tree is the number of edges on the longest path from the root of any leaf. The height is a measure of the longest possible chain of nodes.

- Number of edges
  - For a tree with n vertices, there are always n-1...

- Leaf nodes

- Level Of A node
  - is defined by its distance from the root. The root is at level 0, its direct connection is at level 1 and so on.

- Rooted trees
  - A tree can be considered as rooted tree if one vertex is designated as the "root" and all the edges have the direction pointing away from this root.
  - In a rooted tree, the hierarchy is clearly defined, and each vertex has a parent and potentially multiple children.

### Balanced trees

- A tree is said balanced if the height difference between the left and right subtrees of any node is minimal (usually not greater than one).
- Balanced trees are important for performance optimization in search operations.

### Types of tress

- **Binary search tree** is a binary tree in which each node follows the property that all the values in the left subtree are less than the node's value and all the values in the right subtree are greater than the node's value.

## Heaps

- A heap us a specialized tree-based date structure that satisfies the heap property.
- It is a complete binary tree, meaning all levels of the tree are fully filled except possibly for the last level, which is filled from left to right
- The heap us commonly used in algorithms like heap sort and in data structures like priority queue.

- Tree are two main types of heaps
  - Max-heaps: In a max-heap, the key of each parent node is greater than or equal to the keys of its children. This ensures that the maximum key is at the root of the tree
  - Min-heaps: In a min-heap, the key of each parent node is less than or equal to the keys of its children,This ensure that the minimum key is at the root of the tree

## Decision trees

- A decision tree is used in machine learning to represent decisions and their possibles consequences including outcomes, costs and utility.
  - Decision trees are commonly used in classification and regressions tasks.

- It is a tree-like structure where each internal node represents a decision based on a feature, each branch represents an outcome of the decision, and each leaf node represents a class label (in classification) or a continuous value (in regression).

### Tree traversal algorithms

- Pre-order traversal: the root node is visited first, followed by the left subtree and the the right subtree.
- Level-Order traversal: The left subtree is visited first, followed by the root node, and then the right subtree. This is particularly useful in binary search trees as it returns values in sorted order

## What is a graph?

A graph is an abstract data type (adt) which consists of a set of objects that are connected via links. The interconnected objects are represented by points termed as vertices, and the links that connect the vertices are called edges.

Formally, a graph is a pair of sets (V, E), where V is the set of vertices and E is the set of edges, connecting the pairs of vertices.

Adjacency: Two nodes or vertices are adjacent if they are connected to each other through an an endangered language

A path: A path represents

### Types of graphs

- A simple graph is a type of graph where there are no loops (edges that connect a vertex to itself) and no multiple edges between any pair of vertices. In other words, each pair of vertices is connected by at most one edge, and each edge connects two distinct vertices.

- A multigraph is a type of graph in which multiple edges are allowed between the same pair of vertices.
  - Unlike a single graph, there is at most one edge between any two vertices, a multigraph

- A directed graph is a type of graph in which the edges have direction. In other words, each edge in a directed graph points from one vertex to another. This indicates one way relationships.
  - The direction of the edge is often represented with an arrow, showing the flow from the starting point to the ending vertex.

- An undirected, you can go from a to b and b to a.

- A weighted graph is a type of graph where each edge is assigned a weight, usually representing some form of cost, distance or value
  - These weight can be used to represent a variety of metrics, such as travel time, distance between locations or bandwidth in a network.

- Complete graph is a type of graph in which every pair of distinct vertices is connected by a unique edge. In other words, every vertex is directly connected to every other vertex in the graph.

- A bipartite graph is a type of graph in which the vertices can be divided into two distinct sets such that no two vertices within the same set are adjacent.
  - In other words, every edge connects a vertex from one to set to a vertex from the other set, and there are no edges connecting vertices within the same set.

- A complete bipartite graph is a special type of bipartite graph where every vertex in the first set is connected to every vertex from the second set by an unique set.
  - There are no edges within each set

### Representation of graphs

- While representing graphs, we must carefully depict the elements (vertices and edges) present in the graph and the relationship between them.
- Visually, a graph is represented with a finite set of nodes and connecting links between them.
- However, we can also represent graphs using more abstract, but still meaningful ways:

Adjacency matrix

- An adjacency matrix is a square matrix

For a directed graph, a frequency matrix is not necessarily symmetric.

In a weighted graph, the adjacency matrix stores the weight of the edge between vertices.

Unlike the adjacency matrix, which stores a value for every possible edge in the graph, the adjacency list stores only the edges that exist.

An adjacency list is a way of representing a graph where each vertex has a list of other vertices it is directly connected to. This representation is efficient in terms of space, especially for sparse graphs, as it only stores the edges that actually exist in the graph.

The adjacency list consists of an array of lists, where each list contains the neighbor of a particular vertex.

In a directed graph, the list will only contain outgoing edges. In an undirected graph, the list will contain both incoming and outgoing edges.

### Spanning trees

A spanning tree is a subset of an undirected graph that contains all the vertices of the graph connected with the minimum number of edges in the graph.

#### Minimum spanning trees

A minimum spanning tree is a subset of edges of a connected weighted undirected graph that connects all the vertices together with the minimum possible total edge weight.

Common algorithms Kruskal, Prim

## Shortest Path

The shortest path in a graph is defined as the minimum cost group from one vertex to another. This is most commonly seen in weighted directed graphs but it is also applicable to undirected graphs.

A popular real-world application of finding the shortest path in a graph is navigating a topology or map.

Common algorithms: Dijkstra, Bellman-Ford, A*

## Depth first search

DFS is a recursive algorithm for searching all the vertices of a graph or tree data structure. This algorithm traverses a graph in a depth ward motion and uses a stack to remember to get the next vertex to start a search, when a dead end occurs in any iteration.

## Breadth First Search

BFS algorithm traverses a graph in a breadth ward motion. It uses a queue to remember the next vertex to start a search, when a dead end occurs in any iteration.

It starts at a root and explores all nodes at the present depth prior to moving on to the nodes at the next depth level.
