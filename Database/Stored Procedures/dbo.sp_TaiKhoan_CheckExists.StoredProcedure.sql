USE [NGANHANG]
GO
/****** Object:  StoredProcedure [dbo].[sp_TaiKhoan_CheckExists]    Script Date: 2/14/2022 3:35:52 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_TaiKhoan_CheckExists] @SOTK nchar(9)
AS
IF EXISTS (SELECT * FROM TaiKhoan WHERE SOTK = @SOTK)
	RETURN 1;
ELSE
	RETURN 0;
GO
