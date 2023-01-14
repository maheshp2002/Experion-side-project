create database flightManagement;
use flightManagement;

create table `passenger`(
	`id` int,
    `name` varchar(20),
    `user_name` varchar(20),
    `address` varchar(30),
    `email` varchar(20),
    `password` varchar(20),
    `phone_no` int
);

alter table `passenger` add constraint PK_Id primary key(id); 
alter table `passenger` modify column id int auto_increment;

create table `booking`(
	`ticket_no` int,
    `date_of_booking` date,
    `date_of_travel` date,
    `flight_schedule_id` int,
	`flight_from` int,
    `flight_to` int,
    `flight_time` time,
    `boarding_time`time,
    `seat` int,
    `passenger_id` int    
);

alter table `booking` add constraint PK_Id primary key(ticket_no); 
alter table `booking` modify column ticket_no int auto_increment;
alter table `booking` add constraint fK_key_booking 
foreign key (`flight_schedule_id`) references `schedule`(`id`);
alter table `booking` add constraint fK_key_ps_id 
foreign key (`passenger_id`) references `passenger`(`id`);

create table `flight`(
	`id` int,
    `flight_name` varchar(20),
    `description` varchar(20),
    `capacity` varchar(20)
);

alter table `flight` add constraint PK_Id primary key(id); 
alter table `flight` modify column id int auto_increment;

-- schedule
 
create table `schedule`(
	`id` int,
	`flight_from` varchar(20),
    `flight_to` varchar(20),
    `date` date,
    `time` time,
    `cost` int,
    `flight_no` int
);

alter table `schedule` add constraint PK_Id primary key(id); 
alter table `schedule` modify column id int auto_increment;
alter table `schedule` add constraint fK_key 
foreign key (`flight_no`) references `flight`(`id`);