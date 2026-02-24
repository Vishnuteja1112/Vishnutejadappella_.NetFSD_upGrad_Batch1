let cart = [
  { id: 1, product: "Laptop", price: 60000, qty: 1 },
  { id: 2, product: "Headphones", price: 2000, qty: 2 },
  { id: 3, product: "Mouse", price: 800, qty: 1 }
];

// 1. Total cart value
let total = cart.reduce((sum, p) => sum + p.price * p.qty, 0);
console.log("Total:", total);

// 2. Increase quantity of product id=2
let updatedQty = cart.map(p =>
  p.id === 2 ? { ...p, qty: p.qty + 1 } : p
);
console.log("Qty Updated:", updatedQty);

// 3. Remove product id=3
let removed = cart.filter(p => p.id !== 3);
console.log("Removed:", removed);

// 4. Discount 10% for items > ₹10000
let discounted = cart.map(p =>
  p.price > 10000 ? { ...p, price: p.price * 0.9 } : p
);
console.log("Discounted:", discounted);

// 5. Sort by total item price
let sorted = [...cart].sort(
  (a, b) => a.price * a.qty - b.price * b.qty
);
console.log("Sorted:", sorted);

// 6. Any product > ₹50000?
let costly = cart.some(p => p.price > 50000);
console.log("Costly item?", costly);

// 7. All items in stock?
let allInStock = cart.every(p => p.qty > 0);
console.log("All in stock?", allInStock);

// ⭐ Bonus — Invoice format
let invoice = cart
  .map(p => `${p.product} x${p.qty} = ₹${p.price * p.qty}`)
  .join("\n");
console.log("Invoice:\n" + invoice);

// Most expensive product
let expensive = cart.reduce((max, p) =>
  p.price > max.price ? p : max
);
console.log("Most Expensive:", expensive);

// GST 18%
let gst = total * 0.18;
console.log("GST:", gst);