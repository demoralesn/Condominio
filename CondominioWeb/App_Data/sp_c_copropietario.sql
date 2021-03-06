-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[sp_c_copropietario]
	-- Add the parameters for the stored procedure here
	@tipo int,
	@id int=null
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	if (@tipo=0)
	begin
	select 
		cop.id,
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
	end
	else
	begin
	select 
		cop.id,
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
		and cop.id=@id
	end
	
END