//? print numbers that divide by 3 between 10 and 30 but skips 27
function divideBy3() {
  for (let i = 10; i <= 50; i++) {
    if (i % 3 == 0 && i != 27) {
      console.log("divisible by 3: ", i);
    }
  }
}

divideBy3();


//? Print the following number using for loops (2,4, 8, 16, 32, 64, 128, 256, 512, 1024)

function printDouble() {
  for (let num = 2; num <= 1024; num *= 2) {
    let previousNum = num / 2;
    console.log(previousNum, "times 2 = ", num);
  }
}

printDouble();



/*
//? Print the number of time the random number is generated before it is greater than 15
let num = Math.random() * 20;
let y = 0;

// While Loop
while (num < 15) {
  console.log(num);
  num = Math.random() * 20;
  y++;
}
console.log("y = ", y);

console.log("-------------------");
// For Loop
let i = 0;
for (let num = Math.random() * 20; num < 15; num = Math.random() * 20, i++) {
  console.log(num);
}
console.log("i = ", i);

*/


/*
// simple for loop
for (let i = 0; i < 10; i++) {
  console.log('x = ', i);
}

// same loop using while
y = 0;
while (y < 10) {
  console.log('y =', y);
  y++;
}

*/


/*
// Variable declarations and scope
var name = 'France';
console.log(name);

name = 'ALGOSUP';
console.log(name);

{
  var num = 5;
}
console.log(num);

name = 5;
console.log(name);

// Variable reassignment
let userName = "John";
console.log(userName);

userName = "Jane";
console.log(userName);

// Constant declaration
const color = "ff0000";
console.log(color);
*/