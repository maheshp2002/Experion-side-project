const tbody = document.querySelector('#target');
let searchBy = 1;

// calls this function when a searchBy is selected
function changeSearchBy(number){
    searchBy = number;
    searchBy == 1
    ? document.getElementById('dropdownMenuButton').innerText = "SearchBy name"
    : document.getElementById('dropdownMenuButton').innerText = "SearchBy email";
}

fetchDefault();

// default fetch, if no search is made
function fetchDefault() {
    fetch('https://reqres.in/api/users')
    .then(response=> response.json())
    .then(result=>{
        const users = result.data;
        users.forEach(user=>{
            console.log(user);
            const row = `
            <tr>
            <td>${user.id}</td>
            <td>
            <img src="${user.avatar}" height="50">
            </td>
            <td>${user.first_name} ${user.last_name}</td>
            <td>${user.email}</td>
            </tr>`;
            tbody.innerHTML += row;
        });
    });
}

function errorFunction(){
    const row = `
    <tr>
        <td colspan="4">No result found</td>
    </tr>
    `;
    tbody.innerHTML += row;
}

// fetch data if a search is made
function searchFunction(e) {
    const searchKey = e.target.value;
    if (searchKey) {
        let row = ``;
        tbody.innerHTML = row;
        // if search result is a name
        if(searchBy == 1){
            fetch('https://reqres.in/api/users')
            .then(response => response.json())
            .then(result => {
                const users = result.data;
                users.forEach(user => {
                    const name = `${user.first_name.toLowerCase()} ${user.last_name.toLowerCase()}`;
                    if (name.startsWith(searchKey.toLowerCase())) {
                        row = `
                        <tr>
                            <td>${user.id}</td>
                            <td>
                                <img src="${user.avatar}" height="50">
                            </td>
                            <td>${user.first_name} ${user.last_name}</td>
                            <td>${user.email}</td>
                        </tr>
                        `;
                        tbody.innerHTML += row;
                    }
                });
            }).catch(error=> {
                errorFunction();
                console.log(error);
            });
        } else {
            // if search result is a email
            fetch('https://reqres.in/api/users')
            .then(response => response.json())
            .then(result => {
                const users = result.data;
                users.forEach(user => {
                    if (user.email.startsWith(searchKey)) {
                        row = `
                        <tr>
                            <td>${user.id}</td>
                            <td>
                                <img src="${user.avatar}" height="50">
                            </td>
                            <td>${user.first_name} ${user.last_name}</td>
                            <td>${user.email}</td>
                        </tr>
                        `;
                        tbody.innerHTML += row;
                    }
                });
            }).catch(error=> {
                errorFunction();
                console.log(error);
            });
        }
    } else {
        fetchDefault();
    }
}