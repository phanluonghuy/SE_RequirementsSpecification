create database 10percent
GO
use 10percent
GO
create table Destination
(
	name nvarchar(50),
	cost float
)
GO
insert into Destination values (N'Hà Nội', 300000)
insert into Destination values (N'TP Hồ Chí Minh', 200000)
insert into Destination values (N'Nha Trang', 100000)
insert into Destination values (N'Bảo Lộc', 100000)


select * from Destination

