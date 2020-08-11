USE [Concesionarios]
GO

/****** Object:  Table [dbo].[Automoviles]    Script Date: 06/08/2020 22:20:34 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Tipos](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Tipo] [nchar](50) NULL,
 CONSTRAINT [PK_Tipos] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

ALTER TABLE [dbo].[Automoviles]  WITH CHECK ADD  CONSTRAINT [FK_Automoviles_Tipos] FOREIGN KEY([IdTipo])
REFERENCES [dbo].[Tipos] ([Id])
GO

ALTER TABLE [dbo].[Automoviles] CHECK CONSTRAINT [FK_Automoviles_Tipos]
GO

insert into Tipos (Id, Tipo) values (1,"Sedan")
insert into Tipos (Id, Tipo) values (2,"5P")
insert into Tipos (Id, Tipo) values (3,"PickUp")
insert into Tipos (Id, Tipo) values (4,"Camión")
insert into Tipos (Id, Tipo) values (5,"SUV")
insert into Tipos (Id, Tipo) values (6,"Furgón")