USE [Credito]
GO
/****** Object:  StoredProcedure [dbo].[sp_d_registro_copropietario]    Script Date: 11/25/2019 10:40:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[sp_d_registro_propiedad]
	-- Add the parameters for the stored procedure here
	@id int=0
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	update
		dbo.propiedad
	set
		estado=0
	where 
		id=@id
	
END
