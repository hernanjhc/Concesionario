use Concesionarios

create table Marcas(
	MarcaId int not	null primary key,
	Marca	varchar(50)	null
)

create table Modelos(
	ModeloId 	int not null primary key,
	MarcaId 	int not null,
	Modelo		varchar(50)	not	null
)

ALTER TABLE [dbo].[Modelos]  WITH CHECK ADD  CONSTRAINT [FK_Modelos_Marcas] FOREIGN KEY([MarcaId])
REFERENCES [dbo].[Marcas] ([MarcaId])
ON UPDATE CASCADE
GO

ALTER TABLE [dbo].[Modelos] CHECK CONSTRAINT [FK_Modelos_Marcas]
GO
