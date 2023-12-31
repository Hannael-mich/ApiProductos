USE [Generacion23]
GO
/****** Object:  Table [dbo].[Productos]    Script Date: 25/12/2023 06:57:01 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Productos](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [varchar](50) NULL,
	[FechaCaducidad] [date] NULL,
	[Marcaid] [int] NULL,
	[Departamentoid] [int] NULL,
 CONSTRAINT [PK_Productos] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Productos] ON 

INSERT [dbo].[Productos] ([id], [Nombre], [FechaCaducidad], [Marcaid], [Departamentoid]) VALUES (1009, N'Teclado', CAST(N'2050-06-02' AS Date), 1, 1)
INSERT [dbo].[Productos] ([id], [Nombre], [FechaCaducidad], [Marcaid], [Departamentoid]) VALUES (2006, N'Monito', CAST(N'2029-02-02' AS Date), 1, 1)
INSERT [dbo].[Productos] ([id], [Nombre], [FechaCaducidad], [Marcaid], [Departamentoid]) VALUES (2014, N'Galletas', CAST(N'2024-06-02' AS Date), 2, 2)
INSERT [dbo].[Productos] ([id], [Nombre], [FechaCaducidad], [Marcaid], [Departamentoid]) VALUES (2015, N'Galletas', CAST(N'2024-01-01' AS Date), 3, 2)
INSERT [dbo].[Productos] ([id], [Nombre], [FechaCaducidad], [Marcaid], [Departamentoid]) VALUES (2018, N'mouse', CAST(N'2024-01-01' AS Date), 3, 3)
INSERT [dbo].[Productos] ([id], [Nombre], [FechaCaducidad], [Marcaid], [Departamentoid]) VALUES (2019, N'Oblea', CAST(N'2040-01-01' AS Date), 3, 2)
INSERT [dbo].[Productos] ([id], [Nombre], [FechaCaducidad], [Marcaid], [Departamentoid]) VALUES (2020, N'Chocolate', CAST(N'2024-06-02' AS Date), 2, 2)
SET IDENTITY_INSERT [dbo].[Productos] OFF
GO
ALTER TABLE [dbo].[Productos]  WITH CHECK ADD  CONSTRAINT [FK_Productos_Departamentos] FOREIGN KEY([Departamentoid])
REFERENCES [dbo].[Departamentos] ([idD])
GO
ALTER TABLE [dbo].[Productos] CHECK CONSTRAINT [FK_Productos_Departamentos]
GO
ALTER TABLE [dbo].[Productos]  WITH CHECK ADD  CONSTRAINT [FK_Productos_Marcas] FOREIGN KEY([Marcaid])
REFERENCES [dbo].[Marcas] ([idM])
GO
ALTER TABLE [dbo].[Productos] CHECK CONSTRAINT [FK_Productos_Marcas]
GO
