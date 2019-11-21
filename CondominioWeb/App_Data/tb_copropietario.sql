USE [Credito]
GO

/****** Object:  Table [dbo].[copropietario]    Script Date: 11/21/2019 16:54:22 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

SET ANSI_PADDING ON
GO

CREATE TABLE [dbo].[copropietario](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[rut] [varchar](9) NULL,
	[dv] [varchar](1) NULL,
	[nombre] [varchar](50) NULL,
	[apellido] [varchar](50) NULL,
	[telefono] [varchar](9) NULL,
	[genero] [varchar](9) NULL,
	[fec_nac] [varchar](10) NULL,
	[nacionalidad] [varchar](10) NULL,
	[email] [varchar](50) NULL,
	[estado] [bit] NULL,
 CONSTRAINT [PK_copropietario] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

SET ANSI_PADDING OFF
GO


