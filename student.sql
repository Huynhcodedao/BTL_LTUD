-- MySQL dump 10.13  Distrib 8.0.31, for Win64 (x86_64)
--
-- Host: 127.0.0.1    Database: student
-- ------------------------------------------------------
-- Server version	8.0.31

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!50503 SET NAMES utf8 */;
/*!40103 SET @OLD_TIME_ZONE=@@TIME_ZONE */;
/*!40103 SET TIME_ZONE='+00:00' */;
/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;

--
-- Table structure for table `account`
--

DROP TABLE IF EXISTS `account`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `account` (
  `id` int NOT NULL AUTO_INCREMENT,
  `Email` varchar(100) NOT NULL,
  `Fullname` varchar(100) DEFAULT NULL,
  `Phone` varchar(20) DEFAULT NULL,
  `username` varchar(50) NOT NULL,
  `password` varchar(255) DEFAULT NULL,
  PRIMARY KEY (`id`,`username`,`Email`),
  UNIQUE KEY `username` (`username`)
) ENGINE=InnoDB AUTO_INCREMENT=7 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `account`
--

LOCK TABLES `account` WRITE;
/*!40000 ALTER TABLE `account` DISABLE KEYS */;
INSERT INTO `account` VALUES (1,'21021597@vnu.edu.vn','Lê Văn Huỳnh','0346197221','1','123'),(2,'21021597@vnu.edu.vn','huynh','0043224','112121','123'),(3,'21020730@vnu.edu.vn','Linh','233132','21020730','123'),(4,'21021597@vnu.edu.vn','Lê Văn Huỳnh','0346197221','2','123'),(5,'21021597@vnu.edu.vn','Lê Văn Huỳnh','0346197221','4','123'),(6,'21021597@vnu.edu.vn','Lê Văn Huỳnh','0346197221','21021597','123');
/*!40000 ALTER TABLE `account` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `diem`
--

DROP TABLE IF EXISTS `diem`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `diem` (
  `MaSV` varchar(10) NOT NULL,
  `MaMH` varchar(10) NOT NULL,
  `DiemGiuaki` float NOT NULL,
  `DiemCuoiki` float NOT NULL,
  `DiemTong` float NOT NULL,
  `HocKy` varchar(45) NOT NULL,
  PRIMARY KEY (`MaSV`,`MaMH`),
  KEY `MaMH` (`MaMH`),
  CONSTRAINT `diem_ibfk_2` FOREIGN KEY (`MaMH`) REFERENCES `monhoc` (`MaMH`),
  CONSTRAINT `fk_diem_maSV` FOREIGN KEY (`MaSV`) REFERENCES `sinhvien` (`MaSV`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `diem`
--

LOCK TABLES `diem` WRITE;
/*!40000 ALTER TABLE `diem` DISABLE KEYS */;
INSERT INTO `diem` VALUES ('21020730','MH010',7.5,7,3.2,'2021-2'),('21020730','MH011',8,7.5,3.3,'2021-2'),('21020730','MH012',7,7.5,3.2,'2021-2'),('21020730','MH013',7.5,7,3.2,'2022-1'),('21020730','MH014',8,7.5,3.3,'2022-1'),('21020730','MH015',7,7.5,3.2,'2022-1'),('21020730','MH016',7.5,7,3.2,'2022-1'),('21020730','MH017',8,7.5,3.3,'2022-1'),('21020730','MH018',7,7.5,3.2,'2022-1'),('21020730','MH019',7.5,7,3.2,'2022-2'),('21020730','MH020',8,7.5,3.3,'2022-2'),('21020730','MH021',7,7.5,3.2,'2022-2'),('21020730','MH022',7.5,7,3.2,'2022-2'),('21020730','MH023',8,7.5,3.3,'2022-2'),('21020730','MH024',7,7.5,3.2,'2022-2'),('21020730','MH025',7.5,7,3.2,'2023-1'),('21020730','MH026',8,7.5,3.3,'2023-1'),('21020730','MH027',7,7.5,3.2,'2023-1'),('21020730','MH028',7.5,7,3.2,'2023-1'),('21020730','MH029',8,7.5,3.3,'2023-1'),('21020730','MH030',7,7.5,3.2,'2023-1'),('21021552','MH010',6.5,7,2.8,'2021-2'),('21021552','MH011',7,7.5,3,'2021-2'),('21021552','MH012',6,6.5,2.5,'2021-2'),('21021552','MH013',6.5,7,2.8,'2022-1'),('21021552','MH014',7,7.5,3,'2022-1'),('21021552','MH015',6,6.5,2.5,'2022-1'),('21021552','MH016',6.5,7,2.8,'2022-1'),('21021552','MH017',7,7.5,3,'2022-1'),('21021552','MH018',6,6.5,2.5,'2022-1'),('21021552','MH019',6.5,7,2.8,'2022-2'),('21021552','MH020',7,7.5,3,'2022-2'),('21021552','MH021',6,6.5,2.5,'2022-2'),('21021552','MH022',6.5,7,2.8,'2022-2'),('21021552','MH023',7,7.5,3,'2022-2'),('21021552','MH024',6,6.5,2.5,'2022-2'),('21021552','MH025',6.5,7,2.8,'2023-1'),('21021552','MH026',7,7.5,3,'2023-1'),('21021552','MH027',6,6.5,2.5,'2023-1'),('21021552','MH028',6.5,7,2.8,'2023-1'),('21021552','MH029',7,7.5,3,'2023-1'),('21021552','MH030',6,6.5,2.5,'2023-1'),('21021555','MH010',9,9,4,'2022-1'),('21021555','MH014',3,4,1,'2022-1'),('21021555','MH024',9,9,4,'2022-1'),('21021555','MH028',3,4,1,'2022-1'),('21021582','MH010',4,5,1.5,'2021-2'),('21021582','MH011',5.5,6,2,'2021-2'),('21021582','MH012',6,6.5,2,'2021-2'),('21021582','MH013',3,4,1,'2022-1'),('21021582','MH014',4.5,5,1.5,'2022-1'),('21021582','MH015',5,5.5,2,'2022-1'),('21021582','MH016',6.5,7,2.5,'2022-1'),('21021582','MH017',5.5,6.5,2,'2022-1'),('21021582','MH018',4,5.5,1.5,'2022-1'),('21021582','MH019',5,6,2,'2022-2'),('21021582','MH020',3.5,4.5,1,'2022-2'),('21021582','MH021',4,5,1.5,'2022-2'),('21021582','MH022',6,6.5,2,'2022-2'),('21021582','MH023',5,6,2,'2022-2'),('21021582','MH024',3.5,4.5,1,'2022-2'),('21021582','MH025',4,5,1.5,'2023-1'),('21021582','MH026',5.5,6.5,2,'2023-1'),('21021582','MH027',6,6.5,2,'2023-1'),('21021582','MH028',3,4,1,'2023-1'),('21021582','MH029',4.5,5.5,1.5,'2023-1'),('21021582','MH030',5,5.5,2,'2023-1'),('21021596','MH010',8,7.5,3.3,'2021-2'),('21021596','MH011',8.5,8,3.7,'2021-2'),('21021596','MH012',7.5,8,3.3,'2021-2'),('21021596','MH013',8,7.5,3.3,'2022-1'),('21021596','MH014',8.5,8,3.7,'2022-1'),('21021596','MH015',7.5,8,3.3,'2022-1'),('21021596','MH016',8,7.5,3.3,'2022-1'),('21021596','MH017',8.5,8,3.7,'2022-1'),('21021596','MH018',7.5,8,3.3,'2022-1'),('21021596','MH019',8,7.5,3.3,'2022-2'),('21021596','MH020',8.5,8,3.7,'2022-2'),('21021596','MH021',7.5,8,3.3,'2022-2'),('21021596','MH022',8,7.5,3.3,'2022-2'),('21021596','MH023',8.5,8,3.7,'2022-2'),('21021596','MH024',7.5,8,3.3,'2022-2'),('21021596','MH025',8,7.5,3.3,'2023-1'),('21021596','MH026',8.5,8,3.7,'2023-1'),('21021596','MH027',7.5,8,3.3,'2023-1'),('21021596','MH028',8,7.5,3.3,'2023-1'),('21021596','MH029',8.5,8,3.7,'2023-1'),('21021596','MH030',7.5,8,3.3,'2023-1'),('21021597','MH010',9,9.5,4,'2021-2'),('21021597','MH011',8.5,8,3.5,'2021-2'),('21021597','MH012',7,8,3,'2021-2'),('21021597','MH013',8,7.5,3,'2022-1'),('21021597','MH014',7.5,8,3,'2022-1'),('21021597','MH015',6,7,2,'2022-1'),('21021597','MH016',9,8.5,3.7,'2022-1'),('21021597','MH017',8.5,9,3.7,'2022-1'),('21021597','MH018',7,7.5,3,'2022-1'),('21021597','MH019',8,8.5,3.5,'2022-2'),('21021597','MH020',7.5,7,3,'2022-2'),('21021597','MH021',6.5,7.5,3,'2022-2'),('21021597','MH022',9,9.5,4,'2022-2'),('21021597','MH023',8.5,8,3.5,'2022-2'),('21021597','MH024',7,8,3,'2022-2'),('21021597','MH025',8,7.5,3,'2023-1'),('21021597','MH026',7.5,8,3,'2023-1'),('21021597','MH027',6,7,2,'2023-1'),('21021597','MH028',9,8.5,3.7,'2023-1'),('21021597','MH029',8.5,9,3.7,'2023-1'),('21021597','MH030',7,7.5,3,'2023-1'),('21021598','MH010',9,9,4,'2022-1'),('21021598','MH014',3,4,1,'2022-1'),('21021598','MH024',9,9,4,'2022-1'),('21021598','MH028',3,4,1,'2022-1'),('21021599','MH010',9,9,4,'2022-1'),('21021599','MH014',3,4,1,'2022-1'),('21021599','MH024',9,9,4,'2022-1'),('21021599','MH028',3,4,1,'2022-1'),('21021666','MH0001',9,9,4,'2022-1'),('21021666','MH0002',9,9,4,'2022-1'),('21021666','MH0004',9,9,4,'2022-1'),('21021666','MH0007',9,5,2.5,'2022-1'),('21021666','MH0013',9,5,2.5,'2022-1'),('21021666','MH011',9,6,3,'2022-1'),('21021666','MH022',9,6,3,'2022-1'),('SV03','MH0013',5,5,2,'2023-1');
/*!40000 ALTER TABLE `diem` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `giangvien`
--

DROP TABLE IF EXISTS `giangvien`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `giangvien` (
  `MaGV` varchar(10) NOT NULL,
  `HoTen` varchar(100) NOT NULL,
  `DiaChi` varchar(255) DEFAULT NULL,
  `NgaySinh` date DEFAULT NULL,
  `MaKhoa` varchar(10) DEFAULT NULL,
  `MaMH` varchar(10) DEFAULT NULL,
  `soDienthoai` varchar(45) DEFAULT NULL,
  PRIMARY KEY (`MaGV`),
  KEY `MaKhoa` (`MaKhoa`),
  KEY `MaMH` (`MaMH`),
  CONSTRAINT `giangvien_ibfk_1` FOREIGN KEY (`MaKhoa`) REFERENCES `khoa` (`MaKhoa`),
  CONSTRAINT `giangvien_ibfk_2` FOREIGN KEY (`MaMH`) REFERENCES `monhoc` (`MaMH`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `giangvien`
--

LOCK TABLES `giangvien` WRITE;
/*!40000 ALTER TABLE `giangvien` DISABLE KEYS */;
INSERT INTO `giangvien` VALUES ('1','121','trtr','2024-05-30','K001','MH0004','121');
/*!40000 ALTER TABLE `giangvien` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `khoa`
--

DROP TABLE IF EXISTS `khoa`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `khoa` (
  `MaKhoa` varchar(10) NOT NULL,
  `TenKhoa` varchar(100) NOT NULL,
  PRIMARY KEY (`MaKhoa`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `khoa`
--

LOCK TABLES `khoa` WRITE;
/*!40000 ALTER TABLE `khoa` DISABLE KEYS */;
INSERT INTO `khoa` VALUES ('K001','Khoa điện tử viễN thông'),('K002','Khoa Công nghệ thông tin'),('K003','Khoa Công nghệ xây dựng'),('K004','Khoa Vật lý kỹ thuật'),('K005','Khoa Điều khiển và tự động hóa'),('K01','Khoa Công nghệ nông nghiệp'),('K02','Viện trí tuệ nhân tạo'),('K03','Viện hàng không vũ trụ');
/*!40000 ALTER TABLE `khoa` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `lop`
--

DROP TABLE IF EXISTS `lop`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `lop` (
  `MaLop` varchar(10) NOT NULL,
  `MaKhoa` varchar(10) DEFAULT NULL,
  `TenLop` varchar(100) NOT NULL,
  `KhoaHoc` varchar(100) DEFAULT NULL,
  PRIMARY KEY (`MaLop`),
  KEY `MaKhoa` (`MaKhoa`),
  CONSTRAINT `lop_ibfk_1` FOREIGN KEY (`MaKhoa`) REFERENCES `khoa` (`MaKhoa`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `lop`
--

LOCK TABLES `lop` WRITE;
/*!40000 ALTER TABLE `lop` DISABLE KEYS */;
INSERT INTO `lop` VALUES ('DACLC1','K001','CNKT Điện tử viễn thông 1','2021-2025'),('DACLC2','K001','CNKT Điện tử viễn thông 2','2021-2025'),('L0002','K002','Lớp CNTT 1','2021-2025'),('L0003','K003','Lớp Xây dựng 1','2021-2025'),('L0004','K004','Lớp Vật lý 1','2021-2025'),('L0005','K005','Lớp Tự động hóa 1','2021-2025'),('L0006','K01','Lớp Nông nghiệp 1','2021-2025'),('L0007','K02','Lớp Trí tuệ nhân tạo 1','2021-2025'),('L0008','K03','Lớp Hàng không 1','2021-2025'),('L001','K001','Lớp CNTT1','2020-2024'),('L002','K002','Lớp KT1','2020-2024'),('L003','K003','Lớp QTKD1','2020-2024'),('L004','K004','Lớp KHXH1','2020-2024'),('L005','K005','Lớp Luật1','2020-2024'),('L01','K01','Lớp Công nghệ thông tin 1','2020-2024'),('L02','K02','Lớp Kinh tế 1','2019-2023'),('L03','K03','Lớp Ngữ văn 1','2021-2025');
/*!40000 ALTER TABLE `lop` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `monhoc`
--

DROP TABLE IF EXISTS `monhoc`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `monhoc` (
  `MaMH` varchar(10) NOT NULL,
  `TenMon` varchar(100) NOT NULL,
  `TinChi` int NOT NULL,
  PRIMARY KEY (`MaMH`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `monhoc`
--

LOCK TABLES `monhoc` WRITE;
/*!40000 ALTER TABLE `monhoc` DISABLE KEYS */;
INSERT INTO `monhoc` VALUES ('MH0001','Toán cao cấp 1',3),('MH0002','Lập trình C cơ bản',4),('MH0003','Mạch điện tử',3),('MH0004','Cơ học lượng tử',3),('MH0005','Tự động hóa',4),('MH0006','Công nghệ sinh học',3),('MH0007','Trí tuệ nhân tạo',4),('MH0008','Kỹ thuật hàng không',3),('MH0009','Cơ sở dữ liệu',3),('MH001','Lập trình C',3),('MH0010','Mạng máy tính',4),('MH0011','Hệ điều hành',3),('MH0012','Kỹ thuật lập trình',4),('MH0013','Phân tích thiết kế hệ thống',3),('MH0014','Đồ họa máy tính',3),('MH0015','Kỹ thuật số',4),('MH0016','Xử lý tín hiệu số',3),('MH002','Kinh tế vĩ mô',3),('MH003','Quản trị kinh doanh',4),('MH004','Văn học Việt Nam',2),('MH005','Luật dân sự',3),('MH01','Lập trình C',3),('MH010','Mạng máy tính',4),('MH011','Hệ điều hành',3),('MH012','Kỹ thuật lập trình',4),('MH013','Phân tích thiết kế hệ thống',3),('MH014','Đồ họa máy tính',3),('MH015','Kỹ thuật số',4),('MH016','Xử lý tín hiệu số',3),('MH017','Điện tử công suất',4),('MH018','Điều khiển tự động',3),('MH019','Robot học',3),('MH02','Kinh tế vĩ mô',2),('MH020','Nhập môn Internet of Things',4),('MH021','Thiết kế vi mạch',3),('MH022','Truyền thông không dây',4),('MH023','Học máy',3),('MH024','Thị giác máy tính',4),('MH025','Khoa học dữ liệu',3),('MH026','Kỹ thuật vi xử lý',4),('MH027','Phát triển phần mềm',3),('MH028','An toàn thông tin',3),('MH029','Điều khiển số',3),('MH03','Văn học cổ điển',2),('MH030','Công nghệ Web',3),('MH031','Hệ thống nhúng',4),('MH032','Thiết kế hệ thống số',3),('MH033','Lý thuyết mật mã',3),('MH034','Điều khiển thông minh',4),('MH035','Mạng viễn thông',3),('MH036','Quản trị mạng',3),('MH037','Điều khiển robot',4),('MH038','Kỹ thuật lập trình nâng cao',3),('MH039','Thiết kế giao diện người dùng',3),('MH040','Phân tích dữ liệu',4),('MH041','Kỹ thuật phần mềm',3),('MH042','Truyền thông số',3),('MH043','Điện tử y sinh',4),('MH044','Xử lý ảnh',3),('MH045','Mô phỏng và mô hình hóa',3),('MH046','Công nghệ Blockchain',3),('MH047','Hệ thống thông tin quản lý',4),('MH048','Xây dựng phần mềm mã nguồn mở',3),('MH049','Ứng dụng di động',3),('MH050','Lý thuyết thông tin',4),('MH051','Trí tuệ nhân tạo nâng cao',3),('MH052','Lập trình song song',4),('MH053','Kỹ thuật số nâng cao',3),('MH054','Quang học ứng dụng',3),('MH055','Thiết kế mạch in',4),('MH056','Điện tử viễn thông nâng cao',3),('MH057','Hệ thống điều khiển',4),('MH058','Kỹ thuật cảm biến',3),('MH059','Công nghệ IoT nâng cao',4),('MH060','Thực hành phần mềm nhúng',3);
/*!40000 ALTER TABLE `monhoc` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `quanly`
--

DROP TABLE IF EXISTS `quanly`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `quanly` (
  `id` int NOT NULL AUTO_INCREMENT,
  `username` varchar(45) DEFAULT NULL,
  `password` varchar(45) DEFAULT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=2 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `quanly`
--

LOCK TABLES `quanly` WRITE;
/*!40000 ALTER TABLE `quanly` DISABLE KEYS */;
INSERT INTO `quanly` VALUES (1,'huynh','123');
/*!40000 ALTER TABLE `quanly` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `registration`
--

DROP TABLE IF EXISTS `registration`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `registration` (
  `RegistrationId` int NOT NULL AUTO_INCREMENT,
  `MaSV` varchar(20) DEFAULT NULL,
  `MaMH` varchar(20) DEFAULT NULL,
  `RegistrationDate` timestamp NULL DEFAULT CURRENT_TIMESTAMP,
  PRIMARY KEY (`RegistrationId`),
  KEY `MaSV` (`MaSV`),
  KEY `MaMH` (`MaMH`),
  CONSTRAINT `registration_ibfk_1` FOREIGN KEY (`MaSV`) REFERENCES `sinhvien` (`MaSV`),
  CONSTRAINT `registration_ibfk_2` FOREIGN KEY (`MaMH`) REFERENCES `monhoc` (`MaMH`)
) ENGINE=InnoDB AUTO_INCREMENT=17 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `registration`
--

LOCK TABLES `registration` WRITE;
/*!40000 ALTER TABLE `registration` DISABLE KEYS */;
INSERT INTO `registration` VALUES (16,'21021597','MH0004','2024-05-30 17:23:05');
/*!40000 ALTER TABLE `registration` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `sinhvien`
--

DROP TABLE IF EXISTS `sinhvien`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `sinhvien` (
  `MaSV` varchar(10) NOT NULL,
  `HoTen` varchar(100) NOT NULL,
  `Email` varchar(45) DEFAULT NULL,
  `SDT` varchar(15) DEFAULT NULL,
  `DiaChi` varchar(255) DEFAULT NULL,
  `NgaySinh` date DEFAULT NULL,
  `MaLop` varchar(10) DEFAULT NULL,
  PRIMARY KEY (`MaSV`),
  KEY `fk_sinhvien_maLop` (`MaLop`),
  CONSTRAINT `fk_sinhvien_maLop` FOREIGN KEY (`MaLop`) REFERENCES `lop` (`MaLop`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `sinhvien`
--

LOCK TABLES `sinhvien` WRITE;
/*!40000 ALTER TABLE `sinhvien` DISABLE KEYS */;
INSERT INTO `sinhvien` VALUES ('21020730','Nguyễn Thùy Linh','21020730@vnu.edu.vn','234234324','Hà Nội','2024-05-22','DACLC2'),('21021552','Bùi Duy Hoàng Anh','21021552@vnu.edu.vn','0123987654','Thái Bình','2003-12-30','DACLC2'),('21021555','Huynh','21021555@vnu.edu.vn','042423432432','TH','2024-05-31','DACLC2'),('21021582','Nguyễn Văn Hiệp','21021582@vnu.edu.vn','03424243','Bắc Ninh','2024-05-21','DACLC2'),('21021596','Lê Phương Duy','21021596@vnu.edu.vn','0934567890','Thanh Hóa','2003-12-30','DACLC2'),('21021597','Lê Văn Huỳnh','21021597@vnu.edu.vn','0346197221','Thanh Hóa','1994-02-01','DACLC2'),('21021598','Lê Huy','21021598@vnu.edu.vn','321321312','Thanh Hóa','2003-09-01','DACLC1'),('21021599','Lê Huy Hàm','21021599@vnu.edu.vn','321321312','Hà Nội','2003-09-01','DACLC1'),('21021666','Trần Thị Ngọc Tâm','21021666@vnu.edu.vn','04304043043','Hà Nội','2003-05-29','DACLC2'),('SV00001','Nguyen Van A',NULL,NULL,NULL,NULL,'L0008'),('SV00002','Nguyen Van A',NULL,NULL,NULL,NULL,'L03'),('SV001','Phạm Văn C','SV001@gmail.com','0123456789','Hải Phòng','2000-03-03','L001'),('SV002','Lê Thị D','SV002','0987654321','Đà Nẵng','2000-04-04','L002'),('SV003','Nguyễn Văn E','SV003','0912345678','Hà Nội','2000-05-05','L003'),('SV004','Trần Thị F','SV004','0923456789','Hồ Chí Minh','2000-06-06','L004'),('SV005','Hoàng Văn G','SV005','0934567890','Cần Thơ','2000-07-07','L005'),('SV01','Phạm Thị D','SV01','0123456789','Hà Nội','2002-05-10','L01'),('SV02','Nguyễn Văn E','SV02','0987654321','TP. Hồ Chí Minh','2001-08-25','L02'),('SV03','Lê Thị F','SV03','0123987654','Đà Nẵng','2003-12-30','L03');
/*!40000 ALTER TABLE `sinhvien` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `temp_account`
--

DROP TABLE IF EXISTS `temp_account`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `temp_account` (
  `TempId` int NOT NULL AUTO_INCREMENT,
  `Email` varchar(255) DEFAULT NULL,
  `Fullname` varchar(255) DEFAULT NULL,
  `Phone` varchar(50) DEFAULT NULL,
  `Username` varchar(100) DEFAULT NULL,
  `Password` varchar(255) DEFAULT NULL,
  `OTP` varchar(255) DEFAULT NULL,
  PRIMARY KEY (`TempId`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `temp_account`
--

LOCK TABLES `temp_account` WRITE;
/*!40000 ALTER TABLE `temp_account` DISABLE KEYS */;
/*!40000 ALTER TABLE `temp_account` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2024-05-31 22:51:27
