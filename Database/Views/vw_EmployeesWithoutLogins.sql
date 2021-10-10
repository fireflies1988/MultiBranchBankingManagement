CREATE VIEW vw_EmployeesWithoutLogins
AS
SELECT MANV, CONCAT(HO + ' ', TEN, ' - ', MANV) as HOTEN
FROM NhanVien
WHERE TrangThaiXoa = 0 AND NOT EXISTS (SELECT * FROM sys.sysusers WHERE name = MANV)