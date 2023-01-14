use experion_software;

select * from users;
select * from address;

select users.id, users.name, email, address, pin from users
inner join address
on users.id = address.user_id;

create view jain as 
select * from address where address='mac';
select * from jain;