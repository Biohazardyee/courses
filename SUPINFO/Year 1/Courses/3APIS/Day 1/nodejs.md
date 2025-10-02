# Node.js

## Node.js concepts

Node.js was created by Ryan Dahl, a software engineer, and it was introduced to the world in 2009.

The main idea behind Node.js was to provide a runtime environment that allows developers to execute JavaScript code on the server side, extending the language's capabilities beyond the confines of the browser.

Ryan Dahl's motivation for creating Node.js stemmed from the limitations of traditional server-side technologies at the time.

Conventional server-side environments, characterized by synchronous, blocking I/O operations, faced challenges in handling a large number of concurrent connections efficiently.

Dahl envisioned a new approach, one that embraced an event-driven, non-blocking model, optimizing performance and enabling the development of scalable and real-time applications.

It allows developers to treat multiple requests at the same time, without waiting for one to finish before starting another one. It is an event-driven architecture capable of asynchronous I/O.

### Non-blocking I/O

Node.js employs an asynchronous, non-blocking I/O model, allowing it to handle multiple requests simultaneously without waiting for each operation to complete before moving on to the next.

### Event-driven architecture

Node.js follows an event-driven architecture where actions or events trigger responses.

This approach is well-suited for scenarios where responsiveness and real-time updates are critical.

### JavaScript on the server side

Node.js unifies JavaScript development by enabling the use of the same language on both the client and server sides.

This allows developers to seamlessly transition between frontend and backend development, promoting code reuse and a more cohesive development experience.

---

At its core, Node.js is not just a runtime environment; it represents a paradigm shift in how we conceive and build server-side applications.

Unlike traditional server-side technologies that follow a synchronous, blocking I/O model, Node.js adopts an event-driven, non-blocking approach.

This unique architecture allows developers to handle multiple concurrent connections efficiently, making Node.js particularly adept at building real-time applications and high-performance web servers.

Powered by the V8 JavaScript engine from Google, Node.js executes JavaScript code server-side, a departure from its conventional role confined to the browser.

This unification of JavaScript across the entire development stack, commonly referred to as "JavaScript everywhere," brings a harmonious synergy to the world of full-stack development.

Developers can seamlessly transfer their skills from frontend to backend, fostering code reusability and creating a more unified and streamlined development experience.

One of Node.js's standout features is its ability to handle asynchronous operations efficiently.

This characteristic is particularly advantageous in scenarios where real-time updates and responsiveness are paramount, such as in chat applications, online gaming platforms, and collaborative tools.

Node.js empowers developers to create applications that not only meet but exceed user expectations in terms of speed and interactivity.

## NPM

### Managing dependencies

Additionally, developers can save a package as a dependency using the --save flag to update the package.json file - or using the --save-dev flag to save a dev dependency

    > npm install react --save
    > npm install mocha --save-dev

### Executing scripts

NPM allows developers to define and run scripts in the package.json file.
This is commonly used for tasks such as running tests, building the project, or starting the application. For example, a script to start a server could be defined in the package.json file:

```json
    "scripts": {
        "start": "node server.js"
    }
```

### Global Packages

NPM allows the installation of packages globally using the -g flag.

Some packages are meant to be installed globally and used as command-line tools. The -g flag is used for global installations. For instance, to install the Node.js debugging tool, nodemon, globally:

```bash
    > npm install -g nodemon
```

This allows the nodemon command to be accessible from any terminal window.

### Publishing Packages

NPM enables developers to share their own packages with the global community. By creating a package.json file and using the npm publish command, developers can publish their packages to the NPM registry for others to use.

```bash
    > npm publish
```

### package.json

For developers engaging in project development and testing, package.json introduces the concept of devDependencies.

This section lists dependencies that are necessary during the development phase but not required for the production environment.

```json
    "devDependencies": {
        "mocha": "^9.0.0"
    }
```

This separation ensures that production environments remain lean and only include dependencies essential for runtime.

One of the notable features of package.json is the inclusion of scripts.

```json
    "scripts": {
        "test": "mocha"
    }
```

This separation ensures that production environments remain lean and only include dependencies essential for runtime.

One of the notable features of package.json is the inclusion of scripts.

