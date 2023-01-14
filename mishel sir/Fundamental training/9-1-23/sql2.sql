create table `students` (
	`id` int primary key auto_increment,
    `register` int unique,
    `name` varchar(20) not null,
    `total_mark` int not null,
    `dob` date not null
);

insert into `students`(`id`, `register`, `name`, `total_mark`, `dob`) value
	(1, 9876, 'macan', 40, '2022-02-10'),
    (2, 8979, 'makkachi', 70, '2022-12-20'),
    (3, 6786, 'makku', 80, '2023-01-13'),
	(4, 1267, 'mahi', 38, '2023-02-03');
    
select * from `students` where `total_mark`<=60;