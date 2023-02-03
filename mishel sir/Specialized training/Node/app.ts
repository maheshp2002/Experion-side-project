// function greet(message:string): string{
//     return `Hello ${message}`;
// }
// const i:number = 10;

// const msg = greet("mac");
// console.log(msg);

// class Person{
//     constructor(){
//         console.log("Person created");       
//     }
// }

// var p = new Person();

class Person {
    public name: string;
    private _age: number;
    public get age(): number {
        return this._age;
    }
    public set age(value: number) {
        this._age = value;
    }

    public display() {
        console.log(this.name, this.age);
    }
}

let p = new Person();
p.name = "John✅";
p.age = 30;
p.display();

class Person2 {
    constructor(private name:string, private age:number) {

    }
}

let p2 = new Person2("Jibi", 27);
console.log(p2);

function getFullName(data: {firstName:string, lastName:string}){
    console.log(data.firstName + " " + data.lastName);  
}

const Person3 = {
    firstName: "Jibi",
    lastName: "Joseph"
};

getFullName(Person3);

