USE [NGANHANG]
GO
/****** Object:  StoredProcedure [dbo].[sp_TaiKhoan_ListOfAccountsOpenedForAPeriodOfTime]    Script Date: 2/14/2022 3:35:52 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_TaiKhoan_ListOfAccountsOpenedForAPeriodOfTime] 
@BranchID nchar(10) = NULL, @From date, @To date
AS
IF @BranchID IS NULL -- select on both branches
	SELECT SOTK, CMND, NGAYMOTK FROM TaiKhoan 
	WHERE CAST(NGAYMOTK AS date) BETWEEN @From AND @To
	ORDER BY NGAYMOTK
ELSE -- select on a specific branch
	SELECT SOTK, CMND, NGAYMOTK FROM TaiKhoan
	WHERE MACN = @BranchID AND CAST(NGAYMOTK AS date) BETWEEN @From AND @To
	ORDER BY NGAYMOTK

GO
