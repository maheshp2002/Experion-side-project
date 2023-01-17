function calculateAge(event){

    let diffDays;

    event.preventDefault();

    let userage = document.getElementById('dob').value;

    // console.log(userage);

    let dob = new Date(`${userage} GMT`);

    console.log(dob);

    let dateToday = new Date();

    let difference = dateToday.getTime() - dob.getTime();

    diffDays = Math.ceil(difference / (1000 * 3600));

    // var  ageDate = new Date(difference);

    // var calculatedAge=   Math.abs(ageDate.getUTCFullYear() - 1970);

    console.log(diffDays);

    diffDays2 = Math.ceil(difference / (1000 * 3600 * 24));

    console.log(diffDays2);

    diffWeek = Math.ceil(difference / (1000 * 3600 * 24 * 7));

    console.log(diffWeek);

    diffMonth = Math.ceil(difference / (1000 * 3600 * 24 * 7 * ));

    console.log(diffMonth);



   

}