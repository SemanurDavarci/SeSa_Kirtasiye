-- MySQL dump 10.13  Distrib 8.0.34, for Win64 (x86_64)
--
-- Host: localhost    Database: sesa_kirtasiye
-- ------------------------------------------------------
-- Server version	8.2.0

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
-- Table structure for table `sesa_kategoriler`
--

DROP TABLE IF EXISTS `sesa_kategoriler`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `sesa_kategoriler` (
  `KategoriID` int NOT NULL AUTO_INCREMENT,
  `KategoriAdi` varchar(50) NOT NULL,
  PRIMARY KEY (`KategoriID`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `sesa_kategoriler`
--

LOCK TABLES `sesa_kategoriler` WRITE;
/*!40000 ALTER TABLE `sesa_kategoriler` DISABLE KEYS */;
/*!40000 ALTER TABLE `sesa_kategoriler` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `sesa_musteriler`
--

DROP TABLE IF EXISTS `sesa_musteriler`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `sesa_musteriler` (
  `MusteriID` int NOT NULL AUTO_INCREMENT,
  `MusteriAdi` varchar(100) NOT NULL,
  `MusteriSoyadi` varchar(100) NOT NULL,
  `MusteriTelefon` varchar(25) NOT NULL,
  `MusteriMail` varchar(200) NOT NULL,
  `MusteriAdres` varchar(250) NOT NULL,
  PRIMARY KEY (`MusteriID`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `sesa_musteriler`
--

LOCK TABLES `sesa_musteriler` WRITE;
/*!40000 ALTER TABLE `sesa_musteriler` DISABLE KEYS */;
/*!40000 ALTER TABLE `sesa_musteriler` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `sesa_odemeler`
--

DROP TABLE IF EXISTS `sesa_odemeler`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `sesa_odemeler` (
  `OdemeID` int NOT NULL AUTO_INCREMENT,
  `MusteriID` int NOT NULL,
  `OdemeTarihi` date NOT NULL,
  `OdemeTutari` float NOT NULL,
  `OdemeTuru` varchar(50) NOT NULL,
  `Aciklama` varchar(250) NOT NULL,
  PRIMARY KEY (`OdemeID`),
  KEY `MusteriID` (`MusteriID`),
  CONSTRAINT `sesa_odemeler_ibfk_1` FOREIGN KEY (`MusteriID`) REFERENCES `sesa_musteriler` (`MusteriID`) ON DELETE CASCADE ON UPDATE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `sesa_odemeler`
--

LOCK TABLES `sesa_odemeler` WRITE;
/*!40000 ALTER TABLE `sesa_odemeler` DISABLE KEYS */;
/*!40000 ALTER TABLE `sesa_odemeler` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `sesa_satislar`
--

DROP TABLE IF EXISTS `sesa_satislar`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `sesa_satislar` (
  `SatisID` int NOT NULL AUTO_INCREMENT,
  `MusteriID` int NOT NULL,
  `UrunID` int NOT NULL,
  `SatisTarihi` datetime NOT NULL,
  `SatisAdeti` float NOT NULL,
  `SatisFiyati` float NOT NULL,
  PRIMARY KEY (`SatisID`),
  KEY `MusteriID` (`MusteriID`),
  KEY `UrunID` (`UrunID`),
  CONSTRAINT `sesa_satislar_ibfk_1` FOREIGN KEY (`MusteriID`) REFERENCES `sesa_musteriler` (`MusteriID`) ON DELETE CASCADE ON UPDATE CASCADE,
  CONSTRAINT `sesa_satislar_ibfk_2` FOREIGN KEY (`UrunID`) REFERENCES `sesa_urunler` (`UrunID`) ON DELETE CASCADE ON UPDATE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `sesa_satislar`
--

LOCK TABLES `sesa_satislar` WRITE;
/*!40000 ALTER TABLE `sesa_satislar` DISABLE KEYS */;
/*!40000 ALTER TABLE `sesa_satislar` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `sesa_urunler`
--

DROP TABLE IF EXISTS `sesa_urunler`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `sesa_urunler` (
  `UrunID` int NOT NULL AUTO_INCREMENT,
  `UrunAdi` varchar(200) NOT NULL,
  `KategoriID` int DEFAULT NULL,
  `UrunBirimFiyat` float NOT NULL,
  `UrunDetay` varchar(250) NOT NULL,
  `UrunStokMiktari` int NOT NULL,
  PRIMARY KEY (`UrunID`),
  KEY `KategoriID` (`KategoriID`),
  CONSTRAINT `sesa_urunler_ibfk_1` FOREIGN KEY (`KategoriID`) REFERENCES `sesa_kategoriler` (`KategoriID`) ON DELETE SET NULL ON UPDATE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `sesa_urunler`
--

LOCK TABLES `sesa_urunler` WRITE;
/*!40000 ALTER TABLE `sesa_urunler` DISABLE KEYS */;
/*!40000 ALTER TABLE `sesa_urunler` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2024-01-11 20:30:27
