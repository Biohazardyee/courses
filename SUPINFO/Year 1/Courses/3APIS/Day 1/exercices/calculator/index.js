import { parseArgs } from "node:util";

const options = {
    operator: { type: "string", short: "o" },
};

const obj = parseArgs({ 
    options,
    allowPositionals: true 
});
console.log(obj)

function calculator(obj) {
    if (obj.values.operator === 'add' || obj.values.operator === '+') {
        console.log('Adding numbers...');
    
        const numbers = obj.positionals.map(Number);
        console.log('Numbers to add:', numbers);
        
        let sum = 0;
        for (let i = 0; i < numbers.length; i++) {
            sum += numbers[i];
        }
        console.log('Sum:', sum);
        
    }
    
    else if (obj.values.operator === 'subtract' || obj.values.operator === "sub" || obj.values.operator === "-") {
        console.log('Subtracting numbers...');
        
        // Use positional arguments instead of -n flag
        const numbers = obj.positionals.map(Number);
        console.log('Numbers to subtract:', numbers);
        
        let result = numbers[0];
        for (let i = 1; i < numbers.length; i++) {
            result -= numbers[i];
        }
        console.log('Subtraction result:', result);
        
        return result;
    }

}

calculator(obj);
