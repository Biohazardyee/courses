export function Fibonacci(n) {
    if (n <= 0) 
        return 0;
    if (n === 1) 
        return 1;

    return Fibonacci(n - 1) + Fibonacci(n - 2);
}

export function Addition(x, y){
    return x + y;
}

export function division(x,y){
    return x / y
}