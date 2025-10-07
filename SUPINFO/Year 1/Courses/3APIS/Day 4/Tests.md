# Tests

## Purposes of tests

In the realm of software engineering, testing is a systematic and essential process aimed at evaluating the functionality, reliability, and performance of a software application.

It involves running the software under various conditions to identify bugs, defects, or deviations from expected behavior.

The primary purpose of testing is to ensure that the software meets specified requirements and adheres to quality standards, ultimately boosting confidence in its correctness and reliability.

Testing serves multiple crucial purposes within the software development lifecycle.

Firstly, it is instrumental in bug detection, allowing developers to identify and rectify defects early in the development process.

Secondly, testing verifies that the software aligns with specified requirements, providing assurance that it behaves as intended.

Beyond bug detection and requirement verification, testing is integral to enhancing overall software quality, preventing regressions, and validating the application's performance under different conditions.

In the context of Node.js applications, various types of tests are employed to ensure the application's robustness and adherence to requirements.

Unit testing focuses on verifying individual components, such as functions or methods, to ensure their correctness.

Integration testing assesses the interaction between different components, while end-to-end (E2E) testing validates the entire application workflow.

Functional testing evaluates the functionality of the application based on specifications, and performance testing assesses its responsiveness and speed.

Security testing aims to identify vulnerabilities, while snapshot testing captures and compares application outputs to detect unintended changes.

These diverse testing types collectively contribute to comprehensive software quality assurance.

Adhering to best practices is crucial for effective testing in Node.js applications.

Automation of tests ensures repeatability and efficiency, enabling developers to run tests consistently.

Integration of testing into continuous integration (CI) pipelines helps detect issues early in the development process.

Isolation of tests ensures independence and prevents interference between different test cases.

Adhering to best practices is crucial for effective testing in Node.js applications.

Automation of tests ensures repeatability and efficiency, enabling developers to run tests consistently.

Integration of testing into continuous integration (CI) pipelines helps detect issues early in the development process.

Isolation of tests ensures independence and prevents interference between different test cases.

Techniques like mocking and stubbing are employed to isolate components and focus on specific functionalities during testing.

Monitoring and improving code coverage ensure that tests adequately cover the application's codebase.

Designing tests to reflect real-world scenarios ensures that the application behaves as expected in production.

First of all we need a runner. A solution to run our test and provide an easy way to see the result.

For that we will use mocha but a lot of others solutions are existing.

To install it you can use npm:

```bash
npm install mocha --save-dev
```

This time we use “--save-dev” as the test runner is only needed in development and should not be packaged in production !You can also save it globally with -g

## Node.js testing

In a test file for a Node.js application, developers use various keywords and structures to define and organize their tests.

Here are the key components commonly found in a test file, along with explanations of the primary keywords:

- describe
- it
- before / after
- skip / only

### describe

The describe function is used to group related tests into a test suite.

It takes a string description and a callback function that contains the individual test cases(using it statements). This structure helps in organizing tests hierarchically.

### it

The “it” function is used to define individual test cases within a describe block. It also takes a description (string) and a callback function containing the actual test logic.
Each it statement represents a specific test scenario.

### before / after

The before and after functions allow developers to define setup and teardown logic that runs once before and after the entire test suite, respectively
beforeEach / afterEach can also be used, they run before/after each tests !

### skip / only

The skip function allows you to skip a particular test or test suite, while the only function runs only the specified test or test suite. These functions are useful for selectively executing tests during development or debugging.

Unit testing is a software testing technique where individual components or units of a program are tested in isolation to ensure that each unit functions as intended.

The goal is to validate the correctness of specific functions, methods, or modules, isolating them from the rest of the application.

In Node.js, unit testing plays a crucial role in maintaining code quality, facilitating early bug detection, and supporting code refactoring.

### Key Characteristics of Unit Testing

Isolation: Unit tests focus on isolating a specific unit of code, such as a function or method, from the rest of the application. This allows for targeted testing of individual components.

Fast Execution: Unit tests are designed to execute quickly, providing rapid feedback to developers. This enables frequent testing during development without causing significant delays.

Automated Execution: Unit tests are typically automated and integrated into the development workflow, often executed through test runners like Mocha, Jest, or Ava. Automation ensures consistent and repeatable testing.

Mocking: To isolate units during testing, developers may use mocking techniques to replace external dependencies with controlled substitutes. This ensures that the focus is solely on the unit being tested.

Testable Units: Code should be designed with testability in mind. Well-structured and modular code allows for easier creation and maintenance of unit tests.

We have seen all the keyword to create some good tests, but we still lack how we are going to test some code.

The manual way would be to call a function, get the result and throw an error if there is an error or do nothing if this is the good result

