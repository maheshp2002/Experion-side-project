const array = [1, 2, 8, 4, 5, 6, 7];
const result = document.getElementById('result');
let data = 0;

function inputArray(e){
    // result.innerText = e.target.value;
    data = e.target.value;
    // console.log()
}

function searchArray(){
    array.forEach( function searchFun(element, index) {
        if(element == data){
            result.innerText = `Search result found at index ❝ ${index} ❞`;
        } 
        // else {
        //     result.innerText = `Sorry no result found! 🙁`;
        // }
    });
}