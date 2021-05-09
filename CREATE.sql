CREATE TABLE dbo.Bars(
	Id int IDENTITY(1,1) primary key clustered,
	BarId int NOT NULL
);
insert into dbo.Bars(BarId) values(17);
--drop table dbo.Bars;