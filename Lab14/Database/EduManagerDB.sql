IF DB_ID(N'EduManagerDB') IS NULL
BEGIN
    CREATE DATABASE EduManagerDB;
END
GO

USE EduManagerDB;
GO

IF OBJECT_ID('dbo.MONHOC', 'U') IS NOT NULL
    DROP TABLE dbo.MONHOC;
GO

CREATE TABLE MONHOC (
    MaMonHoc NVARCHAR(10) NOT NULL PRIMARY KEY,
    TenMonHoc NVARCHAR(100) NOT NULL,
    SoTinChi INT NOT NULL CONSTRAINT CK_MONHOC_SoTinChi CHECK (SoTinChi >= 1 AND SoTinChi <= 6),
    TrangThai BIT NOT NULL CONSTRAINT DF_MONHOC_TrangThai DEFAULT 1
);
GO

INSERT INTO MONHOC (MaMonHoc, TenMonHoc, SoTinChi, TrangThai) VALUES
(N'COMP1019', N'Lập trình trên Windows', 3, 1),
(N'COMP1010', N'Cơ sở dữ liệu', 3, 1),
(N'COMP1013', N'Lập trình hướng đối tượng', 3, 1),
(N'COMP1014', N'Cấu trúc dữ liệu và giải thuật', 4, 1),
(N'COMP1035', N'Mạng máy tính', 3, 1),
(N'COMP1041', N'Hệ điều hành', 3, 1),
(N'COMP1002', N'Nhập môn Công nghệ thông tin', 2, 0);
GO

SELECT * FROM MONHOC;
GO
