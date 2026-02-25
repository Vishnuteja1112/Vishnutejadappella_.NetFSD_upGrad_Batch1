class Student {
  constructor(name) {
    this.name = name;
    this.marks = [];
  }

  addMark(mark) {
    this.marks.push(mark);
  }

  getAverage() {
    let sum = this.marks.reduce((a, b) => a + b, 0);
    return sum / this.marks.length;
  }

  getGrade() {
    let avg = this.getAverage();

    if (avg >= 90) return "A";
    else if (avg >= 75) return "B";
    else if (avg >= 50) return "C";
    else return "Fail";
  }
}

// Test
let s = new Student("Teja");
s.addMark(85);
s.addMark(90);
s.addMark(78);

console.log("Average:", s.getAverage());
console.log("Grade:", s.getGrade());