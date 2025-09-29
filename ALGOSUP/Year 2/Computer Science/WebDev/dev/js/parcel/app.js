const h1Element = document.querySelector('#title');
console.log(h1Element);

const h3Element = document.querySelector('h3');
console.log(h3Element);

const post = document.querySelector('#post2 > p:last-child');
console.log(post);

const posts = document.querySelectorAll('p');
console.log(posts)

const article = document.querySelector('article');
console.log(article.children);
console.log(article.parentElement);
console.log(article.nextElementSibling);
console.log(article.previousElementSibling);

article.querySelector('p')

const btn = document.querySelector('#btn');
// btn.onclick = () => {
//     console.log('1st handler');
// };

// btn.onclick = () => {
//     console.log('2nd handler');
// }


//? Event Propagation

const superEl = document.querySelector('#super');
const parentEl = document.querySelector('#parent');
const childEl = document.querySelector('#child');

superEl.addEventListener('click', () => {
    console.log('super clicked');
});

parentEl.addEventListener('click', (event) => {
    console.log('parent clicked');
    event.stopPropagation();
});

childEl.addEventListener('click', () => {
    console.log('child clicked');
}
);

const link = document.querySelector('#link');



document.addEventListener('contextmenu', (event) => {
    event.preventDefault();
    console.log('right click');
}
);

// article.innerHTML = '<p>New paragraph</p>'
// article.textContent = '<p>New paragraph</p>'

//? Implement a page with input, button and div. Whenever the user clicks on the button 
//? take the text inside the input and display in the div

//? input.value


const inputName = document.querySelector('#input');

// inputName.addEventListener('input', (event) => {

// }
// );

btn.addEventListener('click', () => {
    const div = document.querySelector('#output');
    div.textContent = inputName.value;
});

inputName.addEventListener('keypress', (event) => {
    if (event.key === 'Enter') {
        btn.click();
    }
});
