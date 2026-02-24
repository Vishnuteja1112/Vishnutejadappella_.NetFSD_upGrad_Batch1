let books = [
  { id: 1, title: "JavaScript Basics", price: 450, stock: 10 },
  { id: 2, title: "React Guide", price: 650, stock: 5 },
  { id: 3, title: "Node.js Mastery", price: 550, stock: 8 },
  { id: 4, title: "CSS Complete", price: 300, stock: 12 }
];

// 1. Display all titles
let titles = books.map(b => b.title);
console.log("Titles:", titles);

// 2. Total inventory value
let totalValue = books.reduce((sum, b) => sum + b.price * b.stock, 0);
console.log("Total Value:", totalValue);

// 3. Books above ₹500
let costly = books.filter(b => b.price > 500);
console.log("Above 500:", costly);

// 4. Increase price by 5%
let increased = books.map(b => ({ ...b, price: b.price * 1.05 }));
console.log("Price +5%:", increased);

// 5. Sort by price low → high
let sorted = [...books].sort((a, b) => a.price - b.price);
console.log("Sorted:", sorted);

// 6. Remove by ID (remove id=2)
let removed = books.filter(b => b.id !== 2);
console.log("After Remove:", removed);

// 7. Any book out of stock?
let outOfStock = books.some(b => b.stock === 0);
console.log("Out of Stock?", outOfStock);

// ⭐ Bonus — Group by price range
let grouped = {
  low: books.filter(b => b.price < 500),
  high: books.filter(b => b.price >= 500)
};
console.log("Grouped:", grouped);

// Bonus — Discount for books above ₹600
let discount = books.map(b =>
  b.price > 600 ? { ...b, price: b.price * 0.9 } : b
);
console.log("Discounted:", discount);

// Bonus — Invoice string
let invoice = books.map(b => b.title).join(", ");
console.log("Invoice:", invoice);