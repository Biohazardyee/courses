# Express.js

Express.js, commonly known as Express, stands out as a minimal and flexible web application framework for Node.js.

It simplifies the process of building robust and scalable web applications by providing a set of essential features and tools.

Designed to work seamlessly with Node.js, Express enhances the server-side development experience, allowing developers to focus on creating dynamic and feature-rich applications.

Express.js is widely adopted for various web development projects, ranging from small-scale applications to large-scale enterprise solutions.

Its popularity stems from its lightweight nature, flexibility, and the ease with which developers can scaffold and build RESTful APIs and web applications.

Based on top of Express.js, multiple stack were created to encompass the size of large project, using an acronym to refer to a group of tools

- Mongo
- Express.js
- React or Angular
- Node.js

This terms are less used today, but were standards between 2014 to 2019.

The MERN stack, a powerful full-stack JavaScript framework, encompasses MongoDB, Express.js, React, and Node.js.

MongoDB serves as the NoSQL database, allowing for flexible and scalable data storage.

Express.js, a minimalist web application framework for Node.js, streamlines server-side development with efficient routing and middleware management.

React, a declarative JavaScript library, facilitates the creation of dynamic and interactive user interfaces.

Node.js, as the JavaScript runtime, enables the execution of server-side code.

Together, the MERN stack provides a cohesive and end-to-end JavaScript solution for developing modern and feature-rich web applications.

The MEAN stack shares the philosophy of full-stack JavaScript development and consists of MongoDB, Express.js, Angular, and Node.js.

MongoDB serves as the NoSQL database, offering flexibility in handling unstructured data.

Express.js, the web application framework for Node.js, provides a solid foundation for server-side development.

Angular, a TypeScript-based front-end framework, simplifies the creation of dynamic single-page applications with a modular structure.

Node.js, as the runtime for server-side JavaScript, ensures a unified language across the entire stack.

The MEAN stack exemplifies the efficiency and integration of JavaScript throughout the development process, catering to various project requirements and developer preferences.

Even with less update today, Express stays strong and is still the Node.js framework the most downloaded.

To be precise he got more download weekly than all other backend framework combined and added to React or the same number of download as the combined values for Angular, React and Vue.js.

The strength is based on key features of Express.js

### Routing

Express simplifies URL routing, allowing developers to define routes for handling different HTTP methods and requests.

This streamlined routing mechanism enhances the organization and structure of the application.

### Middleware Support

Middleware functions in Express play a crucial role in processing requests.

Developers can use existing middleware or create custom middleware to execute specific tasks, such as authentication, logging, or data parsing, before reaching the route handler.

### Templating Engines

Express supports various templating engines, including EJS and Pug (formerly Jade), allowing developers to dynamically generate HTML on the server side.

This flexibility aids in rendering dynamic content and building views.

### HTTP Utility Methods

Express provides utility methods for simplifying common HTTP tasks.

These methods facilitate handling requests, responses, and parameters, streamlining the development process.

### Middleware ecosystem

Express boasts a rich ecosystem of middleware modules available via npm.

This allows developers to easily integrate additional functionality into their applications, ranging from authentication middleware to logging and compression.

### Static File Serving

Express simplifies the serving of static files, such as images, stylesheets, and client-side JavaScript.

This is achieved through the express.static middleware, making it convenient to include assets in web applications.

### Error Handling

Express provides robust error-handling mechanisms, making it easier for developers to manage and respond to errors in a consistent manner.

Custom error-handling middleware can be implemented to address specific application needs.

Express.js is widely adopted for various web development projects, ranging from small-scale applications to large-scale enterprise solutions.

Its popularity stems from its lightweight nature, flexibility, and the ease with which developers can scaffold and build RESTful APIs and web applications.

### Installation

```bash
npm install express --save
```

In a second step you have to require / import the express framework and initialize the application with it

```javascript
const express = require("express");
const app = express();
```

The previous lines represent the express application

- Just your HttpServer...
- Enriched with express properties & functions!

The next line represent the definition of a route of our application. This is the router of an express application, we will see that in more details a bit later.

What is important here is that we create and listen an endpoint on the url “/” with the method get

```javascript
app.get("/", (req, res) => {
  res.send("Hello World!");
});
```

Finally the last line is here to setup our application to listen on the port 3000.

Without that your application won't be reachable !

```javascript
app.listen(3000, () => {
  console.log("Example app listening on port 3000!");
});
```

We will be building API during this class. Most of them offers to return only data with a json format.

