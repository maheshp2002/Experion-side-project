create database if not exists experion_software;
create table `users`(
	`id` int primary key auto_increment,
	`name` varchar(50) not null,
    `email` varchar(50) not null unique,
    `age` int not null default 18 check(age >= 18),
    `country` varchar(10) not null default 'IN'
);

desc `users`;

insert into `users` (id, `name`, `email`, `age`, `country`) values
(4, 'mac', 'useras1@gmail.com', 22, 'US'),
(2, '', 'useasar1@gmail.com', 22, 'US');

select * from `users`;

select * from users limit 2;

select * from users limit 2 offset 2;