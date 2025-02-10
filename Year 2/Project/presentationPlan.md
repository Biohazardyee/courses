# **Shortest Path Project Final Presentation**

---

## **1. Introduction**

- **Overview of LORAN (Long Range Navigation)**
  - Historical context and purpose
  - Limitations and challenges

- **Modern Alternatives**
  - GPS and other navigation systems
  - Why shortest path algorithms are still relevant

- **Our Project**
  - Objective: Developing an efficient shortest path solution
  - Applications: Real-world use cases (e.g., logistics, transportation, gaming)

---

## **2. Algorithm Overview**

- **Dijkstra's Algorithm**
  - Basics of Dijkstra's approach
  - Comparison with A* (pros and cons)

- **A* Algorithm**
  - Explanation of A* and its advantages
  - Role of **heuristics** in optimizing path-finding
  - Example: How heuristics improve efficiency

- **Bi-directional Search**
  - Concept and benefits
  - How it reduces search space and improves performance

- **Pre-processing Techniques**
  - Importance of pre-processing for scalability
  - Examples: Graph simplification, landmark-based optimizations

---

## **3. Client-Server Architecture**

- **Server-Side**
  - Role of the server in handling computations
  - Data storage and processing

- **Client-Side**
  - User interface and interaction
  - Sending requests and receiving results

- **Client-Server Interaction**
  - Communication flow (e.g., REST API, WebSocket)
  - Example: How a client request is processed and returned

---

## **4. Prototype**

- **Overview of the Prototype**
  - Key features and functionalities

- **Computation Time**
  - Time needed for the algorithm to compute

- **Future Improvements**
  - Detail the improvements needed to comply with requirements

---

## **5. Live Demo**

- **Step-by-Step Demonstration**
  - Showcasing the shortest path algorithm in action

- **Real-Time Interaction**
  - Highlighting user input and system response

- **Performance Metrics**
  - Speed, accuracy, and scalability

---

## **6. Conclusion**

- **Big-O Notation Analysis**
  - Time and space complexity of the algorithms used
  - Comparison of efficiency between A*, Dijkstra, and bi-directional search

- **Key Takeaways**
  - What we achieved and learned

- **Future Improvements**
  - Potential enhancements (e.g., parallel processing, machine learning integration)

- **Outro**
  - Thank you! Open the floor for questions and feedback

---

### **Client-Server Architecture and Communication**

"Let me walk you through how our client-server architecture works.

First, we have the **server**, which is hosted locally. This server is essentially the brain of our system. It stores the dataset CSV file, which can be accessed using Hypertext Transfer Protocol.

Now, what does the server do? Well, it’s responsible for all the heavy lifting. It hosts the shortest path algorithm. It also handles all the pre-processing. Most importantly, this is where the actual computation happens. When you ask for the shortest path, the server is the one that calculates it.

---

On the other hand, we have the **client**. The client is the interface with which you interact with the algorithm where you input your starting point—let’s call it Point A—and your destination, Point B. The client then sends this information to the server for processing. Once the server computes the result, it sends the output back to the client. This output includes three key pieces of information:

1. The sequence of nodes that make up the shortest path.
2. The total travel time from Point A to Point B.
3. And the computation time—how long it took the algorithm to find the solution.

Now, how do the client and server talk to each other? They communicate using a **REST API**. Specifically, we use a single **GET method** for this communication. The client sends a GET request to the server, which includes the input parameters: Point A, Point B, and a header that specifies whether the response should be in **JSON** or **XML** format. This flexibility in response format allows us to support a wider range of use cases and makes the system more versatile.

but this in the slides

<!-- Here’s how the workflow looks in practice:

1. The user inputs Point A and Point B into the client.
2. The client sends a GET request to the server with these details and the preferred response format.
3. The server retrieves the dataset, runs the algorithm, and computes the shortest path, travel time, and computation time.
4. The server then sends this information back to the client in the requested format—either JSON or XML.
5. Finally, the client displays the results to the user in a clear and user-friendly way. -->

---

Such an architecture allows an efficient scalable and flexible software that can be used in a professional environment.

How was it looking like on the prototype? lets find out.

<!-- ### **Why This Architecture Works So Well**

"This setup has several advantages:

it is efficient, scalable, flexible

- **Efficiency**: By handling all the computation on the server, the client stays lightweight and responsive.
- **Scalability**: The server can handle multiple client requests at once, making it suitable for larger applications.
- **Flexibility**: Supporting both JSON and XML responses ensures our system can integrate with a variety of other tools and platforms.
- **Separation of Concerns**: By clearly dividing responsibilities—client for user interaction and server for computation—we make the system easier to maintain and update.

--- -->
