USE [NGANHANG]
GO
/****** Object:  StoredProcedure [dbo].[sp_Login_DeleteLogin]    Script Date: 2/14/2022 3:35:52 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_Login_DeleteLogin] @Username nvarchar(50)
AS
DECLARE @Cmd1 nvarchar(200), @Cmd2 nvarchar(200)
DECLARE @LoginName nvarchar(50)
SET XACT_ABORT ON
BEGIN TRANSACTION 
	IF EXISTS (SELECT * FROM sys.sysusers WHERE name = @Username)
	BEGIN
		SELECT @LoginName = SUSER_SNAME(sid) FROM sys.sysusers WHERE name = @Username
		SET @Cmd1 = 'DROP USER ' + QUOTENAME(@Username)
		EXEC (@Cmd1)
		SET @Cmd2 = 'DROP LOGIN ' + QUOTENAME(@LoginName)
		EXEC (@Cmd2)
		-- Login has been dropped successfully.
	END
	--ELSE
		--RAISERROR ('Cannot drop this user because it does not exist or you do not have permission.', 16, 1)
COMMIT TRANSACTION
GO
