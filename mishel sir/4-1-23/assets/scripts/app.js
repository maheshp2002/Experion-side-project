// // const http = new XMLHttpRequest();
// // http.onreadystatechange = function(){
//     //     if(this.readyState == 4 && this.status == 200){
//         //         console.log(this.responseText);
// //     }
// // };

// // http.open('GET', 'https://reqres.in/api/users/2');
// // http.send();
// // console.log('COMPLETED');

// // timer

// // function doThisThing(callback){
// //     setTimeout(()=>{
// //         const name = 'Javascript';
// //         callback(name);
// //     }, 5000);
// // }

// // function showResult(res){
//     //     console.log(res);
// // }

// // doThisThing(showResult);
// // console.log('I am done');

// // Promise

// // const p = new Promise((resolve, reject) => {
//     //     const name = 'JavaScript';
//     //     resolve(name);
//     // });
//     // p.then(res=>console.log(res));
    
//     // fetch('https://reqres.in/api/users?page=2')
// // .then(response=> response.json())
// // .then(data=> data.data.forEach(element=>{console.log(element.email);}));

// const tbody = document.querySelector('#target');
// // const search = document.querySelector('search');

// let data = "";

// function searchFunction(e){
//     data = e.target.value;
//     fetchSearch(data);
// }


// // fetch('https://reqres.in/api/users?page=2')
// // .then(response=> response.json())
// // .then(result=>{
// //     const users = result.data;
// //     users.forEach(user=>{
// //         console.log(user);
// //         const row = `
// //         <tr>
// //         <td>${user.id}</td>
// //         <td>
// //         <img src="${user.avatar}" height="50">
// //         </td>
// //         <td>${user.first_name} ${user.last_name}</td>
// //         <td>${user.email}</td>
// //         </tr>`;
// //         tbody.innerHTML += row;
// //     });
// // });

// function fetchSearch(name){
//     let row = ``;
//     tbody.innerHTML = row;
//     fetch('https://reqres.in/api/users?page=2')
//     .then(response=> response.json())
//     .then(result=>{
//         const users = result.data;
//         users.forEach(user=>{
//             // if(`${user.first_name.toUpperCase()} ${user.last_name.toUpperCase()}` == name.toUpperCase()){
//                 // console.log(user.first_name.toUpperCase());
//             if(user.email.startsWith(name)){
//                 row = `
//                 <tr>
//                     <td>${user.id}</td>
//                     <td>
//                      <img src="${user.avatar}" height="50">
//                     </td>
//                     <td>${user.first_name} ${user.last_name}</td>
//                     <td>${user.email}</td>
//                 </tr>`;
//                 tbody.innerHTML += row;
//             }
//         });
//     });
// }
// // Michael Lawson