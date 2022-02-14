USE [NGANHANG]
GO
/****** Object:  StoredProcedure [dbo].[sp_GD_FindCustomerInfoByAccountNumber]    Script Date: 2/14/2022 3:35:52 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_GD_FindCustomerInfoByAccountNumber] @SOTK nchar(9)
AS
SELECT CMND, HO + ' ' + TEN
FROM LINK2.NGANHANG.dbo.KhachHang
WHERE CMND = (SELECT CMND FROM TaiKhoan WHERE SOTK = @SOTK)
GO
