import { count } from './counter.js';
import './style.less';

console.time('test');

console.log('app.js file')

console.log(count)

let name = 'John Doe';

console.log('Then name of the use is ' + name)
console.log(`Then name of the use is ${name}`)

console.warn('This is a warning')

console.error('This is an error')

console.clear()

const tech = ['HTMl', 'CSS', 'JS', 'Node']; 

console.table(tech)
console.log(tech)

const post = {
    title: 'Post One',
    content: 'This is post one',
    author: 'John Doe'
};

console.table(post);
console.log(post);

console.group('Numbers');
console.log('1');
console.log('2');
console.log('3');
console.groupEnd();

console.timeEnd('test');

// document.write('inside the page ooo')
// alert('alerte generalllllllle')