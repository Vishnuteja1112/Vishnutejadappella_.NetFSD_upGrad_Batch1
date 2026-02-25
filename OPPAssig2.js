class BankAccount {
  constructor(accountHolder, balance = 0) {
    this.accountHolder = accountHolder;
    this.balance = balance;
  }

  deposit(amount) {
    this.balance += amount;
    console.log(`Deposited ₹${amount}`);
  }

  withdraw(amount) {
    if (amount > this.balance) {
      console.log("Insufficient balance!");
    } else {
      this.balance -= amount;
      console.log(`Withdrawn ₹${amount}`);
    }
  }

  checkBalance() {
    console.log(`Current balance: ₹${this.balance}`);
  }
}

// Test
let acc = new BankAccount("Teja", 5000);
acc.deposit(2000);
acc.withdraw(3000);
acc.checkBalance();