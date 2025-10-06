# MongoDB

## SQL vs NoSQL

### SQL Databases

SQL, or Structured Query Language, is a standard programming language designed for managing and manipulating relational databases.

It serves as the foundation for interacting with relational database management systems (RDBMS), such as MySQL, PostgreSQL, SQLite, and Microsoft SQL Server.

SQL provides a standardized way to define, query, update, and manage relational databases.

### Structured Data Model

SQL databases follow a structured, tabular data model where data is organized into tables with predefined schemas.

Each table consists of rows and columns, and relationships between tables are established through keys.

### ACID Properties

SQL databases adhere to ACID (Atomicity, Consistency, Isolation, Durability) properties, ensuring transactions are reliably processed and maintain data integrity.

### Schema

A predefined schema dictates the structure of the database, specifying the data types, relationships, and constraints for each table.

Any changes to the schema often require careful planning and migration processes.

### Scalability Challenges

Traditional SQL databases may face challenges when scaling horizontally due to their rigid structure and complex relationships.

### NoSQL Databases

NoSQL databases represent a diverse category of database management systems that depart from the traditional relational model.

The term "NoSQL" doesn't imply a lack of SQL language support but rather a departure from the structured, tabular nature of SQL databases.

### Flexible Schema

NoSQL databases allow for dynamic and flexible schema design, enabling developers to work with unstructured or semi-structured data.

This flexibility is advantageous in scenarios where data models evolve rapidly.

### Variety of Data Models

NoSQL databases come in various models, including document-oriented (e.g., MongoDB), key-value stores (e.g., Redis), wide-column stores (e.g., Apache Cassandra), and graph databases (e.g., Neo4j).

Each model is optimized for specific use cases.

### Base Properties

NoSQL databases often adhere to the BASE (Basically Available, Soft state, Eventually consistent) model, offering more relaxed consistency guarantees compared to the strict ACID properties of SQL databases.

This approach is suitable for distributed and highly scalable systems.

### Horizontal Scalability

NoSQL databases are generally more conducive to horizontal scalability, allowing them to handle large volumes of data and traffic by distributing data across multiple nodes or servers.

## Conclusion

while SQL and NoSQL databases both serve as valuable tools in the data management landscape, they exhibit distinct characteristics that make them suitable for different types of applications and use cases.

The choice between them depends on factors such as data structure, scalability requirements, and development agility.

One last point that is important to emphasis when thinking about SQL and NoSQL

- SQL: with a focus on reducing data duplication as storage was much more costly than developer time (when it was created)
- NoSQL: Developers (rather than storage) were becoming the primary cost of software development

As storage costs rapidly decreased, the amount of data that applications needed to store and query increased.

This data came in all shapes and sizes — structured, semi-structured, and polymorphic — and defining the schema in advance became nearly impossible.

NoSQL databases allow developers to store huge amounts of unstructured data, giving them a lot of flexibility.

Cloud computing also rose in popularity, and developers began using public clouds to host their applications and data.

They wanted the ability to distribute data across multiple servers and regions to make their applications resilient, to scale out instead of scale up, and to intelligently geo-place their data.

Some NoSQL databases like MongoDB provide these capabilities.

Each NoSQL database has its own unique features. At a high level, many NoSQL databases have the following features:

- Flexible schemas
- Horizontal scaling
- Fast queries due to the data model
- Ease of use for developers

Over time, four major types of NoSQL databases emerged: document databases, key-value databases, wide-column stores, and graph databases.

### Document Databases

- Store data in documents similar to JSON (JavaScript Object Notation) objects
- Each document contains pairs of fields and values
- The values can typically be a variety of types including things like strings, numbers, booleans, arrays, or objects.
- MongoDB & CouchDB

### Key-Value Databases

- Are a simpler type of database
- Where each item contains keys and values.
- Redis & DynamoDB

### Wide-Column Stores

- Store data in tables, rows, and dynamic columns.
- Cassandra & HBase

### Graph Databases

- Store data in nodes and edges
- Nodes typically store information about people, places, and things
- While edges store information about the relationships between the nodes.
- Neo4J & Amazon Neptune

### Key Differences Between SQL and NoSQL

NoSQL databases typically have very flexible schemas.

A flexible schema allows you to easily make changes to your database as requirements change. You can iterate quickly and continuously integrate new application features to provide value to your users faster.

Most SQL databases require you to scale-up vertically (migrate to a larger, more expensive server) when you exceed the capacity requirements of your current server.

Conversely, most NoSQL databases allow you to scale-out horizontally,
meaning you can add cheaper, commodity servers whenever you need to.

### Fast

Queries in NoSQL databases can be faster than SQL databases.

Why? Data in SQL databases is typically normalized, so queries for a single object or entity require you to join data from multiple tables. As your tables grow in size, the joins can become expensive. However, data in NoSQL databases is typically stored in a way that is optimized for queries.

The rule of thumb when you use MongoDB is “data that is accessed together should be stored together”. Queries typically do not require joins, so the queries are very fast.

Some NoSQL databases like MongoDB map their data structures to those of popular programming languages.

This mapping allows developers to store their data in the same way that they use it in their application code. While it may seem like a trivial advantage, this mapping can allow developers to write less code, leading to faster development time and fewer bugs.

Depending on the NoSQL database type you select, you may not be able to achieve all of your use cases in a single database.

For example, graph databases are excellent for analyzing relationships in your data but may not provide what you need for everyday retrieval of the data such as range queries.

## MongoDB Overview

MongoDB is a widely-used NoSQL database management system that provides a flexible and schema-less approach to data storage.

Developed by MongoDB Inc., it falls under the category of document-oriented databases and is designed to handle large volumes of unstructured or semi-structured data.

MongoDB's name is derived from "humongous," emphasizing its capacity to manage massive amounts of data.

MongoDB is a source-available cross-platform document-oriented database program classified as a NoSQL database program uses JSON-like documents developed by MongoDB Inc. licensed under the Server Side Public License (SSPL).

The main features are

- Ad-hoc queries: non predefined queries
- Indexing
- Replication
- Load balancing
- File storage
- Aggregation

But you will also find that MongoDB is capable of

- Server-side JavaScript execution
- Capped collections
- Transactions
- ACID support

## Express.js and MongoDB

There is two main solution to easily use MongoDB in an Express.js
application

- use the mongo driver
- use the ODM mongoose

In this course we will mainly focus on the usage of mongoose

To install on or the other package you can do in your terminal

```bash
npm install --save mongodb
npm install --save mongoose
```

Select the one you want to use (here we will choose mongoose)

First of all you need to connect your application to the database to then be able to execute some queries

Once the connection is established now you will need to create a schema.

A schema is the solution used by the ODM mongoose to know how to handle the schema of your database but it will also be used to define validation rules or database schema (and update it if necessary)

In another file create a basic schema and export it to be able to use it in
another file

```javascript
const mongoose = require("mongoose");
const UserSchema = new mongoose.Schema({
    id: Number,
    email: String,
    isAdmin {
        type: Boolean,
        default: false
    }
});
module.exports = mongoose.model("User", UserSchema);
```

With that, most of the requests become really simple to execute and as a developer we don't need to work with another language.

Let's see how we can build a basic CRUD

For all examples below we will base a default connection to the database. 
For the mongoose use case we will use the previous schema. 
For a pure mongodb usage we will have to define our collection
