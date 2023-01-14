// asc sort

// const array = [1, 2, 5, 3, 9, 4, 7, 6];
// // const sortedArray = [];

// for (let i = 0; i < array.length; i++) {
    
//     for (let j = i + 1; j < array.length; j++) {
//         if(array[i] > array[j]) {
//             const temp = array[i];
//             array[i] = array[j];
//             array[j] = temp;
//         }
//     }
// }

// console.log(array);

//.....................................................................
// desc sort
const array = [1, 2, 5, 3, 9, 4, 7, 6];

for (let i = 0; i < array.length; i++) {    
    for (let j = i + 1; j < array.length; j++) {
        if(array[i] < array[j]) {
            const temp = array[i];
            array[i] = array[j];
            array[j] = temp;
        }
    }
}

console.log(array);