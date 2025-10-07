# Advanced API

## Files

During the previous days we have seen how to handle and work with various data type in a REST API with Node.js. Yet we didn't discuss about a data type that we use daily: binary file

Sharing picture, images, videos is something that we do even without thinking about it. Did you post a picture of your breakfast today ? Maybe you sent an excel file to someone ? Did you dance and upload a video of the latest TikTok trend ?

In any case, uploading a file is quite a common thing to do and you need to know how to handle that in your API.

Uploading files via API involves sending files from a client (e.g., a web browser or another server) to a server, which then processes and stores the files.

This is a common requirement for applications dealing with media, documents, or any data that requires file storage.

## HTTP Methods for File Uploads

POST Method:

The most common method for file uploads is the HTTP POST method. When a client sends a POST request to the server with a file attached, the server processes the file and stores it.

## Multipart/Form-Data

Content-Type:

File uploads are typically performed using the multipart/form-data content type. This allows clients to send binary data, including files, in a structured way.

Form Fields:

In a multipart/form-data request, each file is associated with a form field. Additional metadata, such as file name, content type, and any other relevant information, can be included as form fields.

## API Endpoints for File Uploads

Single File Upload:

An API endpoint that accepts a single file in the request payload.

Multiple File Upload:

An API endpoint that supports uploading multiple files in a single request.

## Server-Side Handling

File Storage:

The server needs to handle storing the uploaded files. It may save files on the local file system, in a cloud storage service, or a database, depending on the application's requirements.

Validation:

Server-side validation is essential to ensure that the uploaded files meet the specified criteria, such as file type, size limits, and other constraints.

## Security Considerations

File Type Verification:

Verify that the uploaded files have the expected file type to prevent malicious uploads.

Size Limits:

Set limits on file sizes to prevent abuse and denial-of-service attacks.

Authentication and Authorization:

Ensure that only authorized users can upload files, and implement proper authentication mechanisms.

Thanks to body-parser in Node.js (or any other middleware) you know how to work with json objects.

To work with file, the same middleware is not enough, you need a new one: Multer (this is the most used but there is others).

```bash
npm install --save multer
```

Working with file upload change the way the data is being sent. If you work with a normal form, only a basic json body is being sent.

When also sending a file (any kind of file) you will be working with a multipart/form-data enctype.

```javascript
<form action="/upload-file" enctype="multipart/form-data" method="POST"></form>
```

This use the formData API which can also be used in Javascript like so.

```javascript
const form = new FormData();
form.append("username", "JohnDoe");
form.append("profilePicture", fileInput.files[0]); // Assuming fileInput is an <input type="file">
```

Now that we do now a bit more, what is Multer and how can we use it?

Like we said - or I guess you could expect - Multer is a middleware designed to handle multipart/form-data in forms and is only supporting that !

We can setup our base Express.API as follow - without multer first.

As you can see we define our endpoint as we would processing only json data fields. Now let's use multer to handle our formData.

On the top of the file, we need to require multer and then configure it. The minimal configuration is to define where the files need to be saved.

```javascript
const multer = require("multer");
const upload = multer({ dest: "uploads/" }); // 'uploads/' is the directory where files will be stored
```

And we need to say to our Node.js application that for this specific endpoint we want to use the multer middleware to handle the file (or files) being sent.

```javascript
app.post("/files", upload.single("files"), function uploadFile(req, res) {
  console.log(req.body); // Contains text fields
  console.log(req.file); // Contains information about the uploaded file
  res.send("File uploaded successfully");
});
```

We simply added upload.single("files") to our endpoint ! And it is important to note that the files value depend of the name of your input on your HTML page.

To handle multiple files, use upload.array.

And here you go ! A fully functional endpoint to upload and store file in Node.js

You can find a full example here

## HTTP/Websocket

While REST API is the most used concept of data exchange currently used on the internet this is not a silver bullet for all use case.

Imagine that you are creating a chat application and you want your users to receive the message almost instantaneously - as a real-time application.

Or maybe you are trading some stock and want to see a live chart of the value and all buy/sell done be others users

How can you do that in HTTP ?

The first idea that come to mind would be to fetch every X seconds. Maybe 5s is enough for a chat, but if you are in a stock exchange maybe the price will drop by 1% ? Or increase by 1%. Or someone already bought it and you are too late

So we want to do it every 0.5s? Seems almost imperceptible for an user (around 200ms for a OK loading time of a page). But imagine you are on some social media speaking with 20 different friends.

This mean than only you will be sending 20 HTTP calls \* 2 per second = 40 HTTP calls per seconds.

If your application is running and it is in the middle of the night you will be sending API requests for nothing - yet still consuming network, bandwidth, CPU on the server, run database queries...

Not really optimal right ?

How is it done in normal life?

Imagine you are in a restaurant and you already ordered some food (ordering food could be our normal HTTP call).
You don't ask your waiter every minutes when is my food coming (at least I hope you don't do that ).
You are patiently waiting for him to bring the food.

From a querying point of view you are in a waiting something state (here food - in our API case some more data)

WebSocket is a communication protocol that provides full-duplex communication channels over a single, long-lived connection. It is designed to be used by web browsers and web servers for real-time communication.

WebSocket enables bi-directional communication, allowing data to be sent between a client (typically a web browser) and a server with lower latency and overhead compared to traditional HTTP connections.

### Key Features of WebSocket:

Full-Duplex Communication:

Unlike traditional request-response communication in HTTP, WebSocket allows both the client and server to send messages independently at any time. This enables real-time, bidirectional communication.

Low Latency:

WebSocket reduces latency by eliminating the need to establish a new connection for each exchange of data. The persistent connection is kept open, allowing for quicker data transfer.

Efficient Use of Resources:

WebSocket uses a single, long-lived connection that remains open, reducing the overhead of repeatedly opening and closing connections for each data exchange.

WebSocket API:

Browsers provide a JavaScript API (WebSocket API) that allows developers to interact with WebSocket connections. This API includes methods for opening, closing, and sending messages over WebSocket connections

### Use Cases:  

Real-Time Web Applications:

WebSocket is commonly used in real-time web applications where instant updates and communication between clients and servers are crucial, such as chat applications, live collaboration tools, and online gaming.

Financial Trading Platforms:

WebSocket is employed in financial applications where low latency and real-time updates on stock prices or other financial data are essential.

Live Streaming:

Live streaming platforms use WebSocket to provide real-time updates on live events, comments, and interactions.

Collaborative Editing:

Platforms that support collaborative editing, such as Google Docs, leverage WebSocket for instant synchronization of changes made by multiple users.

IoT (Internet of Things):

WebSocket is suitable for IoT applications where devices need to communicate with a server in real-time, exchanging data and receiving updates.

WebSocket significantly improves the efficiency of real-time communication on the web by offering a persistent, low-latency connection. 

Its simplicity and wide support make it a popular choice for developers building applications that require instant updates and interactive features.

## Websocket 

Socket.IO is a JavaScript library that enables real-time, bidirectional communication between web clients and servers. 

It is build on top of the WebSocket protocol but provides additional features, such as fallback mechanisms for environments where WebSocket is not supported. 

Socket.IO is widely used for building real-time web applications, chat applications, online gaming platforms, collaborative tools, and more.

In our project let's install our socket.io library

```bash
npm install socket.io
```

If you use Postman with a workspace (require a postman account) you can use it to try your websocket server.

> New > Create WebSocket Request > Follow the steps

You could also use cURL if you want to do it manually from your terminal (multiples setup you can find online)

Or you can write a quick front end!
