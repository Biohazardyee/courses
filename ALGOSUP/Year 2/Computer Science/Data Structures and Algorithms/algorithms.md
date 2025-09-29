# Data Structures and Algorithms

- [Data Structures and Algorithms](#data-structures-and-algorithms)
  - [what is this about](#what-is-this-about)
  - [Structure of the course](#structure-of-the-course)
  - [Brief C++ history](#brief-c-history)
  - [Namespaces in C++](#namespaces-in-c)
  - [Essential Data Types](#essential-data-types)
  - [Strings in C++](#strings-in-c)
  - [References and pointers in C++](#references-and-pointers-in-c)
    - [Dynamic Memory in C++](#dynamic-memory-in-c)
      - [Pros](#pros)
      - [Common pitfalls](#common-pitfalls)
  - [Introduction to Version Control](#introduction-to-version-control)
    - [Benefits of version control](#benefits-of-version-control)
    - [Basic Git Commands](#basic-git-commands)
  - [Fundamentals of REST APIs](#fundamentals-of-rest-apis)
    - [6 guiding principles for REST](#6-guiding-principles-for-rest)
    - [How REST APUs work](#how-rest-apus-work)
    - [Main elements of RESTful API](#main-elements-of-restful-api)
    - [How to access a resource](#how-to-access-a-resource)
  - [What is an algorithm?](#what-is-an-algorithm)
    - [Properties of algorithms](#properties-of-algorithms)
  - [Non-algorithm](#non-algorithm)
  - [Search Algorithms](#search-algorithms)
  - [Sorting algorithms](#sorting-algorithms)
  - [Bubble sort](#bubble-sort)
    - [Asymptotic Notations](#asymptotic-notations)
    - [Big-O notation](#big-o-notation)
  - [Divide-and-conquer algorithms](#divide-and-conquer-algorithms)
  - [Insertion sort algorithm](#insertion-sort-algorithm)
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
  - [Dijkstra Algorithm](#dijkstra-algorithm)
  - [A\* algorithm](#a-algorithm)

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

## Brief C++ history

In 1979, Bjarne Stroustrup, a Danish computer scientist began work on C with classes, the predecessor to C++, as part of his PhD thesis.

Initially, Stroupstrup's C with class added features to the C compiler Cpre, including classes, derived classes, strong typing , inlining and default arguments.

In 19823, Stroustrup started to develop a successor to C with classes, which he named C++.

## Namespaces in C++

A namespace is a declarative region that provides a scope to the identifiers inside it.

Namespaces are used to organize code into local groups and to prevent name collisions that can occur especially when your code base includes multiple libraries.

## Essential Data Types

The void type describes an empty set of values.
    - No variable of type void can be specified.
    - The void type is used primarily to declare functions that return no values or to declare generic pointers to untyped or arbitrarily typed date.

The boolean type can have values true or false.
    - The size of the bool type is implementation-specific

The char type is a character representation type that efficiently encodes members of the basic execution character set.
    - The C++ compiler treats variables of type char, signed char and unsigned char as having different types.

Floating-point types provide an approximation of fractional values over a wide range of magnitudes.

The int type is the default basic integer type. It can represent all of the whole numbers over an implementation-specific range.

A signed integer representation is one that can hold both positive and negative values.
    - It's used by default or when the signed modifier keyword is present.

The unsigned modifier keyword specifies an unsigned representation that can only hold non-negative values.

A size modifier specifies the width in bits of the integer representation used.

The language supports short, long, and long long modifiers.

A short type must be at least 16bits wide. A long type must be at least 32 bits wide. A long long type must be at least 64bits wide.

## Strings in C++

Same as in C
    - characters array with a twist

Dedicated data type: string
    - To use it, we must include an additional header the `<string>` library

The `<string>` library offers many functionalities.

## References and pointers in C++

As in C, we can store memory addresses in variables

Pointers and pointer operations are more powerful in C++
    - Fundamental in OOP

### Dynamic Memory in C++

C had malloc()
C++ has operators **new** and **delete**

new is followed by a data type specifier and if a sequence of more than one element is required, the number of these within brackets []. It returns a pointer to the beginning of the new block of memory allocated.

pointer = new type
pointer = new type [number_of_elements]

In most cases, memory allocated dynamically is only needed during specific periods of time within a program; once it is no longed needed, it can be freed so that the memory becomes available again for other requests of dynamic memory. this is the purpose of operator delete.

deleter pointer;
delete[] pointer;

#### Pros

- Flexibility: Dynamic memory allocation allows us to allocate memory as needed during runtime.
- Data structure: data structures such as linked lists, trees, graphs and resizable arrays (vectors in C++) often need to allocate memory dynamically to accommodate varying amount of data.
- Resource management: We can allocate memory when needed and deallocate it when it's no longer required.
- Dynamic arrays: Dynamic memory allocation allows us to create arrays whose size can be determined during runtime.

#### Common pitfalls

- Memory leaks
- Dangling pointers

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
    - Distributed file systems send and receive data via REST.
    - Web services using REST are called RESTful APIs or REST APIs.

Web services using REST are called RESTful APIs or REST APIs.

### 6 guiding principles for REST

- Uniform interface
  - All API requests for the same resource should look the same, no matter where the request comes from.
  - The REST API should ensure that the same piece of data, such as the name or email address of a user, belongs to only one uniform resource identifier (URI).
  - Resources shouldn't be too large but should contain every piece of information that the client might need.

- Client-server decoupling:
  - In REST API design, client and server applications must be completely independent of each other.
  - The only information that the client application should know is the URI of the requested resource; it can't interact with the server application in any other ways.
  - Similarly, a server application shouldn't modify the client application other than passing it to the requested data via HTTP

- Statelessness
  - REST APIs are stateless, meaning that each request needs to include all the information necessary for processing it.
  - In other words, REST APIs do not require any server-side sessions.
  - Server applications aren't allowed to store any data related to a client request.

- Cacheability
  - When possible, resources should be cacheable on the client or server side. Server response also need to contain information about whether caching is allowed for the delivered resource.
  - The goal is to improve performance on the client side, while increasing scalability on the server side.

- Layered system architecture
  - In REST APIs, the calls and responses go through different layers. As a rule of thumb, don;t assume that the client and the server applications connect to each other.
  - There may be a number of different intermediaries in the communication loop. REST APIs need to be designed so that neither the client nor the server can tell whether it communicates with the end application or an intermediary.

- Code on demand (optional)
  - REST APIs usually send static resources, but in certain cases, responses can also contain executable code (such as Java applets). In these cases, the code should only run on-demand.

### How REST APUs work

- REST APIs communicate through HTTP requests to perform database functions like creating, reading, updating and deleting records (CRUD) within a resource.
- For example, a REST API would use a GET request to retrieve a record. A POS request creates a new record. A PUT request updates a record, and a DELETE request deletes one.

- The state of a resource at any particular instant or timestamp is known as the resource representation.

- This information can be delivered to a client in virtually any format including Javascript Object Notation (JSON), HTML, WLT, Python, PHP or plain text. Json is popular because it's readable by both humans and machines and it is programming language-agnostic.

- Request headers and parameters are also important in REST API calls because they include important identifier information such as:
  - Metadata, authorizations, uniform resource identifiers (URI), caching, cookies and more.

- Request headers and response headers, along with conventional HTTP status codes, are used within well-designed REST APIs.

### Main elements of RESTful API

- Client. The client is the software code or application that requests a resource from a server.
- Server, is the software code or application that controls the resource and responds to client requests for the resource.
- Resource, is any data or content, such as text, video and images, the server controls and makes available in response to client requests.

### How to access a resource

- HTTP method. This details what should happen to the specified resource. The four fundamental HTTP methods are know as verbs.
- Endpoint. The endpoint shows where the resource is located. It typically includes a URI.
- Header, has the details needed to execute the call and handle the response. A request header might include authentication data, an encryption key, etc.
- Body, the body contains relevant information to or from the server. for example, a body may contain the new data to be added to the server through a POST or PUT method.

## What is an algorithm?

Definition. An algorithm is a finite set of rules specifying sequences of computational steps for solving a given problem.

### Properties of algorithms

- Finiteness. An algorithm must always terminate after a finite number of steps.
- Definiteness. Each step of an algorithm must be precisely defined, that is, the actions to be carried out must be rigorously and unambiguously specified.
- Input. An algorithm has zero or more inputs, given before the algorithm begins or during the algorithms execution.
- Output. An algorithm has one or more outputs, which relate to the inputs.
- Effectiveness. Every operation of an algorithm must be sufficiently rudimentary, such that in principle, the operation can be done by a human using paper and pencil, in finite time.

Algorithm represent essential ideas of programs. They are sufficiently detailed to ensure that they are step-by-step procedures but ignore many syntactic and semantic details of any particular programming language.

In the design and analysis of algorithms, people often use pseudocode.

## Non-algorithm

Consider the problem of finding a common divisor of two positive integers x and y.

Algorithm 1: Randomly Pick and Check
Input: Two positive integers x and y.
Output: A positive integer z such that x % z = 0 and y % z = 0.
Steps:
while true
 randomly pick a positive integer z
 if (x % z == 0) and (y % z == 0) then halt

Algorithm 1 is not an algorithm!

It may never stop, violating the finiteness property.

The step “randomly picking a positive integer” is not sufficiently rigorous or unambiguous.
Out of the set of infinitely many positive integers, what is the meaning of “randomly picking”? It violates the definiteness property.

Consider the problem of finding a common divisor of two positive integers x and y.

Algorithm 2: Euclid’s Algorithm
Input: Two positive integers x and y.
Output: A positive integer z such that x % z = 0 and y % z = 0.
Steps:
while y != 0
 x = y
 y = x % y
 z = x

Algorithm 2 is indeed an algorithm. In fact, it does more than finding a common divisor, but finding the greatest common divisor of x and y.

It can also be implemented as a recursive algorithm!

## Search Algorithms

- Let's implement:
  - Brute force (linear) search
    - Search for a random number in an array, by checking every position in the array.
  - Binary search
    - "Decrease and conquer" algorithm, working on sorted arrays, by iteratively/recursively breaking them down in halves.

which one is faster?
What does faster mean?

## Sorting algorithms

The sorting problem us a classic problem in computer science. The purpose of sorting is to adjust a sequence of "out-of-order" numbers into an ordered sequence of numbers.

- bubble sort,
- insertion sort,
- quick sort,
- heap sort
- merge sort...

## Bubble sort

- the name bubble sort comes from the fact that large numbers will gradually bubble up to the top.
- In each round, compare every adjacent pair of numbers from left to right, and exchange the two numbers of a pair if the larger one is on the left side.
- After one round, the largest number will be moved to the rightmost position. We then go to the next round and compare and exchange every pair of numbers from left to right again

Input: An array A of length n to be sorted.
Output: A sorted array A.
Steps:
for i = 1 to n-1 // for each round
 for j = 1 to n-i // compare every adjacent pair
  if A[j] > A[j + 1] then exchange A [j] with A [j + 1];

### Asymptotic Notations

- It is always important to know whether an algorithm is efficient or not.
- Given a problem or an algorithm, how such resource (such as execution time or storage space) is theoretically required?

- In the bubble sort algorithm, for n positive integers, the algorithm requires n(n-1)/2 comparisons and at most n(n-1)/2 exchange steps.
- Usually we do not need to know the exact number or quantity of resource required.
- We can say the bubble sort algorithm requires roughly n^2 steps, or more professionally, we say the time complexity of bubble sort algorithm is O(n^2).

### Big-O notation

The big-O notation denotes an upper bound of the complexity

The small-o notation denotes a strict upper bound of the complexity

The Ω notation denotes a lower bound of the complexity

The Θ notation denotes an estimate of same order of the actual complexity.

![1737223316858](image/algorithms/1737223316858.png)

## Divide-and-conquer algorithms

- Divide and conquer is an algorithm design paradigm based on the idea hat we recursively break down a problem into two or more subproblems of the similar type, until these subproblems become simple enough to be solved directly.
- Many examples:
  - Binary search
  - Insertion sort
  - Merger sort
  - ...

## Insertion sort algorithm

- One natural idea is to firstly sort the first n - 1 integers and then insert the n-th integer into the proper position of a sorted sequence.
- How can we sort the first n - 1 integers? well, this is a subproblem with smaller size. This leads to the idea of the insertion sort algorithm.
- I n each round, the first i integers of the sequence are already in order. Our task is to insert the (i + 1)th integer into the proper position

Input: An array A of length n to be sorted.
Output: A sorted array A.
Steps:
for i = 1 to n-1
 j = i + 1;
 while (j > 1) and (A[j-1] > A[j])
  exchange A[j] with A [j - 1];
  j = j - 1;

The insertion sort algorithm is not a typical example of divide-and-conquer method.
But it illustrates the idea of subproblem.

## Merge sort algorithm

- In the insertion sort algorithm, we divide the original problem into two unequal subproblems, where one subproblem contains n - 1 integers and the other subproblem contains only one integer.

- In another sorting algorithm, called the merge sort algorithm, we divide the original problem into two subproblems, which deal with almost equal number of integers.

The sorting problem of MergeSort([A[1],...,A[n]]) is first divided into two subproblems: MergeSort([A[1],...,A[n/2]]) and MergeSort([A[n/2+1],...,A[n]]).

Then we merge the results B and C of the two sub-problems, which are each a sorted sequence of integers.

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

## Dijkstra Algorithm

- Dijkstra's algorithm is an algorithm for finding the shortest path between nodes in a weighted graph, which may represent, for example, a road network.

- It was conceived by computer scientist Edsger Dijkstra in 1956 and published in 1959.

## A* algorithm

- Can be seen as an extension of Dijkstra's algorithm. A* achieves better performance by using heuristics to guide its search.
- Peter Hart, Nils Nilsson and Bertram Raphael of Stanford Research Institute (now SRI International) first published the algorithm in 1968.
