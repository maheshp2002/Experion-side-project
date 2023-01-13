// let names = ['names lol', 'maca mac', 'vicky', 'lola', 'maca mac'];

let names = [];

let searchInput = document.getElementById('search');
let result = document.getElementById('result');

function getName(e){
    e.preventDefault();
    // let input = document.form.name.value;
    if(names.length < 10){
        names.push(document.form.name.value);
        console.log(names);
    } else {
        alert("Limit reached")
    }
};

function sort(){
        for (let i = 0; i < names.length; i++) {
            for (let j = i + 1; j < names.length; j++) {        
                if (names[j] < names[i]) {    
                    let temp = names[i];
                    names[i] = names[j];
                    names[j] = temp;        
                }
            }
        }
        console.log(names);
        result.innerText = names.join(`<br>`);
}

function reverseOrder(){
    let tempData = [];
    for(i = 0; i < names.length; i++){
        tempdata.unshift(names[i]);
    }
    console.log(tempData);
    result.innerText = tempData.join(`<br>`);

}

function search(){
    for(let i = 0; i < names.length; i++){
        if(element.toLowerCase().startsWith(searchInput.value.toLowerCase())){
            result.innerText = 'Search Found';
        } else {
            result.innerText = 'No search Found';
        }
    }
}

function nameLength(){
    let tempData = [];
    for(let i=0; i< names.length; i++){
        tempData.push(names[i] + ' ' + names[i].length);
    }
    result.innerText = tempData;
}

function split(){
    let tempData = [];
    names.forEach(element => {
        tempData.push(element.split(" "));
    });
    console.log(tempData);
    result.innerText = tempData;
}

function duplicate(){
    let tempData = [];
    for (let i = 0; i < names.length; i++) {
        for (let j = i + 1; j < names.length; j++) {        
            if (names[i] == names[j]) {    
                tempData.push(names[i]);
            }
        }
    }
    result.innerText = tempData;
    console.log(tempData);
}
