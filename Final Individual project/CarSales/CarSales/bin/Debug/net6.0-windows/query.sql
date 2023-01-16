select *
from Cars

create table Cars (
CarId int primary key identity(1, 1),
Brand varchar(55) not null,
Model varchar(55) not null,
YearProduced int not null,
BasePrice float not null,
Sold bit
)

drop table Cars

insert into Cars(Brand, Model, YearProduced, BasePrice)
values('BMW', 'X5', 2020, 20000)


delete from Cars