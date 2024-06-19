import express from 'express';
import bodyParser from 'body-parser';
import cors from 'cors';
import fs from 'fs';

const app = express();
const PORT = 3000;
const dbFilePath = 'src/db.json';

app.use(bodyParser.json());
app.use(cors());

// Ensure the db file exists
if (!fs.existsSync(dbFilePath)) {
    fs.writeFileSync(dbFilePath, JSON.stringify([]));
}

app.get('/ping', (req, res) => {
    res.send(true);
});

app.post('/submit', (req, res) => {
    try {
        const { name, email, phone, github_link, stopwatch_time } = req.body;
        const db = JSON.parse(fs.readFileSync(dbFilePath, 'utf-8'));
        db.push({ name, email, phone, github_link, stopwatch_time });
        fs.writeFileSync(dbFilePath, JSON.stringify(db));
        res.send('Submission saved!');
    } catch (error) {
        console.error('Error parsing or saving data:', error);
        res.status(500).send('Internal server error');
    }
});

app.get('/read', (req, res) => {
    try {
        const index = parseInt(req.query.index as string);
        const db = JSON.parse(fs.readFileSync(dbFilePath, 'utf-8'));
        if (index < 0 || index >= db.length) {
            res.status(404).send('Submission not found');
        } else {
            res.json(db[index]);
        }
    } catch (error) {
        console.error('Error reading data:', error);
        res.status(500).send('Internal server error');
    }
});

app.put('/update', (req, res) => {
    try {
        const { index, name, email, phone, github_link, stopwatch_time } = req.body;
        const db = JSON.parse(fs.readFileSync(dbFilePath, 'utf-8'));
        if (index < 0 || index >= db.length) {
            res.status(404).send('Submission not found');
        } else {
            db[index] = { name, email, phone, github_link, stopwatch_time };
            fs.writeFileSync(dbFilePath, JSON.stringify(db));
            res.send('Submission updated!');
        }
    } catch (error) {
        console.error('Error updating data:', error);
        res.status(500).send('Internal server error');
    }
});

app.delete('/delete', (req, res) => {
    try {
        const index = parseInt(req.body.index as string);
        const db = JSON.parse(fs.readFileSync(dbFilePath, 'utf-8'));
        if (index < 0 || index >= db.length) {
            res.status(404).send('Submission not found');
        } else {
            db.splice(index, 1);
            fs.writeFileSync(dbFilePath, JSON.stringify(db));
            res.send('Submission deleted!');
        }
    } catch (error) {
        console.error('Error deleting data:', error);
        res.status(500).send('Internal server error');
    }
});

app.listen(PORT, () => {
    console.log(`Server running on port ${PORT}`);
});
