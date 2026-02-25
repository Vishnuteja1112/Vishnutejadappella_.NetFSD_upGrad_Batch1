class User {
  constructor() {
    this._password = "";
  }

  set password(value) {
    if (value.length >= 6) {
      this._password = value;
    } else {
      console.log("Password must be at least 6 characters");
    }
  }

  get password() {
    return this._password;
  }
}

// Test
let u = new User();
u.password = "12345";   // Invalid
u.password = "secure123";
console.log(u.password);