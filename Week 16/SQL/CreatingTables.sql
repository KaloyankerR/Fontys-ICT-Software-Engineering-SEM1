-- Creating Car table
--create table Car (
--	CarId int primary key identity(1, 1),
--	Brand varchar(50) not null,
--	Model varchar(50) not null,
--	YearProduced int not null,
--	BasePrice float not null,
--	Sold bit
--);

-- Creating Customer table
--create table Customer(
--	CustomerId int primary key identity(1, 1),
--	Name varchar(80) not null,
--	PhoneNo int not null,
--	Email varchar(50),
--	CustomerAddress varchar(50) not null,
--	ZipcodeAndCity varchar(50) not null 
--);

--create table Sales (
--	CarId int foreign key references Car(CarId),
--	CustomerId int foreign key references Customer(CustomerId),
--	PriceSold float,
--	PurchaseDate date
--);

-- Inserting into Car table
-- insert into Car(Brand, Model, YearProduced, BasePrice)
-- values('marka', 'model', 2003, 25739)

-- Inserting into Customer table
--insert into Customer(Name, PhoneNo, Email, CustomerAddress, ZipcodeAndCity)
--values('Kaloyan Kulov', 359, 'email.com', 'Boschdijk', '1421 Sofia')

--select *
--from Customer

--delete from Car
--where CarId = 1	

--drop table Sales
--drop table Customer
--drop table Car

