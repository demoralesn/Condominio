USE [Credito]
GO

/****** Object:  Table [dbo].[copropietario]    Script Date: 11/25/2019 09:43:34 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

SET ANSI_PADDING ON
GO

CREATE TABLE [dbo].[propiedad](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[numero] [varchar](5) NULL,
	[tipo] [varchar](15) NULL,
	[prorrateo] [varchar](5) NULL,
	[propietario] [varchar](50) NULL,
	[estado_prop] [varchar](15) NULL,
	[estado] [bit] NULL,
 CONSTRAINT [PK_propiedad] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

SET ANSI_PADDING OFF
GO


