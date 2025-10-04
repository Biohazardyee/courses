const { error } = require('console');
var express = require('express')
var router = express.Router()
var fs = require('fs')
var path = require('path');
const { json } = require('stream/consumers');

const DATA_FILE = path.join(__dirname, '../data/data.json');

const readData = () => {
    try {
        const data = fs.readFileSync(DATA_FILE, 'utf-8');
        return JSON.parse(data);
    } catch (err) {
        return [];
    }
}

const findDataId = (id) => {
    const dataId = parseInt(id);

    if (isNaN(dataId)) {
        return { error: 'Invalid product ID. Must be a number.', status: 400 };
    }

    const data = readData();
    const dataIndex = data.findIndex(d => d.id === dataId);

    if (dataIndex === -1) {
        return { error: 'Product not found', status: 404 };
    }

    return { data, dataIndex, dataId };
}

const writeData = (data) => {
    fs.writeFileSync(DATA_FILE, JSON.stringify(data, null, 2));
}

const validateData = (data) => {
    const errors = [];

    if (!data.name || typeof data.name !== 'string' || data.name.trim() === '') {
        errors.push("A name is required for your data.");
    }

    if (data.value === undefined || typeof data.value !== 'number') {
        errors.push("A valid data value is required");
    }

    return errors;
}

const generateId = (data) => {
    if (data.length === 0) return 1;
    return Math.max(...data.map(d => d.id)) + 1;

}

const securityMiddleware = (req, res, next) => {
    if (req.headers['user-value'] === 'user') {
        next()
    }
    else {
        res.status(403).json({ success: false, error: 'Forbidden' })
    }

}

router.get('/', securityMiddleware, function (req, res, next) {
    try {
        const data = readData();
        res.json({
            success: true,
            count: data.length,
            data: data
        })
    } catch (err) {
        console.error("Failed Reading Data", err);
        res.status(500).json({
            success: false,
            error: 'Failed to read data',
            detail: err.message
        })

    }
});

router.post('/', securityMiddleware, function (req, res, next) {
    try {
        const { name, value } = req.body;

        const validationErrors = validateData({ name, value });
        if (validationErrors.length > 0) {
            return res.status(400).json({
                success: false,
                error: 'Validation failed',
                details: validationErrors
            })
        }
        const data = readData();

        const newData = {
            id: generateId(data),
            name: name.trim(),
            value: parseFloat(value),
            date: new Date().toDateString()
        };

        data.push(newData);
        writeData(data)

        res.status(201).json({
            success: true,
            message: 'Added data succesfully',
            data: newData
        });
    }
    catch (error) {
        res.status(500).json({
            success: false,
            message: 'Failed to create data',
            details: error.message
        })
    }
})

router.delete('/', securityMiddleware, function (req, res, next) {
    try {
        writeData([]);

        res.json({
            success: true,
            message: 'Succesfully deleted data'
        });
    } catch (error) {
        res.json({
            success: false,
            message: 'Failed to delete data',
            details: error.message
        })
    }
})

router.get('/:id', securityMiddleware, function (req, res, next) {
    try {
        const result = findDataId(req.params.id);

        if (result.error) {
            return res.status(result.status).json({
                success: false,
                error: result.error
            });
        }

        const data = result.data[result.dataIndex];

        res.status(200).json({
            success: true,
            message: 'Retrieved data by ID succesfully',
            data: data
        });

    }
    catch (error) {
        res.status(500).json({
            success: false,
            error: 'Failed to read data',
            details: error.message
        });
    }
})

router.patch('/:id', securityMiddleware, function (req, res, next) {
    try {
        const result = findDataId(req.params.id);

        if (result.error) {
            return res.status(result.status).json({
                success: false,
                error: result.error
            });
        }

        const { data, dataIndex, dataId } = result;
        const { name, value } = req.body;

        if (name !== undefined && name.trim() !== '') {
            data[dataIndex].name = name.trim();
        }

        if (value !== undefined && typeof value === 'number') {
            data[dataIndex].value = parseFloat(value);
        }

        writeData(data)

        res.status(200).json({
            success: true,
            message: `Updated data item ${dataId} successfully`,
            data: data[dataIndex]
        })
    }
    catch (error) {
        res.status(500).json({
            success: false,
            message: "Failed to update data",
            details: error.message
        })
    }
})

module.exports = router;