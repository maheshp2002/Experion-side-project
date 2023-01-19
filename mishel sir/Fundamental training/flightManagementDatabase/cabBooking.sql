-- create database cabManagement;
use cabManagement;

create table `passenger`(
	`id` int,
    `name` varchar(20),
    `address` varchar(30),
    `email` varchar(20),
    `phone_no` bigint,
    `gender` varchar(20),
    `dob` date
);

-- drop table `passenger`;
-- drop table `driverDetails`;
-- drop table `route`;
-- drop table `booking`;

insert into `passenger`(`id`, `name`, `address`, `email`, `phone_no`, `gender`, `dob`)
values (1, 'mac', 'macs veedu', 'mac@gmail.com', 9876543567, 'male', '2002-09-07'),
(2, 'jibi', 'jibide veedu', 'jibi@gmail.com', 98576765785, 'female', '1996-01-09'),
(3, 'viji', 'viji veedu', 'viji@gmail.com', 77368437820, 'female', '2000-11-07'),
(4, 'jain', 'jain veedu', 'jain@gmail.com', 98579673465, 'male', '2000-05-07');

select * from `passenger`;
desc `passenger`;

alter table `passenger` add constraint PK_Id primary key(id); 
alter table `passenger` modify column id int auto_increment;

create table `driverDetails`(
	`id` int,
    `name` varchar(20),
    `vehicle_no` varchar(20),
    `license_no` int,
    `address` varchar(30),
    `email` varchar(20),
    `gender` varchar(20),
    `phone_no` bigint
);

insert into `driverDetails`(`id`, `name`, `vehicle_no`, `address`, `email`, `gender`, `phone_no`)
values (1, 'mac', 'k9878', 'mac motor', 'macs@gmail.com', 'male', 9876754675),
(2, 'jibi', 'kl897', 'jibi motor', 'jibi@gmail.com', 'female', 98576765785),
(3, 'jain', 'j9878', 'jain motor', 'jain@gmail.com', 'male', 98579673465),
(4, 'viji', 'k9878', 'viji motor', 'viji@gmail.com', 'female', 77368437820);

select * from `driverDetails`;

alter table `driverDetails` add constraint PK_Id primary key(id); 
alter table `driverDetails` modify column id int auto_increment;

create table `route`(
	`id` int,
	`cab_from` varchar(20),
    `cab_to` varchar(20),
    `rate` int
);

insert into `route`(`id`, `cab_from`, `cab_to`, `rate`)
values (1, 'erkm', 'kakkanad', 210),
(2, 'palakkad', 'ottapalam', 300),
(3, 'parassery', 'kongad', 110),
(4, 'shoranur', 'pathiripala', 160);

select * from `route`;

alter table `route` add constraint PK_Id primary key(id); 
alter table `route` modify column id int auto_increment;

create table `booking`(
	`booking_id` int,
    `passenger_id` int,
    `driver_id` int,
    `route_id` int,
    `date_of_trip` date,
    `time_of_trip` time,
    `booking_date` date,
    `booking_time` time
);

insert into `booking`(`booking_id`, `passenger_id`, `driver_id`, `route_id`, `date_of_trip`, `booking_date`, `booking_time`)
values (1, 2, 4, 2, '2023-01-07', '2023-01-12', '11:30'),
(2, 3, 4, 1, '2023-01-09', '2023-01-14', '12:24'),
(3, 3, 1, 3, '2023-01-10', '2023-01-23', '13:32'),
(4, 1, 2, 4, '2023-01-27', '2023-01-13', '07:15');

alter table `booking` add constraint PK_Id primary key(`booking_id`); 
alter table `booking` modify column id int auto_increment;

alter table `booking` add constraint fK_key_dr_id
foreign key (`driver_id`) references `driverDetails`(`id`);

alter table `booking` add constraint fK_key_ps_id 
foreign key (`passenger_id`) references `passenger`(`id`);

alter table `booking` add constraint fK_key_route_id 
foreign key (`route_id`) references `route`(`id`);

select * from `booking`;

