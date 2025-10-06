var express = require('express');
var router = express.Router();
const fs = require('fs')
const path = require('path')
const bcrypt = require('bcrypt')
const jsonwebtoken = require('jsonwebtoken')

const USER_FILE = path.join(__dirname, '../data/users.json')

router.post('/', async function (req, res, next) {
    try {
        const users = JSON.parse(fs.readFileSync(USER_FILE, 'utf-8'))

        const { email, password } = req.body;

        const user = users.find(u => u.email === email);

        if (!user) {
            return res.status(401).json({
                success: false,
                message: "Invalid email or password"
            });
        }

        const isValidPassword = await bcrypt.compare(password, user.password);

        if (isValidPassword) {
            const token = jsonwebtoken.sign({
                userId: user.id,
                email: user.email,
                roles: user.roles
            },
                process.env.JWT_SECRET
            );
            res.status(200).json({
                success: true,
                token: token,
                user: {
                    id: user.id,
                    email: user.email,
                    roles: user.roles
                }
            })
        }
        else {
            return res.status(403).json({
                success: false,
                message: "Invalid password or email credentials"
            })
        }


    }
    catch (error) {
        return res.status(500).json({
            success: false,
            error: "Error while processing your request",
            details: error.message,
        })
    }
})

module.exports = router;