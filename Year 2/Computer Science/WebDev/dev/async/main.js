// async function fn() {
//   return 100;
// }

// const result = fn();

// console.log(result); // Promise { 100 }

// let result = await fetch('https://gutendex.com/books/');

// if (result.ok) {
//   let data = await result.json();
//   console.log(data);
// }


import express from 'express';
import { title } from 'process';

const app = express();

app.get('/', (_, res) => {
    res.send({
        title: 'ALGOSUP BLOG'
    })
});


app.get('/posts', (_, res) => {
    res.send(posts)
}
);

const posts = [
    {
        title: 'Post 1',
        content: 'Post 1 content',
        tags: ['html', 'css', 'js']
    },
    {
        title: 'Post 2',
        content: 'Post 2 content',
        tags: ['html', 'css', 'js']
    },
    {
        title: 'Post 3',
        content: 'Post 3 content',
        tags: ['html', 'css', 'js']
    }
];


app.post('/posts', (req, res) => {
    posts.push({
        title: 'Post New',
        content: 'Post New content',
        tags: ['html', 'js']
    })
    res.send({
        type:posts
    })
}
);

app.listen(3000, () => {
    console.log('Server is running on port 3000');
}
);