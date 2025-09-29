let count = 100;

const fact = num => {
    if (num == 0)
        return 1;
    return num * fact(num - 1); 
}

function double(x) {
    return x * 2;
}

export {count, double, fact};