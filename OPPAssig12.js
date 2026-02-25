class Wallet {
  #balance = 0;

  addMoney(amount) {
    this.#balance += amount;
  }

  spendMoney(amount) {
    if (amount > this.#balance) {
      console.log("Not enough balance");
    } else {
      this.#balance -= amount;
    }
  }

  getBalance() {
    return this.#balance;
  }
}

// Test
let w = new Wallet();
w.addMoney(1000);
w.spendMoney(300);

console.log(w.getBalance()); // 700
// console.log(w.#balance); ❌ Error — private