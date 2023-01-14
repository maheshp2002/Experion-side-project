console.log("Hello world");

var java = "java ";
var  python = " python";
console.log(java, "  ",  python);
console.log(typeof java);
console.log( python[1]);
// when calling function use () and when calling a square icon will  be shown in the name sujjestion
console.log(java[java.length - 1]);
var res =  python.toUpperCase();
console.log(res);

var message = "   love of  python   ";
console.log(message.trim()); // trimStart(), trimeEnd()

console.log(message.split(" ")); 
console.log(message.trim().split(" ")); 

var res3 = message.replaceAll(" ", "😍");
console.log(res3);

var res5 = message
.toUpperCase()
.trim()
.replaceAll(" ", "😍");
console.log(res5);

const i = 5;
// let is block whereas var is global
for (let i = 0; i < 5; i++){
    console.log("Inside for loop:", i);
}
console.log("After for loop:", i);

const language = "js";
console.log(language);

const n1 = 4;
const n2 = 5;

const result = n1 + `+` + n2 + `=` + (n1 + n2);
const result1 = `${n1} + ${n2} = ${n1 + n2}`;

console.log(result);
console.log(result1);

var firstString = " python🐵";
var lastString = "java ";

var result3 = firstString + " " + lastString;
var result4 = firstString.concat(" ", lastString);
var result5 = `${firstString} ${lastString}`;

console.log(result3);
console.log(result4);
console.log(result5);


