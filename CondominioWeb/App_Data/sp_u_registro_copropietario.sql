
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[sp_u_registro_copropietario]
	-- Add the parameters for the stored procedure here
	@id int,
	@rut varchar(9),
	@dv varchar(1),
	@nombre varchar(50),
	@apellido varchar(50),
	@telefono varchar(9),
	@genero varchar(9),
	@fec_nac varchar(10),
	@nacionalidad varchar(10),
	@email varchar(50)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	update dbo.copropietario
	set rut=@rut,dv=@dv,nombre=@nombre,apellido=@apellido,telefono=@telefono,genero=@genero,fec_nac=@fec_nac,
	nacionalidad=@nacionalidad,email=@email
	where id=@id
END