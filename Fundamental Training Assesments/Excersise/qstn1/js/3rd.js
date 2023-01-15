let num = document.getElementById("num");
let array = [];

function inputData(e){
    e.preventDefault();
    array.push(document.form.number.value);
    console.log(array);
}

function numberHandle(){
    for (let i = 0; i < array.length; i++) {
        for (let j = 0; i + 1 < array.length; j++) {
            if(array[i]<array[j]){
                let temp = array[i];
                array[i] = array[j];
                array[j] = temp;
            } 
        }        
    }
};