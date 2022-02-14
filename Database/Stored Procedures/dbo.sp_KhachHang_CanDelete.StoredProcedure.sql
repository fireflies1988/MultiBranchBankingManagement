USE [NGANHANG]
GO
/****** Object:  StoredProcedure [dbo].[sp_KhachHang_CanDelete]    Script Date: 2/14/2022 3:35:52 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_KhachHang_CanDelete] @CMND nchar(10)
AS
IF EXISTS (SELECT * FROM TaiKhoan WHERE CMND = @CMND)
	-- can't delete this customer
	RETURN 0;
ELSE
	-- can delete this customer 
	RETURN 1;
GO
