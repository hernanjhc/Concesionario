USE [Concesionarios]
GO

/****** Object:  Table [dbo].[Automoviles]    Script Date: 06/08/2020 22:20:34 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

DROP TABLE [dbo].[Tipos]
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

insert into Tipos (Tipo) values ('Sedan')
insert into Tipos (Tipo) values ('5P')
insert into Tipos (Tipo) values ('PickUp')
insert into Tipos (Tipo) values ('Camión')
insert into Tipos (Tipo) values ('SUV')
insert into Tipos (Tipo) values ('Furgón')