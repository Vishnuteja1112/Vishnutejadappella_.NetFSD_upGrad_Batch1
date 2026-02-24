let employees = [
 { id:1, name:"Ravi", dept:"IT", salary:70000 },
 { id:2, name:"Anita", dept:"HR", salary:50000 },
 { id:3, name:"Karan", dept:"IT", salary:80000 },
 { id:4, name:"Meena", dept:"Finance", salary:60000 }
];

// 1. Total salary expense
let totalSalary = employees.reduce((sum, e) => sum + e.salary, 0);
console.log("Total Salary:", totalSalary);

// 2. Highest & lowest paid
let highest = employees.reduce((max, e) =>
  e.salary > max.salary ? e : max
);
let lowest = employees.reduce((min, e) =>
  e.salary < min.salary ? e : min
);
console.log("Highest:", highest);
console.log("Lowest:", lowest);

// 3. Increase IT salary by 15%
let updated = employees.map(e =>
  e.dept === "IT"
    ? { ...e, salary: e.salary * 1.15 }
    : e
);
console.log("IT Updated:", updated);

// 4. Group by department
let grouped = employees.reduce((acc, e) => {
  acc[e.dept] = acc[e.dept] || [];
  acc[e.dept].push(e);
  return acc;
}, {});
console.log("Grouped:", grouped);

// 5. Dept-wise average salary
let avgDept = {};
for (let d in grouped) {
  avgDept[d] =
    grouped[d].reduce((s, e) => s + e.salary, 0) /
    grouped[d].length;
}
console.log("Dept Avg:", avgDept);

// 6. Sort by salary descending
let sorted = [...employees].sort((a, b) => b.salary - a.salary);
console.log("Sorted:", sorted);

// ⭐ Bonus — Tax deduction 10%
let taxed = employees.map(e => ({
  ...e,
  salary: e.salary * 0.9
}));
console.log("After Tax:", taxed);

// Above average salary
let avgSalary = totalSalary / employees.length;
let aboveAvg = employees.filter(e => e.salary > avgSalary);
console.log("Above Avg:", aboveAvg);