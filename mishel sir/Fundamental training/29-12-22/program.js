let firstArray = [1,2,3, 'Four'];
let secondArray = [1, 6, 5];
// firstArray[5] = 5; // not a good method
firstArray.push(5); // it will modify the existing array
firstArray.push(5, 6); // add mutiple item
// numbers.push(no); // add array items, here bracket is there, for solving that we use spread operator
firstArray.push(...secondArray); // ... is spread operator
const newArray = firstArray.concat(secondArray); // used instead of push, we get result in new array
console.log(newArray);
console.log(firstArray);

