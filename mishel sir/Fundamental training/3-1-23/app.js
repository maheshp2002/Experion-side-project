const student = {
    name: "Jain",
    age: 22,
    mark1: 80,
    mark2: 10
};

const data = JSON.stringify(student);
console.log(data);

console.log("<-----------------Back to object----------------->");
const dataBack = JSON.parse(data);
console.log(dataBack);

const students = [
    {
        name: "Jain",
        age: 22,
        mark1: 80,
        mark2: 10
    },
    {
        name: "Lokesh",
        age: 23,
        mark1: 70,
        mark2: 40
    }
];

const target = document.getElementById('content');
students.forEach(student=>{
    const row = `<tr>
        <td>${student.name}</td>
        <td>${student.age}</td>
        <td>${student.mark1}</td>
        <td>${student.mark2}</td>
        <td>
            <button onClick="deleteRow()">Delete</button>
        </td>
    </tr>`;
    target.innerHTML += row;
});

function deleteRow(){
    document.querySelectorAll('button').forEach(event=>{
        event.addEventListener('click', (e)=>{
            // console.log(e.target.parentElement.parentElement.children[0].innerHTML);

            let alert = confirm(`Do you want to delete? ${e.target.parentElement.parentElement.children[0].innerHTML}`);
        
            if(alert){
                e.target.parentElement.parentElement.remove();
            }
        });
        // event.target.onclick += console.log(event.target.parentElement);
    });
}