This can work, but on large project (and even small project to be honest) this would be tedious to maintain all that manually. And it would be quite complexe to do some advanced test operation like mock a function or spy a call. For that we can use the “assert” library, part of Node Core

To run it simply write and execute in your terminal. If mocha is not installed globally use the mocha library installed in your project.

```bash
mocha test.js
```

If you are using Node.js v20 (and above) you can now use the runner part of the core. You don’t need to install a library like mocha. You will find all informations in the documentation. This can be used if you need a quick test runner, but can also replace your standard test runner as most of the capabilities have been added to the one in core

- describe / it
- after / before
- skip / only
- mock
- reporter

Some runners that you can want to try out

- Jest
    - Developed by Facebook, Jest is a powerful and opinionated test framework. It comes with an integrated assertion library, mocking capabilities, and features like snapshot testing and code coverage reports.
- Mocha
    - Mocha is a versatile and widely used test framework. It provides a flexible and feature-rich testing environment, supporting various assertion libraries and asynchronous testing.
- AVA
    - Ava is known for its fast test execution, running tests concurrently to reduce suite execution time. It emphasizes simplicity, minimal configuration, and isolated test environments.

And with that multiple libraries that can be used to assert of use another way to test a value (expect being also used quite often)

- Chai
    - Chai is a versatile assertion library that supports multiple assertion styles (should, expect, and assert). It integrates seamlessly with popular test runners like Mocha and provides a fluent syntax for expressive assertions.
- Jest Matcher
    - Jest, as a test framework, comes with its own set of matchers for making assertions. These matchers are built-in and cover a wide range of scenarios, simplifying the testing process.
- Sinon
    - While primarily known as a mocking library, Sinon also provides a set of assertion functions that work well with other testing libraries. It is often used for creating spies, stubs, and mocks in tests.

### API Testing 

Testing APIs involves a different set of considerations compared to unit testing. 

API testing ensures that the exposed endpoints of your web service or application work as expected, handle various inputs correctly, and return the intended results. 

There are different types of API tests, and you can use various tools and libraries to perform them.

Supertest is a popular library for testing HTTP assertions in JavaScript applications, particularly in the context of Node.js. 

Its primary use case lies in simplifying the testing of HTTP requests and responses, especially when working with web servers or APIs. 

### API Endpoints Testing

Supertest is commonly used to test API endpoints. 

It allows developers to make HTTP requests (GET, POST, PUT, DELETE, etc.) to specific API routes and assert the responses. 

This ensures that the API endpoints behave as expected under different scenarios.

### Express.js Testing

When working with Express.js, Supertest integrates seamlessly with Express applications. 

It simplifies the process of sending requests to your Express server and validating the responses. 

This is particularly useful for testing route handlers and middleware.

### Integration Testing

Supertest facilitates integration testing by allowing you to make actual HTTP requests to your application, providing a more realistic testing scenario. 

It's valuable for ensuring that different components of your application work together as expected.

### Asynchronous Testing

Since HTTP requests are inherently asynchronous, Supertest works well with asynchronous testing frameworks like Mocha, Jest, or Ava. 

It supports asynchronous assertions and provides mechanisms for handling the completion of requests.

### Response Validation

Supertest enables thorough validation of HTTP responses. You can assert on status codes, headers, and response bodies. 

This is crucial for ensuring that your API adheres to the specified contract and returns the expected data.

### Chaining Requests

Supertest allows you to chain multiple requests together, making it easy to simulate complex scenarios or user workflows that involve sequential HTTP requests. 

This is particularly beneficial for testing APIs with authentication or multi-step processes.

### Testing Error Handling

Supertest can be used to test error handling in your application. 

By intentionally triggering error responses from your API, you can verify that the error-handling mechanisms are working correctly and that appropriate status codes and error messages are returned.

Let’s install supertest ! As always, and you should know the drill now

```bash
npm install supertest --save-dev
```

The setup is almost the same in your test files

```javascript
const assert = require('assert');
const supertest = require('supertest');
const app = require('./app'); // Your Express app

describe('Router', () => {
    it('GET /users', async () => {
        await supertest(app)
            .get('/users')
            .expect(200)
            .expect('Content-Type', /json/)
            .expect((res) => {
                assert(Array.isArray(res.body), 'Response should be an array');
            });
    });
})
```

Let's explain the few lines above

- First we pass the app to supertest then ask for the users endpoint.
- Then we expect to have an http status code 200 (so a success)
- We get the data from the response inside a promise
- We validate the content of the response

Same as before try to think of some tests you want to handle with your API

- a 200/success case: everything work as expected
- a 404 case: the endpoint does not exist
- a 400 case: you are missing some parameters or bad validation
- a 500 case: your call is crashing the server

Working with complexes responses can be quite tedious if you rely only on the pure assert solution provided by Node.js. You can also use

- chai.js
- sinon.js
- or others libs

