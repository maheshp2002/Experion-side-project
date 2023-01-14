console.log('<----------------------------forEach---------------------------->');
const language = ['C', 'C++', 'Java', 'Python'];
language.forEach((lang, index) => {
    console.log(index, lang);
});

console.log('<----------------------------Object---------------------------->');

const person = {
    name: 'Macusubhi',
    age: 20,
    email: null
};

person.name = 'Maccuchi Macusubhi';
person.email = 'macantekada@gmail.com'; // not a good method
console.log(person);

console.log(person.age);
console.log(person['name']);

console.log('<----------------------------Complex object---------------------------->');

const person1 = {
    name: 'Macusubhi',
    age: 20,
    experience: [
        {
            company: 'Company ABC',
            years: 2
        },
        {
            company: 'Company XYZ',
            years: 3
        }
    ]
};

console.log(person1.experience[0].company);
person1.experience.forEach(exp=> console.log(exp.company));

console.log('<----------------------------Matrix---------------------------->');

const m1 = [
    [1, 2],
    [3, 4]
];

console.log(m1);

// console.log('<----------------------------TimeOut---------------------------->');

// setTimeout(() => {
//     console.log('code worked timeout');
// }, 5000);

// console.log('<----------------------------Interval---------------------------->');

// setInterval(() => {
//     console.log('code worked interval');
// }, 5000);

const student = {
    name: 'Jane',
    mark1: 40,
    mark2: 50,
    total: function(){
        const extraMark = 5;
        console.log(this.mark1 + this.mark2 + extraMark);
    }
};

const marks = {
    mark1: 40,
    mark2: 50
};

console.log('<----------------------------Function inside object---------------------------->');

student.total();

console.log('<----------------------------Copy an object---------------------------->');

const copy = Object.assign({age: 15}, student, marks);
copy.name = 'New Name';
console.log(student);
console.log(copy);

const student1 = {
    fullName: 'jibs',
    mark1: 40,
    mark2: 50
};

const {fullName, mark1} = student1;
console.log(fullName, mark1);

const keys = Object.keys(student);
console.log(keys);

keys.forEach(key=>{
    console.log(student[key]);
});