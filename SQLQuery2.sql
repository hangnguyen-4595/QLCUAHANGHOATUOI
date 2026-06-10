-- NHÂN VIÊN
INSERT INTO NhanVien
VALUES
('NV001',N'Nguyễn Văn A',N'Nam','2004-01-15','0911111111',N'Huế',GETDATE()),
('NV002',N'Trần Thị B',N'Nữ','2003-05-20','0922222222',N'Đà Nẵng',GETDATE()),
('NV003',N'Lê Văn C',N'Nam','2002-08-10','0933333333',N'Quảng Trị',GETDATE());
-- TÀI KHOẢN

INSERT INTO TaiKhoan
VALUES
('TK001','NV001','admin','123456','Admin'),
('TK002','NV002','nhanvien1','123456','NhanVien'),
('TK003','NV003','nhanvien2','123456','NhanVien');
-- KHÁCH HÀNG
INSERT INTO KhachHang
VALUES
('KH001',N'Phạm Thị D','0944444444',N'Huế'),
('KH002',N'Nguyễn Văn E','0955555555',N'Đà Nẵng'),
('KH003',N'Trần Văn F','0966666666',N'Quảng Bình');

-- SẢN PHẨM
INSERT INTO SanPham
VALUES
('SP001',N'Hoa Hồng Đỏ',N'Đỏ',15000,100,N'Còn hàng'),
('SP002',N'Hoa Cúc Vàng',N'Vàng',10000,80,N'Còn hàng'),
('SP003',N'Hoa Ly Trắng',N'Trắng',30000,50,N'Còn hàng'),
('SP004',N'Hoa Lan Tím',N'Tím',50000,30,N'Còn hàng'),
('SP005',N'Hoa Hướng Dương',N'Vàng',25000,60,N'Còn hàng');
-- HÓA ĐƠN

INSERT INTO HoaDon
VALUES
('HD001','KH001','NV001',GETDATE(),95000),
('HD002','KH002','NV002',GETDATE(),90000),
('HD003','KH003','NV003',GETDATE(),125000);

-- CHI TIẾT HÓA ĐƠN
INSERT INTO ChiTietHoaDon
(MaHD,MaSP,SoLuong,DonGia)
VALUES
('HD001','SP001',5,15000),
('HD001','SP002',2,10000),
('HD002','SP003',3,30000),
('HD003','SP004',1,50000),
('HD003','SP005',3,25000);
GO
SELECT * FROM NhanVien;
SELECT * FROM TaiKhoan;