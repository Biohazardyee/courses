import 'colors';
import sharp from 'sharp';
import { faker } from '@faker-js/faker';


sharp('code.jpg')
    .webp()
    .toFile('code-400p.webp');


console.log('ALGOSUP'.green);
console.log('ALGOSUP'.america);
console.log('ALGOSUP'.bgBlue.bold);
console.log('ALGOSUP'.underline.red);
console.log('ALGOSUP'.zebra);
console.log('ALGOSUP'.rainbow);
console.log('ALGOSUP'.trap);
console.log('ALGOSUP'.random);


console.log('------------------------------------');

const Date = faker.date.recent();
faker.location.timeZone();

console.log(`The time is: ${Date.toLocaleTimeString()}`);
console.log(`Today's date is: ${Date.toLocaleDateString()}`);

console.log('------------------------------------');

const randomName = faker.person.fullName();
console.log(`Random name: ${randomName}`);
const randomEmail = faker.internet.email();
console.log(`Random email: ${randomEmail}`);
const randomFood = faker.food.dish();
console.log(`Random food: ${randomFood}`);