USE [Credito]
GO
/****** Object:  StoredProcedure [dbo].[sp_c_copropietario]    Script Date: 11/21/2019 16:33:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
ALTER PROCEDURE [dbo].[sp_c_copropietario]
	-- Add the parameters for the stored procedure here
	@tipo int,
	@nombre varchar(50)=null
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	select 
		cop.rut,
		cop.dv,
		cop.nombre,
		cop.apellido,
		cop.telefono,
		cop.genero,
		cop.fec_nac,
		cop.nacionalidad,
		cop.email 
	from 
		dbo.copropietario cop
	where
		cop.estado=1
	
END
