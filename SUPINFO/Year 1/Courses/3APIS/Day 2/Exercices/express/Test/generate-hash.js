const bcrypt = require('bcrypt');

// Generate bcrypt hashes for password123
const password = 'password123';

const hash1 = bcrypt.hashSync(password, 10);
const hash2 = bcrypt.hashSync(password, 10);

console.log('Hash for admin@example.com:', hash1);
console.log('Hash for user@example.com:', hash2);

// DEPRECATED WAS USED FOR GENERATING TEST EXAMPLES

