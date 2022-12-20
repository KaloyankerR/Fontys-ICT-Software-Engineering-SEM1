--create table Car (
--	CarId int primary key,
--	Brand varchar(50),
--	Model varchar(50),
--	YearProduced int,
--	Sold bit,
--	BasePrice float
--);

--create table Customer (
--	CustomerId int primary key,
--	FirstName varchar(50),
--	LastName varchar(50),
--	PhoneNo int,
--	Email varchar(50),
--	CustomerAddress varchar(50),
--	Zipcode varchar(50),
--	City varchar (25),
--	CarId int foreign key references Car(CarId) 
--);

--create table Sales (
--	CarId int foreign key references Car(CarId),
--	CustomerId int foreign key references Customer(CustomerId),
--	PriceSold float,
--	PurchaseDate date
--);

select *
from Sales

