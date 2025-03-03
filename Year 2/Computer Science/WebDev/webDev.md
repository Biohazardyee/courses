# Web Development

## Goals

- Understanding Web basics
- Build & Style web pages
- Code in JS
- Use package managers & bundlers
- Understand TypeScript language
- Advanced libraries/frameworks
  - CSS libraries
  - Component-based frameworks

## References

- Mozilla Developer network
- W3Schools
- Stack Overflow
- Node.js
  - https://nodejs.org
  - https://npmjs.com

## Tools

- VSCode
- Live Server
- Chrome / Edge browser

## Web Basics

### Web Content Library

#### Website Structure

- User Goal: a user expects something from a webpage, you should have a goal for each page
- Web Contetn: achieving the goal by giving content to a webpage
- Presented using
  - HTML (content/structure)
  - CSS (style)
  - JS (behavior)

Main component: Website

- Linked Pages
- Rendered in browser

Second component: Browser

Third component: Server

- Hosting website
- Address (IP)
- Domain (algosup.com)

### Request/Response

- HTTP Request

website -> server <- scrimba.com <- broser

- HTTP Response

website -> server -> code -> browser

## HTML Documents

- Hyper Text Markup Language
  - Text file
  - Website Structure
  - Describe Content

## JS Basics

### Variables

#### let

- Used to store data

  - Simple data (number,name)
  - DOM Objects (HTML elements)

- Declare variables
  - Use `let` keyword

#### var

- Declare variables using var
  - Old times method
  - Bleed out of scope
  - Redeclaration allowed
  - Declared after used

#### Difference between `let` and `var`

- `var` is function-scoped, meaning it is accessible within the function it is declared in.
- `let` is block-scoped, meaning it is only accessible within the block (e.g., `{}`) it is declared in.
- `let` does not allow re-declaration within the same scope, while `var` does.
- `let` helps avoid issues with variable hoisting, which can occur with `var`.

Example:

```javascript
function example() {
  if (true) {
    var x = 10;
    let y = 20;
  }
  console.log(x); // 10
  console.log(y); // ReferenceError: y is not defined
}
example();
```

### Constants

- Variables with constant values
  - never change
  - reassign not allowed

### Functions

- Perform the same action many places inside of the code when called
- Functions used
  - Wrap required action code
  - Reuse by calling
  - No repeated code
- 3 parts
  - Name, parameters, body

Declared using the `function` keyword

- local variables
  - Declared inside
  - Only visible inside

Call function by its name

Can return a value usiong the `return` keyword

- Declared using function expressions
- Created and assigned to a variable
  - Only useable after expression

```JS
let showMessage1 = function () {
    console.log('Hello World');
}

showMessage1()
```

- Function as value

```JS
function showMessage() {
    console.log('Hello World');
}
```

### Callback functions

- Passing function as parameters
- To another function
- Common in JS apps

```JS
function play(params, output){
    // code
    output('Played');
}

play('another message', showMessage)
```

### Arrow functions

- Easier way to declare functions
- Concise
- create same functions

```JS
let sum = (a,b) => a + b;

let sum = (a,b) => {
    let result = a + b;
    return result;
}
```