The scripts section allows developers to define custom commands that can be executed via npm.

Common scripts include starting the application, running tests, or executing build processes. This capability simplifies complex workflows and standardizes project-related tasks.
For example, a script to start a server could be defined in the package.json file:

```json
    "scripts": {
        "start": "node server.js"
    }
```

Beyond technical details, package.json includes metadata about the project, such as the project's author, licensing information, and a brief description.

This metadata provides context and aids in project documentation, making it easier for developers, collaborators, and users to understand the project's purpose and attributes.

Additionally, the package.json file allows developers to specify the minimum version of Node.js and npm that the project is compatible with.

This ensures that the project is executed in environments that meet the specified criteria, promoting consistency and avoiding compatibility issues.

In summary, package.json is more than just a configuration file; it's a central hub of information that streamlines project management, fosters collaboration, and ensures a standardized and well-documented development environment in the Node.js ecosystem.

It reflects the best practices of modern software development, providing a comprehensive and structured approach to project configuration and dependency management.

In addition to the package.json file, Node.js projects often include a package-lock.json file, which serves a specific purpose in managing package dependencies.

The package-lock.json file is automatically generated and updated by npm to provide a deterministic and reproducible snapshot of the project's dependency tree.

Some specific commands that you can use from npm

- npm audit
  - Performs a security audit on your project's dependencies, identifying any known vulnerabilities.
- npm init
  - Initializes a new package.json file for your project. It prompts you to enter details such as the project name, version, entry point, test command, repository, and more.

Some specific commands that you can use from npm

- npm update
  - Updates packages to their latest versions based on the version constraints specified in the package.json file.
- npm run xyz
  - Executes a script xyz defined in the scripts section of the package.json file.

While npm remains the default choice for many Node.js developers, alternative package managers like Yarn and pnpm provide additional options, each with its unique features and advantages.

The choice of which package manager to use often depends on specific project requirements, developer preferences, and the need for specific features such as speed, disk space efficiency, or offline capabilities.

There are a few alternative package managers that offer different features and approaches.

### Yarn

Yarn is a fast, reliable, and secure package manager for JavaScript. It was developed by Facebook and is designed to be a drop-in replacement for npm. 

Yarn introduced features like deterministic dependency resolution, parallel downloads, and offline capabilities, addressing some performance and reliability concerns that developers had with npm.

### pnpm

pnpm is a fast and disk-space efficient package manager for Node.js. 

It is designed to share dependencies across projects, saving disk space and reducing redundancy. 

pnpm uses a single content-addressable storage for all dependencies, allowing them to be linked and shared.

### Symbol before version number

- ~ : allows update to newest patch version
- ^ : allows update to newest minor version
- * : allows update to any version
- no symbol : only that exact version
- > : greater than
- >= : greater than or equal to
- < : less than
- <= : less than or equal to

### ES Modules vs CommonJS

Node.js supports two module systems: CommonJS and ES Modules (ECMAScript Modules).

- CommonJS: This is the original module system used in Node.js. It uses require() to import modules and module.exports to export them. CommonJS modules are synchronous and are loaded at runtime.

- ES Modules: This is the newer module system introduced in ECMAScript 2015 (ES6). It uses import and export statements for module management. ES Modules are asynchronous and can be statically analyzed, allowing for better optimization by bundlers and tools.

To use ES Modules in Node.js, you need to set the "type" field in your package.json file to "module". This tells Node.js to treat .js files as ES Modules.

```json
{
  "type": "module"
}
```

This allows you to use import and export statements in your JavaScript files.

For example, to export a function in ES Modules:

```javascript
export function myFunction() {
    // function code
}
```

And to import it in another file:

```javascript
import { myFunction } from './myModule.js';
myFunction();
```

To use CommonJS, you can either set the "type" field to "commonjs" or omit it entirely, as CommonJS is the default module system in Node.js.

```json
{
  "type": "commonjs"
}
```
This allows you to use require() and module.exports in your JavaScript files.

For example, to export a function in CommonJS:

```javascript
module.exports.myFunction = function() {
    // function code
}
```
And to import it in another file:

```javascript
const { myFunction } = require('./myModule.js');
myFunction();
```

