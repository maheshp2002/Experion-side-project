create table userDetails(
	id int,
    address varchar(40) not null,
    email varchar(50) not null,
    user_id int
);

create table userEmail(
	id int,
    email varchar(50) not null,
    user_id int
);

alter table userEmail add constraint PK_Id primary key(id); 
alter table userEmail modify column id int auto_increment;
alter table userEmail add constraint fK_key 
foreign key (user_id) references userDetails(id);
alter table userEmail add constraint unique key (name, user_id);

