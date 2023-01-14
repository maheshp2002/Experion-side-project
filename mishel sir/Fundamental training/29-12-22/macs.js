function greet() {
    console.log("Hello Macusubhi🖐");
}

greet();

function add(Mac, Devil, symbol) {
    return Mac + Devil + symbol;
}

const result = add("Mac", "Devil", "😈");

console.log(result);

function convertCasing(value){
    return value.toUpperCase();
}

const res = convertCasing('Hello Mac');


console.log(res.toLowerCase());

// Different ways to write a function 

// Normal function
function fun(value){
    return value[0];
}

// anonymous function

const fun2 = function (value){
    return value[0]; 
};

// lamda / Arrow function

const fun3 = (value) => {
    return value[0];
};

// other method of lamda.
// if there is only 1 parameter, then remove bracket. If there is only 1 return then remove return and paranthesis. 

const fun4 = value => value[0];

console.log(fun('Hello1'));
console.log(fun2('Hello2'));
console.log(fun3('Hello3'));
console.log(fun4('Hello4'));

const numbers = [1, 2, 3, 4, 5, 6];
numbers.fill(10);
console.log(numbers);

if (numbers.includes(10)){
    console.log('Array contains ten');
}

console.log(numbers.toString());
console.log(numbers.join('🤩'));