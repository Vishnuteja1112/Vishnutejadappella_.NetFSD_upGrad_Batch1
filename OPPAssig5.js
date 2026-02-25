class Employee {
  constructor(name, salary) {
    this.name = name;
    this.salary = salary;
  }

  getDetails() {
    console.log(`${this.name}, Salary: ₹${this.salary}`);
  }
}

class Manager extends Employee {
  constructor(name, salary, bonus) {
    super(name, salary);
    this.bonus = bonus;
  }

  getTotalSalary() {
    return this.salary + this.bonus;
  }
}

class Director extends Manager {
  constructor(name, salary, bonus, stockOptions) {
    super(name, salary, bonus);
    this.stockOptions = stockOptions;
  }

  getFullCompensation() {
    return this.getTotalSalary() + this.stockOptions;
  }
}

// Test
let d = new Director("Teja", 80000, 20000, 50000);
d.getDetails();
console.log("Full Compensation:", d.getFullCompensation());