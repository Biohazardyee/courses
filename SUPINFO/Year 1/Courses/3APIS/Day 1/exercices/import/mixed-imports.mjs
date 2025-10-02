import { Fibonacci } from '../basic/index.js';

const { Fibonacci2 } = await import('../package2/index.js');

console.log('ESM Fibonacci(8):', Fibonacci(10));
console.log('CJS Fibonacci2(9):', Fibonacci2(9));