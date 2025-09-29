const showMessage = function () {
    console.log("Hello World!");
}

const output = showMessage;
//const output = showMessage();
showMessage();
output();

// function showMessage() {
//     console.log("Hello World!");
// }


/* //? write a function that takes two integers and returns their sum
function add(int1, int2) {
    return int1 + int2;
}

let result = add(60, 9);
console.log(result);
*/

//? write a factorial function using loops
console.log('------------------------------------');

function factorial(num) {
    for (let i = num - 1; i > 0; i--) {
        num *= i;
    }
    return num;
}


let calculator = function (factorial) {
    console.log("The factorial of numbers 1 to 8 are:");

    for (let i = 1; i <= 8; i++) {
        console.log(factorial(i));
    }
}

calculator(factorial);

console.log('------------------------------------');
const printNumbers = function (x, y) {
    console.log('Printing numbers from 10 to 100');
    for (let i = x; i < y; i++) {

        console.log(i);
    }
}

const print10to100 = function (output) {
    output(10, 100);
}

print10to100(printNumbers);

//! *************************************
console.log('------------------------------------');

const sum = (a, b) => a + b;
console.log('Sum:');
console.log(sum(5, 6));

const square = x => x * x;
console.log('Square:');
console.log(square(5));

const calc = square;
console.log(calc(7));

console.log('------------------------------------');

const divide = (a, b) => {
    if (b === 0) {
        return "Cannot divide by zero";
    }
    return a / b;
}

console.log('Division:');
console.log(divide(10, 2));

console.log('------------------------------------');

const printNew = (x, y) => {
    for (let i = x; i < y; i++) {
        console.log(i);
    }
}

const fact1 = num => {
    if (num == 0)
        return 1;

    return num * fact1(--num);
}

console.log('Factorial:');
console.log(fact1(5));