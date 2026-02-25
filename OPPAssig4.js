class Vehicle {
  constructor(brand, speed) {
    this.brand = brand;
    this.speed = speed;
  }

  start() {
    console.log(`${this.brand} vehicle started at ${this.speed} km/h`);
  }
}

class Car extends Vehicle {
  constructor(brand, speed, fuelType) {
    super(brand, speed);
    this.fuelType = fuelType;
  }

  showDetails() {
    console.log(`Brand: ${this.brand}, Speed: ${this.speed}, Fuel: ${this.fuelType}`);
  }
}

// Test
let car = new Car("Toyota", 120, "Petrol");
car.start();
car.showDetails();