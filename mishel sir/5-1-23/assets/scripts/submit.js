function handleSubmit(e){
    e.preventDefault();
    console.log(e);
    // const email = document.forms[login][email].value;
    // const email = document.forms.login.email.value;
    // const password = document.forms.login.password.value;
    // console.log(email, '\n', password);

    const email = document.forms.login.email;
    const age = document.forms.login.age;
    const password = document.forms.login.password;

    const emailValue = email.value;
    const ageValue = age.value;
    const passwordValue = password.value;

// first method.
    // if(passwordValue.length < 6){
    //     password.style.border = "1px solid red";
    //     password.nextElementSibling.classList.remove('d-none');
    // } if(emailValue.length < 6){
    //     email.style.border = "1px solid red";
    //     email.nextElementSibling.classList.remove('d-none');
    // } 
    // if(passwordValue.length >= 6 && emailValue.length >= 6) {
    //     alert('Login successfull');
    //     email.style.border = "1px solid grey";
    //     password.style.border = "1px solid grey";
    //     email.nextElementSibling.classList.add('d-none');
    //     password.nextElementSibling.classList.add('d-none');
    // }
    
    // console.log(password);

// second method.

    const passwordErrorDisplay = password.nextElementSibling;
    const emailErrorDisplay = email.nextElementSibling;
    const ageErrorDisplay = age.nextElementSibling;
    
    if(emailValue.length < 6){
        email.style.border = "1px solid red";
        emailErrorDisplay.classList.remove('d-none');
        emailErrorDisplay.innerHTML += '<li>email must be at least 6 characters.</li>';
    } 
    if(emailValue.includes('')){
        email.style.border = "1px solid red";
        emailErrorDisplay.classList.remove('d-none');
        emailErrorDisplay.innerHTML += '<li>email must not contain whitespace.</li>';
    } 
    if(passwordValue.length < 6){
        password.style.border = "1px solid red";
        passwordErrorDisplay.classList.remove('d-none');
        passwordErrorDisplay.innerHTML += '<li>Password must be at least 6 characters.</li>';
    } 
    if(passwordValue.includes('')){
        password.style.border = "1px solid red";
        passwordErrorDisplay.classList.remove('d-none');
        passwordErrorDisplay.innerHTML += '<li>Password must not contain whitespace.</li>';
    } 

    if(ageValue >= 100){
        age.style.border = "1px solid red";
        ageErrorDisplay.classList.remove('d-none');
        ageErrorDisplay.innerHTML += '<li>Age should be below 100.</li>';
    } 
    if(ageValue < 18){
        age.style.border = "1px solid red";
        ageErrorDisplay.classList.remove('d-none');
        ageErrorDisplay.innerHTML += '<li>Age should be above 18.</li>';
    } 
    if(ageValue.includes('')){
        age.style.border = "1px solid red";
        ageErrorDisplay.classList.remove('d-none');
    } 
}

// // third method.
// const fromData = {
//     email: {
//         fields: document.forms.login.email,
//         error: []
//     },
//     password: {
//         fields: document.forms.login.password,
//         error: []
//     },
//     isInvalid: function(){
//         return (this.errors.length)
//     }
// }