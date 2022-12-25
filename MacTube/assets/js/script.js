// var bars = document.getElementById('bars');

// document.getElementById('bars').onclick = displayNavbar();

var nav = false;

function displayNavbar() {
    if(nav == true) {
        nav = false;
        document.getElementById('isNav').style.display = 'none';
    } else {
        nav = true;
        document.getElementById('isNav').style.display = 'block';
    }
}

var result = false;

function displayResult() {
    if(nav == true) {
        nav = false;
        document.getElementById('isResult').style.display = 'none';
    } else {
        nav = true;
        document.getElementById('isResult').style.display = 'block';
    }
}
