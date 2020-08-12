USE [Concesionarios]
GO

/****** Object:  Table [dbo].[Automoviles]    Script Date: 04/08/2020 20:27:34 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

drop table [dbo].[Automoviles]
go

CREATE TABLE [dbo].[Automoviles](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Dominio] [nchar](10) NULL,
	[IdTipo] [int] NULL,
	[IdMarca] [int] NULL,
	[IdModelo] [int] NULL,
	[Anio] [nchar](10) NULL,
	[Color] [nchar](15) NULL,
	[MotorN] [nchar](20) NULL,
	[ChasisN] [nchar](20) NULL,
	[RegistradoEn] [nchar](30) NULL,
	[Estado] [int] NULL,
	[Precio] [numeric](18,2) NULL,
	[Observaciones] [nchar](200) NULL,
	[Titulo] [bit] NULL,
	[Cedula] [bit] NULL,
	[F08] [bit] NULL,
	[F12] [bit] NULL,
	[Zeta] [bit] NULL,
	[CompraVenta] [bit] NULL,
 CONSTRAINT [PK_Automoviles] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

ALTER TABLE [dbo].[Automoviles]  WITH CHECK ADD  CONSTRAINT [FK_Automoviles_Marcas] FOREIGN KEY([IdMarca])
REFERENCES [dbo].[Marcas] ([Id])
GO

ALTER TABLE [dbo].[Automoviles] CHECK CONSTRAINT [FK_Automoviles_Marcas]
GO

ALTER TABLE [dbo].[Automoviles]  WITH CHECK ADD  CONSTRAINT [FK_Automoviles_Modelos] FOREIGN KEY([IdModelo])
REFERENCES [dbo].[Modelos] ([Id])
GO

ALTER TABLE [dbo].[Automoviles] CHECK CONSTRAINT [FK_Automoviles_Modelos]
GO


