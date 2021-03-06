USE [NGANHANG]
GO
/****** Object:  StoredProcedure [dbo].[sp_NhanVien_ChangeBranch]    Script Date: 2/14/2022 3:35:52 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_NhanVien_ChangeBranch] @OldEmployeeID nchar(10), @NewEmployeeID nchar(10) = NULL, @NewBranchID nchar(10)
AS
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

SET XACT_ABORT ON
BEGIN DISTRIBUTED TRANSACTION
	-- Delete this employee
	-- if this employee doesn't have any activities (bounds to GD_GOIRUT, GD_CHUYENTIEN) at the current branch
	-- otherwise mark TrangThaiXoa as 1
	IF EXISTS (SELECT * FROM GD_CHUYENTIEN WHERE MANV = @OldEmployeeID) 
		OR EXISTS (SELECT * FROM GD_GOIRUT WHERE MANV = @OldEmployeeID)
		UPDATE NhanVien SET TrangThaiXoa = 1 WHERE MANV = @OldEmployeeID
	ELSE
	BEGIN
		DELETE FROM NhanVien WHERE MANV = @OldEmployeeID
		SET @NewEmployeeID = @OldEmployeeID
	END

	-- If this employee info already exists in the branch to which you want to move an employee
	IF @MANV IS NOT NULL
		-- Mark TrangThaiXoa of the employee as 0 at that new branch
		UPDATE LINK1.NGANHANG.dbo.NhanVien SET TrangThaiXoa = 0 WHERE MANV = @MANV
	ELSE
		-- Insert a new employee with a new employee id and old info into the new branch
		INSERT INTO LINK1.NGANHANG.dbo.NhanVien (MANV, HO, TEN, DIACHI, PHAI, SODT, MACN)
		VALUES (@NewEmployeeID, @HO, @TEN, @DIACHI, @PHAI, @SODT, @NewBranchID)

	-- Delete login
	EXEC sp_Login_DeleteLogin @OldEmployeeId

-- successful
COMMIT TRANSACTION



GO
