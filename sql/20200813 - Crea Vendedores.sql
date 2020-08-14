USE [Concesionarios]
GO

/****** Object:  Table [dbo].[Vendedores]    Script Date: 13/08/2020 16:52:02 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Vendedores](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[RazonSocial] [nchar](50) NULL,
	[Dni] [nchar](13) NULL,
	[Direccion] [nchar](60) NULL,
	[Localidad] [nchar](30) NULL,
	[Telefono] [nchar](16) NULL,
	[Celular] [nchar](16) NULL,
	[Email] [nchar](40) NULL,
	[Observaciones] [nchar](200) NULL,
 CONSTRAINT [PK_Vendedores] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

