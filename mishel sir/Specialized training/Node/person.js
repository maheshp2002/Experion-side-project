class Person {
    name = null;
    _age = 18;
    get age() {
        return this._age;
    }
    set age(value) {
        if (value >= 18 && value <= 60) {
            this._age = value;
        }
    }

    display() {
        console.log(`${this.name} is ${this.age} years old.`);
    }
}

var p = new Person();
p.name = 'John';
p.age = 250;
console.log(p.age);