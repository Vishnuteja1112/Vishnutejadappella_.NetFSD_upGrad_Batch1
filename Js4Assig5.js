let numbers = [10, 20, 30, 10, 40, 20, 50, 60, 60];

// 1. Remove duplicates
let unique = [...new Set(numbers)];
console.log("Unique:", unique);

// 2. Second largest
let sorted = [...unique].sort((a, b) => b - a);
console.log("Second Largest:", sorted[1]);

// 3. Frequency of each element
let freq = numbers.reduce((acc, n) => {
  acc[n] = (acc[n] || 0) + 1;
  return acc;
}, {});
console.log("Frequency:", freq);

// 4. First non-repeating number
let firstUnique = numbers.find(n => freq[n] === 1);
console.log("First Non-Repeating:", firstUnique);

// 5. Rotate array by 2
let rotated = numbers.slice(2).concat(numbers.slice(0, 2));
console.log("Rotated:", rotated);

// 6. Flatten nested array
let nested = [1, 2, [3, 4, [5]]];
let flat = nested.flat(Infinity);
console.log("Flattened:", flat);

// 7. Missing number
let arr = [1, 2, 3, 5, 6];
let missing = arr.find((n, i) => n !== i + 1);
console.log("Missing:", missing - 1);