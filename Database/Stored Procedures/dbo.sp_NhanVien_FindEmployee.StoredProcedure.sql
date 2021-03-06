USE [NGANHANG]
GO
/****** Object:  StoredProcedure [dbo].[sp_NhanVien_FindEmployee]    Script Date: 2/14/2022 3:35:52 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_NhanVien_FindEmployee] @MANV nchar(10)
AS
DECLARE @MACN nchar(10), @HO nvarchar(40), @TEN nvarchar(10)
IF EXISTS (SELECT MANV FROM NhanVien WHERE MANV = @MANV)
	SELECT TENCN = (SELECT TENCN FROM ChiNhanh), HO, TEN
	FROM NhanVien WHERE MANV = @MANV
ELSE IF EXISTS (SELECT MANV FROM LINK0.NGANHANG.dbo.NhanVien WHERE MANV = @MANV)
BEGIN
	SELECT @MACN = MACN, @HO = HO, @TEN = TEN
	FROM LINK0.NGANHANG.dbo.NhanVien WHERE MANV = @MANV
	SELECT TENCN, HO = @HO, TEN = @TEN 
	FROM LINK0.NGANHANG.dbo.ChiNhanh WHERE MACN = @MACN
END
ELSE
	RAISERROR (N'Mã nhân viên bạn tìm không tồn tại!', 16, 1)
GO
