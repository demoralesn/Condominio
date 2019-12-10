﻿USE [Credito]
GO

/****** Object:  Table [dbo].[formato_dcto]    Script Date: 12/10/2019 11:24:49 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

SET ANSI_PADDING ON
GO

CREATE TABLE [dbo].[formato_dcto](
	[id_formato] [int] IDENTITY(1,1) NOT NULL,
	[formato] [nvarchar](max) NULL,
	[tipo] [varchar](10) NULL,
 CONSTRAINT [PK_formato_dcto] PRIMARY KEY CLUSTERED 
(
	[id_formato] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

SET ANSI_PADDING OFF
GO


insert into formato_dcto
select '<div id="Grid"><table class="table"><tr><td colspan="4" align="center">Estado Cuenta Mensual</td></tr><tr><td>&nbsp;</td></tr><tr><td>Conjunto:</td><td colspan="3">Condominio Parronales de Nos 1</td></tr><tr><td>&nbsp;</td></tr><tr><td>Periodo:</td><td>Octubre</td><td>A&ntilde;o:</td><td>2019</td></tr><tr><td>&nbsp;</td></tr><tr><td colspan="2">Copropietario:</td><td>Tipo:</td><td>Propiedad:</td></tr><tr><td colspan="2">Daniel Morales</td><td>Casa</td><td>39</td></tr><tr><td>&nbsp;</td></tr><tr><td colspan="2">Monto total gastos del periodo:</td><td colspan="2" align="right">1.342.000</td></tr><tr><td>&nbsp;</td></tr><tr><td colspan="2">Prorrateo actual de su propiedad es:</td><td colspan="2" align="right">0.6670%</td></tr><tr><td>&nbsp;</td></tr><tr><td colspan="4" align="center">Detalle cobros del mes</td></tr><tr><td colspan="2">Gasto Com&uacute;n:</td><td colspan="2" align="right">8.951</td></tr><tr><td colspan="2">Fondo de reserva:</td><td>(10% x 8.951)</td><td align="right">895</td></tr><tr><td colspan="4">Saldos anteriores:</td></tr><tr><td colspan="2">Saldo anterior gastos comunes:</td><td colspan="2" align="right">-14.607</td></tr><tr><td colspan="2">Interes de mora:</td><td>(Tasa m&aacute;xima legal 2.59%)</td><td align="right">0</td></tr><tr><td colspan="2">Saldo anterior otros cobros:</td><td colspan="2" align="right">0</td></tr><tr><td colspan="2">Multas, arriendos y otros no pagados en meses anteriores.</td><td colspan="2">&nbsp;</td></tr><tr><td>&nbsp;</td></tr><tr><td colspan="2" align="right">Total a pagar este mes:</td><td colspan="2" align="right">-4.761</td></tr><tr><td>&nbsp;</td></tr><tr><td colspan="4">Pague mediante transferencia electr&oacute;nica o dep&oacute;sito bancario a:</td></tr><tr><td>Nombre:</td><td>Condominio Parronales de Nos I</td><td>Rut:</td><td>65071974-3</td></tr><tr><td>Cuenta Corriente:</td><td>70223106</td><td>Banco:</td><td>BCI</td></tr><tr><td colspan="2">Informe su pago al correo:</td><td colspan="2">adm.parronales1@gmail.com</td></tr><tr><td>&nbsp;</td></tr><tr><td colspan="2">&Uacute;ltimo pago registrado:</td><td>28-10-2019</td><td align="right">10.000</td></tr><tr><td colspan="4" align="center"><img src="~/Content/img/firma.jpg" /></td></tr><tr><td colspan="4" align="center">Patricia Oliver G.</td></tr><tr><td colspan="4" align="center">Administrador</td></tr></table></div>','EST_CTA_ME'