Express allow you to return a valid JSON object with the method json() in place of the send(). Try to change it and check what is changing when you query the endpoint.

## Routing 

Express catches requests depending on:

- HTTP Verbs
- URLs

And use a callback to process logic

With Express, you just have to write your endpoint and you are good to go !

```javascript
app.get("/", (req, res) => {
  res.send("Hello World!");
});
app.get("/about", (req, res) => {
  res.send("About page");
});
app.post("/about", (req, res) => {
  res.send("About page with POST method");
});
```

Of course, all verbs are handled

- from the standard GET / POST
- to the least used like PUT / PATCH
- or even the OPTION

You can use this solution to catch all incoming request. Also another custom verb is used in Express “all”.

The all verb is used by Express to signal to the router that you want to
process all requests independently from the verb used. This is useful as a catch-all solution.

Catch all requests verbs on a pattern
```javascript
app.all('*', (req, res) => {
  res.send("All requests");
});
```

Question: what will be the output when going to /url ?

```javascript
var express = require('express');
var app = express();
app.all('*', (req, res) => {
  res.send("app.all match");
});
app.get('/url', (req, res) => {
  res.send("app.get match");
});
app.listen(3000);
```
It won’t send anything to the client!

- Only write “app.all match!” in the server console
- First route (app.all) matched the request
- Therefore other are ignored!

So how do you pass a request on to the next routes?

The third parameter in the callback is called "next"
```javascript
app.all('*', (req, res, next) => {
  console.log("app.all match");
  next(); // Pass to the next matching route
});
```

As you can see routing in Express is really easy. Two things you have to
remember.

The first parameter in the callback (request) contains all information linked to the request, including

- the query params
- the body
- the params

For example if you want to access the query param of a request you can do it by accessing the value of the key inside the query parsed in the request.

If you call your API with “localhost:3000/url?id=1”

```javascript
app.get('/url', (req, res) => {
  console.log(req.query.id); // Will output 1
  res.send("app.get match");
});
```

To access the content of the body you will need a package. Multiples exists but the principal used is body-parser

```javascript
const bodyParser = require('body-parser');
app.use(bodyParser.urlencoded({ extended: false }));
app.use(bodyParser.json());

app.post('/url', (req, res) => {
  console.log(req.body); // Will output the body content
  res.send("app.post match");
});
```

The content of the body will be the whole object send in the request

For more information on body-parser you can check the documentation on the Express.js website

You should be able to find recipes, guides and other documentation for your usage of Express, but also the main middlewares (or packages).

Finally if you want to handle params in the url you will need to use the “:” character.

```javascript
app.get('/url/:id', (req, res) => {
  console.log(req.params.id); // Will output the id param in the url
  res.send("app.get match");
});
```

## Middleware

Middleware in Express.js is a crucial concept that plays a pivotal role in enhancing the request-response lifecycle within a web application. 

Middleware functions are essentially functions that have access to the request object (req), the response object (res), and the next middleware function in the application's request-response cycle (next). 

These functions have the ability to perform tasks, modify the request and response objects, end the request-response cycle, and call the next middleware in the stack.

Express.js middleware functions are invoked in the order they are added to the application. 

They can be utilized for a variety of purposes, including logging, authentication, error handling, and more. 

Middleware functions are defined with the signature (req, res, next).

### Order of execution

Middleware functions are executed in the order they are added to the application. 

This sequential execution allows for the establishment of a pipeline through which the request and response pass.

### Request and Response Manipulation

Middleware functions can inspect and manipulate both the request and response objects. 

This enables tasks such as modifying request headers, parsing request bodies, adding data to the response, and more.

### Next Function

The next function is a crucial element in middleware. 

When called, it passes control to the next middleware function in the stack. 

If omitted, the request-response cycle may be halted, preventing subsequent middleware from executing.

### Middleware Stack

Express maintains a stack of middleware functions that are executed in sequence. 

Developers can add middleware globally to the application or locally to specific routes, allowing for fine-grained control over when and how middleware is applied.

### Built-in and Third-Party Middleware

Express provides a set of built-in middleware functions for common tasks such as serving static files, handling cookies, and parsing the request body. 

Additionally, developers can leverage third-party middleware or create custom middleware tailored to the application's specific needs.

Example of a middleware:

```javascript
const loggerMiddleware = (req, res, next) => {
    console.log(`[${new Date().toISOString()}] ${req.method} ${req.url}`);
    next(); // Pass control to the next middleware
}

app.use(loggerMiddleware); // Apply middleware globally
```
