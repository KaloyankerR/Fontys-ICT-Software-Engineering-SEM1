create table Customers (
	customerId int primary key identity(1, 1),
	firstName varchar(30) not null,
	lastName varchar(30) not null,
	phoneNumber int not null,
	email varchar(55),
	customerAddress varchar(55) not null,
	zipcode varchar(15),
	city varchar(25) not null
)

Insert into Customers(firstName, lastName, phoneNumber, customerAddress, city) 
values('', '', 359, '', '')