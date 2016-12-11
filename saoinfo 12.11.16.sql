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
INSERT INTO `saoevent2015-2016` VALUES (1,'2016-12-11','TechCenter Lanai with Lights','test','11:00:00','12:00:00','Social Sciences Society (SSS)','IGA','Academic Related','');
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
INSERT INTO `tbl_kpi` VALUES ('IGA','16112016-97826'),('CSA','16112016-29372'),('LTS','17112016-25152'),('SDP','17112016-80081'),('SRA','17112016-71100'),('COA','17112016-56084'),('HWP','17112016-29402');
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
INSERT INTO `tbl_locations` VALUES ('CARMEN DE LUNA (CDL)','59112016-72116'),('Multimedia Instructional Room (MIR)','00112016-73002'),('LIBRADA AVELINO HALL (LAH)','00112016-91808'),('Chapel/Adoration Chapel','00112016-52116'),('Executive Meeting Room (EMR)','00112016-82240'),('LAH Seminar Room #1','01112016-14393'),('LAH Seminar Room #2','01112016-17419'),('LAH Seminar Room #3','01112016-75001'),('GENEROSA DE LEON SCIENCE CENTER (GDLSC)','01112016-41833'),('Bulwagang Maestra Osang (BMO)','01112016-23357'),('SOFIA DE VEYRA HALL (SDVH)','01112016-3359'),('SDV Conference Room (SDVCR)','01112016-49337'),('SDV Lanai','03112016-74671'),('FELISA FRANCISCO HALL (FFH)','03112016-62559'),('Assembly Hall (3rd Flr)','03112016-56262'),('MARIA VILLACERAN HALL (MVH)','03112016-66417'),('LA Auditorium','03112016-21855'),('MVH Lanai','04112016-36980'),('DIONISIO C. TIONGCO (DCT)','04112016-17510'),('Student Activity Center (Ground flr)','04112016-688'),('Student Activity Center (Second flr)','04112016-29054'),('PILAR HIDALGO LIM HALL (PHL)','04112016-44306'),('PHL Lanai','04112016-40480'),('TECHNOLOGY CENTER','04112016-11320'),('TechCenter Gym','05112016-79816'),('TechCenter Lanai with Lights','05112016-46979'),('FGH DENTRISTRY','05112016-7591'),('INFORMATION SCIENCE CENTER','05112016-56767'),('Friends Cafe','05112016-32619'),('ISC Mezzanine #1','05112016-17667');
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
INSERT INTO `tbl_organizations_school` VALUES ('School of Accountancy and Management','10112016-78591'),('School of Dentistry','11112016-19098'),('School of Education—Liberal Arts—Music—Social Work','11112016-88200'),('School of Medical Technology','11112016-73682'),('School of Nursing','11112016-78125'),('School of Nutrition and Hospitality Management','11112016-26967'),('School of Optometry','11112016-64404'),('School of Pharmacy','11112016-54894'),('School of Science and Technology','11112016-96521'),('School of Graduate School','12112016-72700'),('School of Senior High School (Grades 11 & 12)','12112016-84997'),('Community Outreach Movement Proactive Student Services (COMPASS)','12112016-24070'),('Dramatic Guild (DG)','12112016-70938'),('English Guild','12112016-58515'),('Honors Society (HonSoc)','12112016-43989'),('International Students Association (ISA)','12112016-55657'),('Math Club','12112016-18846'),('Oratorical and Debate Society (ORADES)','13112016-8885'),('Photographers Club (Photo Club)','13112016-723'),('Red Cross Youth (RCY)','13112016-56888'),('Science Club','13112016-88123'),('Student Catholic Action (SCA)','13112016-91228'),('Social Sciences Society (SSS)','14112016-99123'),('CEU Student Chapter of the American Society of Microbiology','14112016-39715'),('CEU Marketing Society (CEMARS)','14112016-13767'),('Junior Financial Executives (JFINEX)','14112016-53956'),('Junior Philippine Institute of Accountants (JPIA)','14112016-60671'),('Management Students Association (MASA)','14112016-9151'),('Dental Clinicians Club (DCC)','14112016-82028'),('Philippine Dental Students Association (PDSA)','14112016-28955'),('Association of Tourism Students (ATS)','14112016-71304'),('Association of Hotel & Restaurants Management Students (AHRMS)','15112016-92790'),('Philippine Association of Nutritionists (PAN-DELTA)','15112016-78923'),('Philippine Nursing Research Society (PNRS)','15112016-26782'),('Optometry Clinicians Club (OCC)','15112016-82818'),('Junior Philippine Pharmacists Association (JPPhA)','15112016-96413'),('CEU Psychology Society (Psych Soc)','15112016-49332'),('Junior Philippine Computer Society (JPCS)','15112016-44890'),('Philippine Society of Medical Technology Students (PHISMETS)','15112016-78197'),('CEU Communication Arts Society (CoMaSoc)','15112016-15483'),('Junior Social Work Association of the Philippines (JSWAP)','16112016-18324');
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

-- Dump completed on 2016-12-11 13:26:00
