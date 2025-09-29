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
### Variables

let sum = (a,b) => {
    let result = a + b;
    return result;
}
```

## Module 

### Exporting

- export keyword

```JS
export const RED = #f00;
export function logger(){...}
export default message;
```

## DOM BASICS

### Searching

- find element by selector 
- Use same css selectors 
- `querySelector()`
  - Takes selector
  - returns first element match