USE [NGANHANG]
GO
/****** Object:  StoredProcedure [dbo].[sp_KhachHang_CheckExists]    Script Date: 2/14/2022 3:35:52 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_KhachHang_CheckExists] @CMND nchar(10)
AS
IF EXISTS (SELECT * FROM KhachHang WHERE CMND = @CMND)
	RETURN 1;
ELSE IF EXISTS (SELECT * FROM Link1.NGANHANG.dbo.KhachHang WHERE CMND = @CMND)
	RETURN 2;
RETURN 0;
GO
