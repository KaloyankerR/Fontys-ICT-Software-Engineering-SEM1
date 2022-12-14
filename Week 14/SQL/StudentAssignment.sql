select *
from ProjectGroup

create table Members (
	studentNumber int NOT NULL PRIMARY KEY IDENTITY(1, 1),
	name varchar(55) NOT NULL,
	projectGroup varchar(55) NOT NULL FOREIGN KEY REFERENCES ProjectGroup(name)
);

create table ProjectGroup (
	-- projectGroupNumber int NOT NULL PRIMARY KEY IDENTITY(1, 1),
	name varchar(55) NOT NULL PRIMARY KEY
);

-- drop table Members
-- drop table ProjectGroup

-- insert into ProjectGroup(name) values('Team02')
-- insert into Members(name, projectGroup) values('Kalo', 'Team02')

-- delete from Members where studentNumber=1

select *
from Members 
where projectGroup = 'Team02'
