import http from "http";
import { readFile } from "fs/promises";
import { join, dirname } from "path";
import { fileURLToPath } from "url";


const port = 3000;

const __filename = fileURLToPath(import.meta.url);
const __dirname = dirname(__filename);

const server = http.createServer(async (req, res) => {
  const url = req.url;
  const method = req.method;

  if (method === "GET") {
    if (url === "/index" || url === "/") {
      const indexPath = join(__dirname, "index.html");
      const indexContent = await readFile(indexPath, "utf8");

      res.writeHead(200, { "Content-Type": "text/html" });
      res.end(indexContent);
    } else {
      res.writeHead(404, { "Content-Type": "text/html" });
      res.end(`
                <h1>404 - Page Not Found</h1>
                `);
    }
  }
});

server.listen(port, () => {
  console.log(`Server running at http://localhost:${port}`);
  console.log("Available endpoints:");
  console.log("  - http://localhost:3000/index (or just /)");
});


