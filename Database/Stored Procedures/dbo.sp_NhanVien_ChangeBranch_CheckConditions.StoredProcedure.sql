USE [NGANHANG]
GO
/****** Object:  StoredProcedure [dbo].[sp_NhanVien_ChangeBranch_CheckConditions]    Script Date: 2/14/2022 3:35:52 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_NhanVien_ChangeBranch_CheckConditions] @OldEmployeeID nchar(10)
AS
-- CHECK IF WE NEED A NEW EMPLOYEE ID

DECLARE @HO nvarchar(40), @TEN nvarchar(10), @DIACHI nvarchar(100), 
	@PHAI nvarchar(3), @SODT nvarchar(15)
SELECT @HO = HO, @TEN = TEN, @DIACHI = DIACHI, @PHAI = PHAI, @SODT = SODT 
FROM NhanVien
WHERE MANV = @OldEmployeeID

-- @MANV is used to check if the employee info exists in the other branch
DECLARE @MANV nchar(10)
SELECT @MANV = MANV FROM LINK1.NGANHANG.dbo.NhanVien 
WHERE HO = @HO AND TEN = @TEN AND DIACHI = @DIACHI AND PHAI = @PHAI 
		AND SODT = @SODT AND TrangThaiXoa = 1

IF EXISTS (SELECT * FROM GD_CHUYENTIEN WHERE MANV = @OldEmployeeID) 
	OR EXISTS (SELECT * FROM GD_GOIRUT WHERE MANV = @OldEmployeeID)
	IF @MANV IS NOT NULL
		-- NewEmployeeID is not necessary
		RETURN 0
	ELSE 
		-- NewEmployeeID is necessary
		RETURN 1
ELSE
	-- NewEmployeeID is not necessary
	RETURN 0
GO
