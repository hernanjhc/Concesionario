use Concesionarios

create table Marcas(
	Id int not	null primary key,
	Marca	varchar(50)	null
)

create table Modelos(
	Id 	int not null primary key,
	IdMarca 	int not null,
	Modelo		varchar(50)	not	null
)

ALTER TABLE [dbo].[Modelos]  WITH CHECK ADD  CONSTRAINT [FK_Modelos_Marcas] FOREIGN KEY([IdMarca])
REFERENCES [dbo].[Marcas] ([Id])
ON UPDATE CASCADE
GO

ALTER TABLE [dbo].[Modelos] CHECK CONSTRAINT [FK_Modelos_Marcas]
GO