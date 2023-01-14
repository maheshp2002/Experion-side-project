// console.log(date.getHours());
// function getHour(){
//     const date = new Date();
//     if(date)
// }
let time = document.getElementById("flight");
let fare = document.getElementById("fare");

function getTime(){
    let hour = time.value.split(":")[0];
    let rate = fare.value;
    let temp;
    if(hour >= 6 && hour < 9){
        temp = rate * 10 / 100;
        rate = parseInt(rate) + temp;
        console.log(rate);
    } else if(hour >= 9 && hour < 17){
        temp = rate * 20 / 100;
        rate = parseInt(rate) + temp;
        console.log(rate);
    } else if(hour >= 17 && hour < 23){
        temp = rate * 7 / 100;   
        rate = parseInt(rate) + temp;
        console.log(rate);
    } else if(hour >= 23 || hour >= 0 && hour < 6){
        temp = rate * 5 / 100;
        rate = parseInt(rate) + temp;
        console.log(rate);
    }
}

