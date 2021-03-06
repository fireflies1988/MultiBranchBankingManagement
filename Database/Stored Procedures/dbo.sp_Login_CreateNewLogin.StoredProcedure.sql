USE [NGANHANG]
GO
/****** Object:  StoredProcedure [dbo].[sp_Login_CreateNewLogin]    Script Date: 2/14/2022 3:35:52 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_Login_CreateNewLogin]
@LoginName nvarchar(50), @Password nvarchar(50), @Username nvarchar(50), @DbRole nvarchar(50)
AS
DECLARE @Cmd1 nvarchar(500), @Cmd2 nvarchar(500), @Cmd3 nvarchar(500), @Cmd4 nvarchar(500)
SET XACT_ABORT ON
BEGIN TRANSACTION
	BEGIN TRY
		SET @Cmd1 = N'CREATE LOGIN ' + QUOTENAME(@LoginName) + ' WITH PASSWORD = ' + QUOTENAME(@Password, '''')
		EXEC (@Cmd1)
	END TRY
	BEGIN CATCH
		THROW 50000, N'Tên đăng nhập này đã tồn tại, vui lòng nhập tên đăng nhập khác!', 1
	END CATCH

	-- Username must be employee id
	SET @Cmd2 = N'CREATE USER ' + QUOTENAME(@Username) + ' FOR LOGIN ' + QUOTENAME(@LoginName)
	EXEC (@Cmd2)

	SET @Cmd3 = N'ALTER SERVER ROLE securityadmin ADD MEMBER ' + QUOTENAME(@LoginName)
	EXEC (@Cmd3)

	SET @Cmd4 = N'ALTER ROLE ' + QUOTENAME(@DbRole) + ' ADD MEMBER ' + QUOTENAME(@Username)
	EXEC (@Cmd4)

-- A new login was created successfully
COMMIT TRANSACTION
		
GO
