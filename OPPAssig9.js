class Product {
  constructor({ name, price, category = "General" }) {
    this.name = name;
    this.price = price;
    this.category = category;
  }

  showDetails = () => {
    console.log(`Product: ${this.name}, Price: ₹${this.price}, Category: ${this.category}`);
  }
}

// Using spread operator
const pData = { name: "Laptop", price: 60000 };
let product = new Product({ ...pData });

product.showDetails();