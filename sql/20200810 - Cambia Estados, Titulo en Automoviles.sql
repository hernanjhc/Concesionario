alter table Automoviles
drop column Estado
go
alter table Automoviles
add Estado int null

alter table Automoviles
drop column Titulo
go
alter table Automoviles
add Titulo varchar(1) null