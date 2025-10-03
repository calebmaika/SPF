const fs = require('fs');

// Read the file
const filePath = 'c:\\Users\\jffal\\OneDrive\\Documents\\Alliance Design Tests\\grades.html';
let content = fs.readFileSync(filePath, 'utf8');

// Replace all instances
content = content.replace(/class="add-entry-btn">\+ Add/g, 'class="edit-btn" onclick="editRow(this)">Edit');

// Write back to file
fs.writeFileSync(filePath, content, 'utf8');

console.log('All Add buttons have been replaced with Edit buttons!');