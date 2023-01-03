let posTop = 0;
let posBottom = 0;
let posLeft = 0;
let posRight = 0;

// const box = document.getElementById('box');

// function boxPos(){
    document.addEventListener('keydown', (event) => {
        if(event.key == 'ArrowUp') {
            posTop = posTop + 10;
            document.getElementById('box').style.top = posTop;
        } else {
            posBottom = posBottom + 10;
            document.getElementById('box').style.bottom = posBottom;     
        }
        
    });
