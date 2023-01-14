// const e = document.getElementById('p1');
// e.style.color = 'blue';
// e.style.fontSize = '25px';
// e.style.fontWeight = 'bolder';
// let bs = false;

// function handleClick(e){
//     // console.log('macs');
//     // alert('button click');
//     if (bs == false) {
//         e.target.innerText = 'Clicked';
//         e.target.style.color = 'green';
//         bs = true;
//     } else {
//         e.target.innerText = 'Click me';
//         e.target.style.color = 'black';
//         bs = false;      
//     }
// }

    // var para = document.getElementsByTagName('p');
    // for (let i = 0; i < para.length; i++) {
    //     const element = para[i];
    //     element.innerText = 'Next text';
    // }
// document.getElementById('p1').remove();

// document.getElementById('p1').removeAttribute('style');

document.getElementById('test').setAttribute('checked', 'checked');
document.getElementById('email').setAttribute('value', 'macantekada@gmail.com');
let res = document.getElementById('email').getAttribute('type');
document.write(res);

const points = [60, 10, 30, 20];

document.write(points.sort());

