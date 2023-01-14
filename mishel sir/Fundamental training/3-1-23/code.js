function execute(){
    document.getElementById('input').style.borderColor = 'red';
}

const target1 = document.getElementById('input');

function selectTextBox() {
        target1.focus();
    }
const result = document.getElementById('result');

function getValue(e) {
    result.innerText = e.target.value;
}

const btns = document.getElementById('button');

function changeSlider(e){
    btns.style.width = `${e.target.value}vh`;
    btns.style.borderRadius = `${e.target.value}px`;

}

const buttons = document.querySelectorAll('div .btn');
const buttons2 = document.querySelectorAll('.macs');
buttons.forEach(btn=>{
    btn.style.backgroundColor = 'teal';
});
buttons2.forEach(btn=>{
    btn.style.backgroundColor = 'aqua';
});

document.querySelectorAll('.buttonListener').forEach(btn=>{
    btn.addEventListener('click', (e)=>{
        e.target.innerText = 'Clicked';
    });
});

var tag = document.createElement('h1');
tag.innerHTML = 'H1';
document.body.appendChild(tag);

const targ = document.querySelector('#target');
console.log(targ.parentElement);
