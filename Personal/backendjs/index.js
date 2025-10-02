import fs from "fs";
import { parseArgs } from "node:util";

const options = {
  text: { type: "string", short: "t" },
  clear: {type: "string", short: "c"},
};

const obj = parseArgs({ options });

console.log(obj);

function main(obj) {
  if (obj.values.text != null) {
    const d = new Date();
    let time = d.toLocaleString(); // Human-readable format
    fs.appendFileSync("log.txt", `${time} | ${obj.values.text}\n`, "utf-8");
  } 
  else if (obj.values.clear){
    fs.writeFileSync("log.txt", "", "utf-8");

  }
  
  else {
    return "There was an error";
  }

  const data = fs.readFileSync("log.txt", "utf8");
  console.log("File content:");
  console.log(data);
}

main(obj);
