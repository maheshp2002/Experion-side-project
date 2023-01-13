-- use experion_software-- 
create table address(
	id int,
    address varchar(250),
    name varchar(10) not null,
    pin int not null,
    user_id int
--     constraint fk_user_id foreign key (user_id)
--     references users(id)
--     primary key (id)
);

-- any name can be added in place of PK_Id
alter table address add constraint PK_Id primary key(id); 
alter table address modify column id int auto_increment;
alter table address add constraint fK_key 
foreign key (user_id) references users(id);
alter table address add constraint unique key (name, user_id);

-- drop table address;

insert into address(id, address, name, pin, user_id) value(
1, 'mac', 'mac', 93, 4,
2, 'macan', 'lolan', 68, 2,
3, 'lolan', 'lolanteaddress', 36, 4,
4, 'jigaruthin', 'lmacaolanteaddress', 23, 2
);

select * from address;

select * from address where user_id=(
	select id from users where email='useras1@gmail.com'
);

select * from users where id=(
	select user_id from(
			select user_id, count(id) as total
            from address group by user_id order by total desc limit 1) as temp
	);


