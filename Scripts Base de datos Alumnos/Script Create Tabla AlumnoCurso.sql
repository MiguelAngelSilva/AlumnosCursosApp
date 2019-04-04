USE [AlumnosCursosDB]
GO

/****** Object:  Table [dbo].[AlumnoCurso]    Script Date: 3/4/2019 05:41:16 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[AlumnoCurso](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Aprobado] [bit] NOT NULL,
	[EnCurso] [bit] NOT NULL,
	[Alumno_Id] [int] NOT NULL,
	[Curso_Id] [int] NOT NULL,
	[Timestamp] [timestamp] NOT NULL,
 CONSTRAINT [PK_dbo.AlumnoCurso] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[AlumnoCurso]  WITH CHECK ADD  CONSTRAINT [FK_dbo.AlumnoCurso_dbo.Alumno_Alumno_Id] FOREIGN KEY([Alumno_Id])
REFERENCES [dbo].[Alumno] ([Id])
GO

ALTER TABLE [dbo].[AlumnoCurso] CHECK CONSTRAINT [FK_dbo.AlumnoCurso_dbo.Alumno_Alumno_Id]
GO

ALTER TABLE [dbo].[AlumnoCurso]  WITH CHECK ADD  CONSTRAINT [FK_dbo.AlumnoCurso_dbo.Curso_Curso_Id] FOREIGN KEY([Curso_Id])
REFERENCES [dbo].[Curso] ([Id])
GO

ALTER TABLE [dbo].[AlumnoCurso] CHECK CONSTRAINT [FK_dbo.AlumnoCurso_dbo.Curso_Curso_Id]
GO


