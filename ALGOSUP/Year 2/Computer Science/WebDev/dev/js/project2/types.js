let x = 654;

console.log('x');
console.log('typeof x:', typeof x);

x = 'this is a string';

console.log(x);
console.log('typeof x:', typeof x);

console.log('------------------------------------');

let num1 = 245;
console.log(typeof num1);
let num2 = 245n;
console.log(typeof num2);

console.log('------------------------------------');

num1 = 4394934934944345939439484384
console.log(num1);

num2 = 535935939599359395534939493935939n
console.log(num2);


console.log('------------------------------------');

// ! weird js stuff
// ! this returns an undefined value
// ! because the function does not return anything
// ! so the value of z is undefined

const add = (a, b) => {
    console.log(a + b);
}

let z = add(5, 6);
console.log(z);
console.log(typeof z);

//! *************************************
console.log('------------------------------------');

(function () {
    // self invoking function
    console.log('Hello World!');
})();

//! *************************************
console.log('------------------------------------');

let a = "I'm a string";
console.log(a);

a = `two
    lines`;
console.log(a);

// a = `calculates: ${factorial(5)}`;
a = `calculates: ${5 * 9}`;
console.log(a);

const school = `ALGOSUP School`;

for (let i = 0; i < school.length; i++) {
    console.log(school[i]);
}

const string = 'Hello World';
for (let i = 0; i < string.length; i++) {
    console.log(string[i]);
}



console.log(school.toLowerCase());
console.log(school.toUpperCase());

console.log(school.slice(0, 7));
console.log(school.split(' '));
console.log(school.match('ALGOSUP'));
console.log(school.replace('ALGOSUP', 'ALGOSUUUUUUUP'));

//! *************************************
console.log('------------------------------------');

let mark = 80;

if (mark >= 60) {
    console.log('You passed');
} else {
    console.log('You failed');
}

console.log(mark >= 60 ? 'You passed' : 'You failed');

// two to the power of 10
console.log(2 ** 10);

if (32 == '32') {
    console.log('32 is equal to "32"');
}

console.log(32 == '32');
console.log(32 == '30');
console.log(32 === '32');

console.log('------------------------------------');

const post = {
    name: 'Post 1',
    content: 'This is the content of post 1',
};

console.log(post);
console.log(post.name);
console.log(post.content);

post.author = 'John Doe';
console.log(post.author);

console.log('32' + 4);
console.log('32' - '4');

console.log('------------------------------------');

const nums = [1, 2, 3, 4, 5];
console.log(nums[4]);

const mixed = [5, 'string', true, {
    name: 'Post',
    content: 'Content',
}];

console.log(mixed[3].name);
console.log(mixed[1]);

mixed.push(6);
console.log(mixed);

console.log('------------------------------------');

const countries = ['France', 'UK', 'Egypt', 'Palestine'];
console.log(countries);

countries[4] = 'Italy';
console.log(countries.length);
console.log(countries);

countries.splice(2, 1);
console.log(countries); 

countries[7] = 'Spain';
console.log(countries);

console.log(countries.reverse());

for (const country of countries) {
    console.log(country);
}

