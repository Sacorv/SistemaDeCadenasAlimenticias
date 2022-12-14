USE [master]
GO
/****** Object:  Database [SistemaCadenasAlimenticias-Parcial2-PW3]    Script Date: 02/11/2022 19:33:14 ******/
CREATE DATABASE [SistemaCadenasAlimenticias-Parcial2-PW3]

GO
CREATE TABLE [dbo].[Cadena](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Razon_social] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_Cadena] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Sucursal]    Script Date: 02/11/2022 19:33:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Sucursal](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Direccion] [nvarchar](50) NOT NULL,
	[Ciudad] [nvarchar](50) NOT NULL,
	[IdCadena] [int] NOT NULL,
 CONSTRAINT [PK_Sucursal] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
ALTER TABLE [dbo].[Sucursal]  WITH CHECK ADD  CONSTRAINT [FK_Sucursal_Cadena] FOREIGN KEY([Id])
REFERENCES [dbo].[Cadena] ([Id])
GO
ALTER TABLE [dbo].[Sucursal] CHECK CONSTRAINT [FK_Sucursal_Cadena]
GO
