USE [SistemaCadenasAlimenticias-Parcial2-PW3]
GO
SET IDENTITY_INSERT [dbo].[Cadena] ON 

GO
INSERT [dbo].[Cadena] ([Id], [Razon_social]) VALUES (1, N'Burger King')
GO
INSERT [dbo].[Cadena] ([Id], [Razon_social]) VALUES (2, N'SubWay')
GO
SET IDENTITY_INSERT [dbo].[Cadena] OFF
GO
SET IDENTITY_INSERT [dbo].[Sucursal] ON 

GO
INSERT [dbo].[Sucursal] ([Id], [Direccion], [Ciudad], [IdCadena]) VALUES (2, N'Rivadavia 5300', N'Morón', 1)
GO
SET IDENTITY_INSERT [dbo].[Sucursal] OFF
GO
