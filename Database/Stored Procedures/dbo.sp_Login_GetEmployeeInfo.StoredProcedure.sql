USE [NGANHANG]
GO
/****** Object:  StoredProcedure [dbo].[sp_Login_GetEmployeeInfo]    Script Date: 2/14/2022 3:35:52 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_Login_GetEmployeeInfo] @LoginName nvarchar(50)
AS
DECLARE @Username nvarchar(50), @uid int
SELECT @Username = name, @uid = uid FROM sys.sysusers WHERE sid = SUSER_SID(@LoginName)
SELECT MANV = @Username,
	HOTEN = (SELECT HO + ' ' + TEN FROM NHANVIEN WHERE MANV = @Username),
	TENNHOM = name
FROM sys.sysusers
WHERE uid = (SELECT groupuid FROM sys.sysmembers WHERE memberuid = @uid)
GO
