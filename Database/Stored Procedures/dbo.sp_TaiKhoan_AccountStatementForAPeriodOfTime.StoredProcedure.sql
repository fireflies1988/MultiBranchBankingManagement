USE [NGANHANG]
GO
/****** Object:  StoredProcedure [dbo].[sp_TaiKhoan_AccountStatementForAPeriodOfTime]    Script Date: 2/14/2022 3:35:52 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_TaiKhoan_AccountStatementForAPeriodOfTime]
@AccountNumber nchar(9), @From date, @To date
AS
-- SET NOCOUNT ON added to prevent extra result sets from  
-- interfering with SELECT statements.  
SET NOCOUNT ON;  
IF 1=0 BEGIN  
    SET FMTONLY OFF  
END 

CREATE TABLE #AccountStatement (
	Row# bigint,
	SODUDAU money,
	SOTK nchar(9),
	LOAIGD nchar(2),
	NGAYGD datetime,
	SOTIEN money,
	SODUSAU money
)
INSERT INTO #AccountStatement
SELECT ROW_NUMBER() OVER(ORDER BY NGAYGD DESC), NULL, *, NULL
FROM (
	SELECT SOTK, LOAIGD, NGAYGD, SOTIEN FROM GD_GOIRUT
	UNION
	SELECT SOTK, LOAIGD, NGAYGD, SOTIEN FROM Link1.NGANHANG.dbo.GD_GOIRUT
	UNION
	SELECT SOTK_CHUYEN, 'CT', NGAYGD, SOTIEN FROM GD_CHUYENTIEN
	UNION
	SELECT SOTK_NHAN, 'NT', NGAYGD, SOTIEN FROM GD_CHUYENTIEN
	UNION
	SELECT SOTK_CHUYEN, 'CT', NGAYGD, SOTIEN FROM Link1.NGANHANG.dbo.GD_CHUYENTIEN
	UNION
	SELECT SOTK_NHAN, 'NT', NGAYGD, SOTIEN FROM Link1.NGANHANG.dbo.GD_CHUYENTIEN
) Temp 
WHERE SOTK = @AccountNumber

DECLARE @BalanceBefore money, @BalanceAfter money
SELECT @BalanceBefore = SODU FROM TaiKhoan WHERE SOTK = @AccountNumber

UPDATE #AccountStatement 
SET 
	@BalanceAfter = SODUSAU = @BalanceBefore, 
	@BalanceBefore = SODUDAU = CASE WHEN LOAIGD IN ('GT', 'NT') THEN @BalanceAfter - SOTIEN ELSE @BalanceAfter + SOTIEN END

SELECT * FROM #AccountStatement 
WHERE CAST(NGAYGD AS date) BETWEEN @From AND @To
GO
