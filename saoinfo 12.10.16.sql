CREATE DATABASE  IF NOT EXISTS `saoinfo` /*!40100 DEFAULT CHARACTER SET utf8 */;
USE `saoinfo`;
-- MySQL dump 10.13  Distrib 5.7.9, for Win64 (x86_64)
--
-- Host: localhost    Database: saoinfo
-- ------------------------------------------------------
-- Server version	5.7.9-log

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8 */;
/*!40103 SET @OLD_TIME_ZONE=@@TIME_ZONE */;
/*!40103 SET TIME_ZONE='+00:00' */;
/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;

--
-- Table structure for table `accounts`
--

DROP TABLE IF EXISTS `accounts`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `accounts` (
  `id` varchar(9) NOT NULL,
  `fname` varchar(45) DEFAULT NULL,
  `lname` varchar(45) DEFAULT NULL,
  `schoolorg` varchar(100) DEFAULT NULL,
  `usertype` varchar(45) DEFAULT NULL,
  `username` varchar(45) NOT NULL,
  `password` varchar(45) DEFAULT NULL,
  PRIMARY KEY (`id`,`username`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `accounts`
--

LOCK TABLES `accounts` WRITE;
/*!40000 ALTER TABLE `accounts` DISABLE KEYS */;
INSERT INTO `accounts` VALUES ('13-02321','Christian Angelo','Umali','Scitech','admin','admin','admin');
/*!40000 ALTER TABLE `accounts` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `events`
--

DROP TABLE IF EXISTS `events`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `events` (
  `eventid` varchar(255) NOT NULL,
  `date` date NOT NULL,
  `location` varchar(100) NOT NULL,
  `events` longtext NOT NULL,
  `starttime` time NOT NULL,
  `endtime` time NOT NULL,
  `school` varchar(100) NOT NULL,
  `kpi` varchar(45) DEFAULT NULL,
  `noa` varchar(45) DEFAULT NULL,
  `remarks` varchar(45) DEFAULT NULL,
  PRIMARY KEY (`eventid`,`location`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `events`
--

LOCK TABLES `events` WRITE;
/*!40000 ALTER TABLE `events` DISABLE KEYS */;
INSERT INTO `events` VALUES ('10122016-194815','2016-10-12','ISC Mezzanine #1','Dine','06:00:00','07:00:00','School of Accountancy and Management','IGA','Academic Related',''),('10122016-777353','2016-10-12','FGH Lanai','Extraction of shits','08:00:00','08:30:00','School of Medical Technology','IGA','Academic Related',''),('10122016-833967','2016-10-12','Friends Cafe','Eating','07:00:00','08:00:00','School of Nutrition and Hospitality Management','CSA','Academic Related',''),('10122016-876718','2016-10-12','CARMEN DE LUNA (CDL)','Naks naman','13:00:00','16:00:00','School of Dentistry','IGA','Academic Related','');
/*!40000 ALTER TABLE `events` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `saoevent`
--

DROP TABLE IF EXISTS `saoevent`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `saoevent` (
  `eventid` int(11) NOT NULL,
  `Date` date NOT NULL,
  `Location` varchar(100) DEFAULT NULL,
  `Events` varchar(2000) DEFAULT NULL,
  `TimeFrom` time NOT NULL,
  `TimeTo` time NOT NULL,
  `school` varchar(1000) DEFAULT NULL,
  `kpi` varchar(45) NOT NULL,
  `noa` varchar(45) NOT NULL,
  `remarks` varchar(45) DEFAULT NULL,
  PRIMARY KEY (`eventid`),
  UNIQUE KEY `eventid_UNIQUE` (`eventid`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `saoevent`
--

LOCK TABLES `saoevent` WRITE;
/*!40000 ALTER TABLE `saoevent` DISABLE KEYS */;
INSERT INTO `saoevent` VALUES (1,'2015-09-14','ISC 302','CS 116','07:00:00','09:00:00',NULL,'','',NULL),(2,'2015-09-14','LAHANNX 303','Hum 12','09:00:00','10:00:00',NULL,'','',NULL),(3,'2015-09-14','ISC 301','IT 124','11:00:00','01:00:00',NULL,'','',NULL),(4,'2015-09-14','ISC 303','CS 114','01:00:00','03:00:00',NULL,'','',NULL),(5,'2015-09-15','SDV 404','SocArts 11 (Lab)','07:00:00','10:00:00',NULL,'','',NULL),(6,'2015-09-15','DCTH 307','Accounting 104','11:30:00','01:00:00',NULL,'','',NULL),(7,'2015-09-16','LAHANNX 303','Hum 12','07:00:00','09:00:00',NULL,'','',NULL),(9,'2015-09-19','Chapel','Mass','03:00:00','05:00:00',NULL,'','',NULL),(10,'2015-09-19','SAC','I dont know','03:00:00','05:00:00',NULL,'','',NULL),(11,'2015-09-19','LA Audtiorium','Sabugan?','03:00:00','05:00:00',NULL,'','',NULL),(12,'2015-09-20','Church','Sunday mass','07:00:00','09:00:00',NULL,'','',NULL),(13,'2015-09-27','House','Improving System','08:00:00','09:00:00',NULL,'','',NULL),(14,'2015-09-27','House','Fixing self','07:00:00','09:00:00',NULL,'','',NULL),(15,'2015-09-28','ISC 302','Web Dev','07:00:00','09:00:00',NULL,'','',NULL),(16,'2015-09-28','LAHANNX 303','Hum12','09:00:00','10:00:00',NULL,'','',NULL),(17,'2015-09-28','ISC 301','SAD','11:00:00','01:00:00',NULL,'','',NULL),(18,'2015-09-28','ISC 303','JAVA LEC','01:00:00','03:00:00',NULL,'','',NULL),(19,'2015-09-29','SDV 402','SOCARTS LAB','07:00:00','10:00:00',NULL,'','',NULL),(20,'2015-09-29','DCTH 307','Accounting 104','11:30:00','01:00:00',NULL,'','',NULL),(21,'2015-09-30','ISC 401','Cisco 2','07:00:00','09:00:00',NULL,'','',NULL),(22,'2015-09-30','LAHANNX 303','Hum12','09:00:00','10:00:00',NULL,'','',NULL),(23,'2015-09-30','LAH 311','ForLang 2','10:00:00','11:30:00',NULL,'','',NULL),(27,'2015-09-21','SAC','Woooo','07:00:00','08:00:00','College of Dentistry','','',NULL),(28,'2015-09-21','SAC','jqwlkejqwlkjelqkw','11:43:00','11:43:00','College of Dentistry','','',NULL),(30,'2015-09-21','Chapel','Woooo','08:00:00','09:00:00','College of Dentistry','CSA','Co/Extra-Curricular Activity',NULL),(31,'2015-09-28','SAC','Woooo','08:00:00','09:00:00','College of Dentistry','IGA','Academic Related',NULL);
/*!40000 ALTER TABLE `saoevent` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `saoevent2015-2016`
--

DROP TABLE IF EXISTS `saoevent2015-2016`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `saoevent2015-2016` (
  `eventid` int(11) NOT NULL,
  `Date` date NOT NULL,
  `Location` varchar(100) DEFAULT NULL,
  `Events` varchar(2000) DEFAULT NULL,
  `TimeFrom` time NOT NULL,
  `TimeTo` time NOT NULL,
  `school` varchar(100) DEFAULT NULL,
  `kpi` varchar(45) NOT NULL,
  `noa` varchar(45) NOT NULL,
  `remarks` varchar(45) DEFAULT NULL,
  PRIMARY KEY (`eventid`),
  UNIQUE KEY `eventid_UNIQUE` (`eventid`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `saoevent2015-2016`
--

LOCK TABLES `saoevent2015-2016` WRITE;
/*!40000 ALTER TABLE `saoevent2015-2016` DISABLE KEYS */;
INSERT INTO `saoevent2015-2016` VALUES (2,'2015-09-24','SAC','Malupitan','10:00:00','11:00:00','College of Graduate School','IGA','Academic Related',NULL),(3,'2015-09-30','MIAD','asd','02:12:00','05:12:00','College of Science and Technology','COA','Community Outreach Program',NULL),(4,'2015-09-30','maestro osang','asd','02:12:00','05:12:00','College of Science and Technology','COA','Community Outreach Program',NULL),(5,'2015-09-29','Chapel','christmas party','01:00:00','02:00:00','College of Accountancy and Management','IGA','Academic Related',NULL),(6,'2015-09-28','miad','hello','02:00:00','05:00:00','Association of Tourism Students (ATS)','IGA','Co/Extra-Curricular Activity',NULL),(7,'2015-09-28','LA Audtiorium','Medtech Orientation','01:00:00','02:00:00','College of Medical Technology','IGA','Academic Related',NULL),(8,'2015-09-29','LA Audtiorium','Dentistry Orientaion','01:00:00','02:00:00','College of Dentistry','IGA','Academic Related',NULL),(9,'2015-09-30','LA Audtiorium','Educ Orientation','01:00:00','02:00:00','College of Education—Liberal Arts—Music—Social Work','IGA','Academic Related',NULL),(10,'2015-10-01','PHL Lanai','Optometry Orientation','01:00:00','02:00:00','Junior Financial Executives (JFINEX)','IGA','Academic Related',''),(11,'2015-10-02','FGH Lanai','Nursing Orientation','01:00:00','02:00:00','School of Nursing','IGA','Academic Related',''),(12,'2015-10-03','LA Auditorium','hello','02:00:00','03:00:00','College of Accountancy and Management','IGA','Academic Related',''),(13,'2015-10-04','LA Auditorium','hello','02:00:00','03:00:00','College of Accountancy and Management','IGA','Academic Related','Cancelled'),(17,'2015-10-08','ISC Mezzanine #2','aaaa','09:56:00','11:56:00','jpcs','LTS','Academic Related',''),(18,'2015-10-08','North Quadrangle','aaaa','09:56:00','11:56:00','jpcs','LTS','Academic Related',''),(19,'2015-10-08','LA Auditorium','aaaa','09:56:00','10:56:00','Math Club','LTS','Academic Related',''),(20,'2015-10-01','TechCenter Lanai with Lights','123','09:56:00','10:56:00','Philippine Society of Medical Technology Students (PHISMETS)','IGA','Academic Related',''),(21,'2015-10-03','PILAR HIDALGO LIM HALL (PHL)','hello','09:56:00','10:56:00','Association of Tourism Students (ATS)','IGA','Academic Related','');
/*!40000 ALTER TABLE `saoevent2015-2016` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `saoevent2016-2017`
--

DROP TABLE IF EXISTS `saoevent2016-2017`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `saoevent2016-2017` (
  `eventid` int(11) NOT NULL,
  `Date` date NOT NULL,
  `Location` varchar(100) DEFAULT NULL,
  `Events` varchar(2000) DEFAULT NULL,
  `TimeFrom` time NOT NULL,
  `TimeTo` time NOT NULL,
  `school` varchar(100) DEFAULT NULL,
  `kpi` varchar(45) NOT NULL,
  `noa` varchar(45) NOT NULL,
  `remarks` varchar(45) DEFAULT NULL,
  PRIMARY KEY (`eventid`),
  UNIQUE KEY `eventid_UNIQUE` (`eventid`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `saoevent2016-2017`
--

LOCK TABLES `saoevent2016-2017` WRITE;
/*!40000 ALTER TABLE `saoevent2016-2017` DISABLE KEYS */;
/*!40000 ALTER TABLE `saoevent2016-2017` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `saoevent2017-2018`
--

DROP TABLE IF EXISTS `saoevent2017-2018`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `saoevent2017-2018` (
  `eventid` int(11) NOT NULL,
  `Date` date NOT NULL,
  `Location` varchar(100) DEFAULT NULL,
  `Events` varchar(2000) DEFAULT NULL,
  `TimeFrom` time NOT NULL,
  `TimeTo` time NOT NULL,
  `school` varchar(100) DEFAULT NULL,
  `kpi` varchar(45) NOT NULL,
  `noa` varchar(45) NOT NULL,
  `remarks` varchar(45) DEFAULT NULL,
  PRIMARY KEY (`eventid`),
  UNIQUE KEY `eventid_UNIQUE` (`eventid`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `saoevent2017-2018`
--

LOCK TABLES `saoevent2017-2018` WRITE;
/*!40000 ALTER TABLE `saoevent2017-2018` DISABLE KEYS */;
/*!40000 ALTER TABLE `saoevent2017-2018` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `saoevent2018-2019`
--

DROP TABLE IF EXISTS `saoevent2018-2019`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `saoevent2018-2019` (
  `eventid` int(11) NOT NULL,
  `Date` date NOT NULL,
  `Location` varchar(100) DEFAULT NULL,
  `Events` varchar(2000) DEFAULT NULL,
  `TimeFrom` time NOT NULL,
  `TimeTo` time NOT NULL,
  `school` varchar(100) DEFAULT NULL,
  `kpi` varchar(45) NOT NULL,
  `noa` varchar(45) NOT NULL,
  `remarks` varchar(45) DEFAULT NULL,
  PRIMARY KEY (`eventid`),
  UNIQUE KEY `eventid_UNIQUE` (`eventid`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `saoevent2018-2019`
--

LOCK TABLES `saoevent2018-2019` WRITE;
/*!40000 ALTER TABLE `saoevent2018-2019` DISABLE KEYS */;
/*!40000 ALTER TABLE `saoevent2018-2019` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `saoevent2019-2020`
--

DROP TABLE IF EXISTS `saoevent2019-2020`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `saoevent2019-2020` (
  `eventid` int(11) NOT NULL,
  `Date` date NOT NULL,
  `Location` varchar(100) DEFAULT NULL,
  `Events` varchar(2000) DEFAULT NULL,
  `TimeFrom` time NOT NULL,
  `TimeTo` time NOT NULL,
  `school` varchar(100) DEFAULT NULL,
  `kpi` varchar(45) NOT NULL,
  `noa` varchar(45) NOT NULL,
  `remarks` varchar(45) DEFAULT NULL,
  PRIMARY KEY (`eventid`),
  UNIQUE KEY `eventid_UNIQUE` (`eventid`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `saoevent2019-2020`
--

LOCK TABLES `saoevent2019-2020` WRITE;
/*!40000 ALTER TABLE `saoevent2019-2020` DISABLE KEYS */;
/*!40000 ALTER TABLE `saoevent2019-2020` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `saoevent2020-2021`
--

DROP TABLE IF EXISTS `saoevent2020-2021`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `saoevent2020-2021` (
  `eventid` int(11) NOT NULL,
  `Date` date NOT NULL,
  `Location` varchar(100) DEFAULT NULL,
  `Events` varchar(2000) DEFAULT NULL,
  `TimeFrom` time NOT NULL,
  `TimeTo` time NOT NULL,
  `school` varchar(100) DEFAULT NULL,
  `kpi` varchar(45) NOT NULL,
  `noa` varchar(45) NOT NULL,
  `remarks` varchar(45) DEFAULT NULL,
  PRIMARY KEY (`eventid`),
  UNIQUE KEY `eventid_UNIQUE` (`eventid`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `saoevent2020-2021`
--

LOCK TABLES `saoevent2020-2021` WRITE;
/*!40000 ALTER TABLE `saoevent2020-2021` DISABLE KEYS */;
/*!40000 ALTER TABLE `saoevent2020-2021` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `saoreminder`
--

DROP TABLE IF EXISTS `saoreminder`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `saoreminder` (
  `saonotenumber` int(11) NOT NULL,
  `saonote` varchar(2000) DEFAULT NULL,
  `saoreminderdate` date DEFAULT NULL,
  PRIMARY KEY (`saonotenumber`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `saoreminder`
--

LOCK TABLES `saoreminder` WRITE;
/*!40000 ALTER TABLE `saoreminder` DISABLE KEYS */;
INSERT INTO `saoreminder` VALUES (2,'Whoopjjjj','2015-09-09'),(3,'Playing Shogun 2','2015-09-10'),(4,'Cisco Gaming','2015-09-16'),(5,'Hum12 Lesson','2015-09-16'),(6,'ForLang 12 Lesson','2015-09-16'),(7,'CS114 Quiz','2015-09-16'),(8,'Thesis Checking','2015-09-16'),(9,'Accounting ','2015-09-17'),(10,'CS116 Blog Layout Discussion  ','2015-09-17'),(11,'Finished adding logic in delete buttons','2015-09-17'),(12,'Bugs are the ffg:\n- Filtering date in calendar tab','2015-09-17'),(13,'iuiueqw','2015-09-17'),(14,'hello','2015-09-19'),(15,'hey\n','2015-09-21'),(16,'bongga','2015-09-25'),(17,'hello','2015-10-03');
/*!40000 ALTER TABLE `saoreminder` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `saouserinfo`
--

DROP TABLE IF EXISTS `saouserinfo`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `saouserinfo` (
  `id` varchar(50) NOT NULL,
  `college` varchar(100) DEFAULT NULL,
  `FName` varchar(50) DEFAULT NULL,
  `MName` varchar(50) DEFAULT NULL,
  `LName` varchar(50) DEFAULT NULL,
  `UName` varchar(50) DEFAULT NULL,
  `Password` varchar(50) DEFAULT NULL,
  `usertype` varchar(45) DEFAULT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `saouserinfo`
--

LOCK TABLES `saouserinfo` WRITE;
/*!40000 ALTER TABLE `saouserinfo` DISABLE KEYS */;
INSERT INTO `saouserinfo` VALUES ('09-03609','Dental Clinicians Club (DCC)','Hadrian','Gempes','Muñoz','Yanyan23624','2','Admin'),('12-03068','College of Science and Technology','miguel exequiel','hizon','tecson','tecky','tecky','Guest'),('13-02321','College of Science and Technology','Christian Angelo','Reyes','Umali','SuperAdmin','SuperAdmin','SuperAdmin'),('13-02324','College of Accountancy and Management','Lebron','','James','lebron','james','Guest'),('13-02325','College of Dentistry','Paul','','Johnson','paul','johnson','Guest'),('13-02327','College of Medical Technology','Magic','','Johnson','magic','johnson','Guest'),('13-02328','College of Nursing','Kakashi','Sensei','WhiteFang','kakashi','whitefang','Guest'),('13-02329','College of Nutrition and Hospitality Management','Naruto','','Ozumaki','naruto','poku','Guest'),('13-02330','College of Nutrition and Hospitality Management','Alyssa Marielle','Reyes','Umali','alyssa','umali','Guest'),('13-02331','College of Optometry','Alyanna Marielle','Reyes','Umali','alyanna','umali','Guest'),('13-02332','College of Pharmacy','Janisse Crizhna','Punzalan','Dinglasan','janisse','dinglasan','Guest'),('13-02334','College of Nursing','Maria Analisa','Reyes','Umali','analisa','umali','Guest'),('13-02335','College of Accountancy and Management','Randy','Paguio','Umali','randy','umali','Guest'),('13-02815','School of Science and Technology','Kail Anrew','Rivera','Hamili','guest','guest','Guest'),('13-03987','College of Science and Technology','Demar','Salcedo','Lumaque','dime_dropper','deezydemz','Admin');
/*!40000 ALTER TABLE `saouserinfo` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tbl_kpi`
--

DROP TABLE IF EXISTS `tbl_kpi`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `tbl_kpi` (
  `KPI` varchar(45) NOT NULL,
  `kpi_id` varchar(45) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tbl_kpi`
--

LOCK TABLES `tbl_kpi` WRITE;
/*!40000 ALTER TABLE `tbl_kpi` DISABLE KEYS */;
INSERT INTO `tbl_kpi` VALUES ('NOA','01102016-32071');
/*!40000 ALTER TABLE `tbl_kpi` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tbl_locations`
--

DROP TABLE IF EXISTS `tbl_locations`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `tbl_locations` (
  `Location` varchar(100) NOT NULL,
  `loc_id` varchar(255) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tbl_locations`
--

LOCK TABLES `tbl_locations` WRITE;
/*!40000 ALTER TABLE `tbl_locations` DISABLE KEYS */;
INSERT INTO `tbl_locations` VALUES ('ISC 501','48102016-67104');
/*!40000 ALTER TABLE `tbl_locations` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tbl_organizations_school`
--

DROP TABLE IF EXISTS `tbl_organizations_school`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `tbl_organizations_school` (
  `school` varchar(1000) NOT NULL,
  `orgid` varchar(255) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tbl_organizations_school`
--

LOCK TABLES `tbl_organizations_school` WRITE;
/*!40000 ALTER TABLE `tbl_organizations_school` DISABLE KEYS */;
INSERT INTO `tbl_organizations_school` VALUES ('JPCS','34102016-5834');
/*!40000 ALTER TABLE `tbl_organizations_school` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2016-12-10 10:04:46
