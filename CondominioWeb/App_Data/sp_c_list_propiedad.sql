USE [Credito]
GO
/****** Object:  StoredProcedure [dbo].[sp_c_copropietario]    Script Date: 11/25/2019 09:42:52 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[sp_c_list_propiedad]
	-- Add the parameters for the stored procedure here
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	select 
		pro.id,
		pro.numero
	from 
		dbo.propiedad pro
	where
		pro.estado=1
	
END