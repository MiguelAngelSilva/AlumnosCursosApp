USE [TecsoLoggerDB]
GO

/****** Object:  Table [dbo].[Log]    Script Date: 3/4/2019 05:42:44 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Log](
	[IdLog] [int] IDENTITY(1,1) NOT NULL,
	[TipoMensajeLog] [nvarchar](50) NULL,
	[Fecha] [nvarchar](50) NULL,
	[Mensaje] [nvarchar](500) NULL,
 CONSTRAINT [PK_Log] PRIMARY KEY CLUSTERED 
(
	[IdLog] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO


