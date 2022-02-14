USE [NGANHANG]
GO
/****** Object:  StoredProcedure [dbo].[sp_Login_CheckExists]    Script Date: 2/14/2022 3:35:52 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_Login_CheckExists] @Username nvarchar(50)
AS
IF EXISTS (SELECT * FROM sys.sysusers WHERE name = @Username)
	RETURN 1;
ELSE RETURN 0;
GO
