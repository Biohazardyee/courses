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

const add1 = (a,b) => a + b;
console.log(add1(5, 7));