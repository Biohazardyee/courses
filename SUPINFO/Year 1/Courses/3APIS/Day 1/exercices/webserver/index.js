import { createServer } from 'http';
import { readFile } from 'fs/promises';
import { join, dirname } from 'path';
import { fileURLToPath } from 'url';

const __filename = fileURLToPath(import.meta.url);
const __dirname = dirname(__filename);

const server = createServer(async (req, res) => {
    const url = req.url;
    const method = req.method;

    console.log(`${method} ${url}`);

    try {
        if (method === 'GET') {
            if (url === '/index' || url === '/') {
                // Serve index.html
                const indexPath = join(__dirname, 'index.html');
                const indexContent = await readFile(indexPath, 'utf8');
                
                res.writeHead(200, { 'Content-Type': 'text/html' });
                res.end(indexContent);
                
            } else if (url === '/form') {
                // Serve form.html
                const formPath = join(__dirname, 'form.html');
                const formContent = await readFile(formPath, 'utf8');
                
                res.writeHead(200, { 'Content-Type': 'text/html' });
                res.end(formContent);
                
            } else if (url === '/form.js') {
                // Serve form.js (THIS IS THE NEW PART!)
                const jsPath = join(__dirname, 'form.js');
                const jsContent = await readFile(jsPath, 'utf8');
                
                res.writeHead(200, { 'Content-Type': 'application/javascript' });
                res.end(jsContent);
                
            } else {
                
                res.writeHead(404, { 'Content-Type': 'text/html' });
                res.end(`
                    <h1>404 - Page Not Found</h1>
                    <p>The requested page "${url}" was not found.</p>
                    <p><a href="/index">Go to Index</a> | <a href="/form">Go to Form</a></p>
                `);
            }
        } else {

            res.writeHead(405, { 'Content-Type': 'text/plain' });
            res.end('Method Not Allowed');
        }
    } catch (error) {
        console.error('Error serving file:', error);
        res.writeHead(500, { 'Content-Type': 'text/plain' });
        res.end('Internal Server Error');
    }
});

const port = 8000;

server.listen(port, () => {
    console.log(`Server running at http://localhost:${port}`);
    console.log('Available endpoints:');
    console.log('  - http://localhost:8000/index (or just /)');
    console.log('  - http://localhost:8000/form');
});;

