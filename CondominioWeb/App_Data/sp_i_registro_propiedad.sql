USE [Credito]
GO
/****** Object:  StoredProcedure [dbo].[sp_i_registro_copropietario]    Script Date: 11/25/2019 10:06:33 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[sp_i_registro_propiedad]
	-- Add the parameters for the stored procedure here
	@numero varchar(5),
	@tipo varchar(15),
	@prorrateo varchar(5),
	@propietario varchar(50),
	@estado_prop varchar(15)
	
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	insert into dbo.propiedad
	select @numero,@tipo,@prorrateo,@propietario,@estado_prop,1
END
