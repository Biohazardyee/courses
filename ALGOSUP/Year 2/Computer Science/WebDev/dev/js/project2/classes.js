class Post {
    static blogName = 'My Blog';
    title;
    content;

    #date; // not the same as date

    get Date() {
        return this.#date;
    }

    set Date(date) {
        //if (date > )
        this.#date = date;
    }

    constructor(title, content) {
        this.title = title;
        this.content = content;
    }

    print() {
        console.log(this.#date)
        console.log(this);
    }
}

console.log(Post.blogName);

const post1 = new Post('Post 1', 'This is the content of post 1');

// setter
post1.Date = '2025-04-03';

const post = new Post()



post1.author = 'John Doe';


// post.#date = '2025-04-03' 




post1.print();

//! *************************************
console.log('------------------------------------');

function add(x, y) {
    return x + y;
}

console.log(add(1, 2));

function add(x, y, z) {
    return x + y + z;
}

console.log(add(1, 2, 3));

//! *************************************
console.log('------------------------------------');

const school = {
    name: 'ALGOSUP',
    count: 54,
};

const { name, count } = school;
console.log(name);
console.log(count);

const { author } = school;
console.log(author);

const { name: n, count: c } = school;
console.log(n);
console.log(c);

//! *************************************
console.log('------------------------------------');
const numbers = [7, 4, 3, 8, 9, 2, 6]

const [n1, n2, , n3, ...others] = numbers

console.log(n1)
console.log(n2)
console.log(n3)
console.log(others)

console.log(`
copy
    `)
const [...newNumbers] = numbers
console.log(newNumbers)


//! *************************************
console.log('------------------------------------');

let y = 1;
let x = 2;
let temp = 0;
console.log(y)
console.log(x)

temp = y
y = x
x = temp

console.log(y)
console.log(x)

