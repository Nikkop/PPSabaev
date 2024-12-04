create database Tehnotair
go

use Tehnotair
go

create table Accounts(
	id int identity(1,1) primary key,
	l varchar(100),
	passw varchar(100),
	rol varchar(30)
)

create table Zakazi(
	id int identity(1,1) primary key,
	name varchar(100),
	opis varchar(500),
)

insert into Accounts values ('1','1','admin'),
('2','2','user') 
go