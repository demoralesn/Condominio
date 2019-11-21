USE [Credito]
GO

/****** Object:  StoredProcedure [dbo].[sp_i_registro_copropietario]    Script Date: 11/21/2019 16:52:52 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[sp_i_registro_copropietario]
	-- Add the parameters for the stored procedure here
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
	insert into dbo.copropietario
	select @rut,@dv,@nombre,@apellido,@telefono,@genero,@fec_nac,@nacionalidad,@email,1
END

GO


