USE [AlumnosCursosDB]
GO

/****** Object:  Table [dbo].[Alumno]    Script Date: 3/4/2019 05:40:36 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Alumno](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [nvarchar](max) NOT NULL,
	[Apellido] [nvarchar](max) NOT NULL,
	[Dni] [nvarchar](max) NOT NULL,
	[Timestamp] [timestamp] NOT NULL,
 CONSTRAINT [PK_dbo.Alumno] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO


