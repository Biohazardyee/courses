var express = require('express')
var router = express.Router()
const fs = require('fs')
const path = require('path')
const bcrypt = require('bcrypt')

const USER_FILE = path.join(__dirname, '../data/users.json')

function generateId(users) {
    if (users.length === 0) {
        return 1;
    } else {
        return Math.max(...users.map(u => u.id)) + 1;
    }

}

function readUserFile() {
    try {
        const data = fs.readFileSync(USER_FILE, 'utf-8');
        return JSON.parse(data);
    }
    catch (error) {
        return [];
    }
}

function validateUserData(user, users) {
    const error = [];

    if (!user.email || typeof user.email !== 'string' || user.email.trim() === '') {
        error.push("Please enter a valid email");
    }
    if (!user.password || typeof user.password !== 'string' || user.password.trim() === '') {
        error.push("Please provide a valid password")
    }
    if (users.find(users => users.email === user.email)){
        error.push("Email already exists")
    }

    return error;
}

function writeDataToFile(users) {
    fs.writeFileSync(USER_FILE, JSON.stringify(users, null, 2))
}


router.post('/', async function (req, res, next) {
    const { email, password } = req.body;
    const users = readUserFile();

    try {
        const validationErrors = validateUserData({ email, password }, users)

        if (validationErrors.length > 0) {
            return res.status(400).json({
                success: false,
                error: 'Validation Failed',
                details: validationErrors

            })
        }

        const newUser = {
            id: generateId(users),
            email: email.trim(),
            password: await bcrypt.hash(password.trim(), 10),
            roles: ['user']
        }

        users.push(newUser);
        writeDataToFile(users);

        res.status(201).json({
            success: true,
            message: 'Added user',
            data: `User n°${newUser.id}, email: ${newUser.email} with roles: ${newUser.roles} was created`
        })

    }
    catch (error) {
        return res.status(500).json({
            success: false,
            message: 'Failed to create new user',
            error: error.message
        })

    }
})

module.exports = router;