CREATE DATABASE  IF NOT EXISTS `ceuratingforms` /*!40100 DEFAULT CHARACTER SET latin1 COLLATE latin1_general_cs */;
USE `ceuratingforms`;
-- MySQL dump 10.13  Distrib 5.7.12, for Win32 (AMD64)
--
-- Host: localhost    Database: ceuratingforms
-- ------------------------------------------------------
-- Server version	5.6.35-log

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
-- Table structure for table `allrf`
--

DROP TABLE IF EXISTS `allrf`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `allrf` (
  `idallrf` int(11) NOT NULL AUTO_INCREMENT,
  `activity_title` varchar(45) COLLATE latin1_general_cs NOT NULL,
  `point` int(11) NOT NULL,
  `weight` int(11) NOT NULL,
  `incp` int(11) DEFAULT NULL,
  `total_point` int(11) NOT NULL,
  PRIMARY KEY (`idallrf`)
) ENGINE=InnoDB AUTO_INCREMENT=188 DEFAULT CHARSET=latin1 COLLATE=latin1_general_cs;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `allrf`
--

LOCK TABLES `allrf` WRITE;
/*!40000 ALTER TABLE `allrf` DISABLE KEYS */;
INSERT INTO `allrf` VALUES (181,'poeijrpfwesds',5,9,NULL,45),(182,'kfjdsljflslhjfe',5,10,NULL,50),(183,'kfjdsljflslhjfe',5,0,NULL,50),(184,'kjhfskdhfksd',5,10,NULL,50),(185,'kjfhsdkljfsdklf',5,10,NULL,50),(186,'123rrfdsfs',5,20,NULL,100),(187,'Marshall',31,5,NULL,155);
/*!40000 ALTER TABLE `allrf` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `points_ranges`
--

DROP TABLE IF EXISTS `points_ranges`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `points_ranges` (
  `award` varchar(10) COLLATE latin1_general_cs NOT NULL DEFAULT '',
  `minPoint` int(11) DEFAULT NULL,
  PRIMARY KEY (`award`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1 COLLATE=latin1_general_cs;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `points_ranges`
--

LOCK TABLES `points_ranges` WRITE;
/*!40000 ALTER TABLE `points_ranges` DISABLE KEYS */;
INSERT INTO `points_ranges` VALUES ('Bronze',1000),('Gold',7000),('Silver',3000);
/*!40000 ALTER TABLE `points_ranges` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `pointsinfo`
--

DROP TABLE IF EXISTS `pointsinfo`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `pointsinfo` (
  `StudNo` varchar(10) COLLATE latin1_general_cs NOT NULL,
  `TotalPoints` int(11) NOT NULL,
  `Remarks` varchar(10) CHARACTER SET latin1 DEFAULT NULL,
  PRIMARY KEY (`StudNo`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1 COLLATE=latin1_general_cs;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `pointsinfo`
--

LOCK TABLES `pointsinfo` WRITE;
/*!40000 ALTER TABLE `pointsinfo` DISABLE KEYS */;
INSERT INTO `pointsinfo` VALUES ('',0,' '),('1',750,''),('13-01913',125,''),('14-00978',52064,'Gold'),('14-01122',105,''),('14-02316',338,''),('15-01827',0,' ');
/*!40000 ALTER TABLE `pointsinfo` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `ratingform1`
--

DROP TABLE IF EXISTS `ratingform1`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `ratingform1` (
  `rfid` int(11) NOT NULL AUTO_INCREMENT,
  `StudentNo` varchar(10) CHARACTER SET latin1 NOT NULL,
  `titleAct` varchar(100) COLLATE latin1_general_cs NOT NULL,
  `lvlPerf` varchar(100) COLLATE latin1_general_cs NOT NULL,
  `lvlAct` varchar(100) COLLATE latin1_general_cs NOT NULL,
  `posi` varchar(100) COLLATE latin1_general_cs NOT NULL,
  `points` int(11) NOT NULL,
  `weight` int(11) NOT NULL,
  `totalPoints` int(11) NOT NULL,
  `appr` int(11) NOT NULL,
  PRIMARY KEY (`rfid`)
) ENGINE=InnoDB AUTO_INCREMENT=17 DEFAULT CHARSET=latin1 COLLATE=latin1_general_cs;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `ratingform1`
--

LOCK TABLES `ratingform1` WRITE;
/*!40000 ALTER TABLE `ratingform1` DISABLE KEYS */;
INSERT INTO `ratingform1` VALUES (1,'14-00978','poeijrpfwesds','Excellent','College Wide','Contestant',5,9,45,1),(2,'14-01122','asd','Moderate','Supervised','Organizer/Steering Committee Member',3,10,30,1),(3,'14-01122','ffff','Excellent','College Wide','Team Leader',5,9,45,1),(4,'14-00978','kfjdsljflslhjfe','Excellent','College Wide','Over-all Chairman',5,10,50,1),(5,'14-00978','kfjdsljflslhjfe','Excellent','College Wide','Over-all Chairman',5,0,50,1),(6,'14-00978','kjhfskdhfksd','Excellent','College Wide','Over-all Chairman',5,10,50,1),(7,'14-00978','kjfhsdkljfsdklf','Excellent','College Wide','Over-all Chairman',5,10,50,1),(8,'14-00978','fdksjfsdlkjflsdj','Excellent','College Wide','Over-all Chairman',5,10,50,0),(9,'14-00978','hkzjhzdkfjhsdkjfhs','Excellent','College Wide','Over-all Chairman',5,10,50,0),(10,'13-01913','dkjflskj','Excellent','International','Representative',5,25,125,1),(11,'1','kjbhfhgfjh','Excellent','College Wide','Emcee',5,8,40,1),(12,'14-00978','123rrfdsfs','Excellent','University Wide','Over-all Co-Chairman',5,20,100,1),(13,'15-01827','HELLLO!!!!','Superior','National','Steering Committee Member',4,27,108,0),(14,'15-01827','fsad','Very Satisfactory','University Wide','Working Committee Co-Chairman',3,12,36,0),(15,'14-00978','12341','Excellent','University Wide','Emcee',5,12,60,1),(16,'14-02316','12312','Excellent','University Wide','Over-all Chairman',5,20,100,1);
/*!40000 ALTER TABLE `ratingform1` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `ratingform2`
--

DROP TABLE IF EXISTS `ratingform2`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `ratingform2` (
  `rfid` int(11) NOT NULL AUTO_INCREMENT,
  `StudentNo` varchar(10) COLLATE latin1_general_cs NOT NULL,
  `TitleAct` varchar(100) COLLATE latin1_general_cs NOT NULL,
  `ExtInvo` varchar(20) COLLATE latin1_general_cs NOT NULL,
  `ActStat` varchar(50) COLLATE latin1_general_cs NOT NULL,
  `Super` varchar(50) COLLATE latin1_general_cs NOT NULL,
  `PosRole` varchar(100) COLLATE latin1_general_cs NOT NULL,
  `Points` int(11) NOT NULL,
  `Weight` int(11) NOT NULL,
  `TWP` int(11) NOT NULL,
  `appr` int(11) DEFAULT NULL,
  PRIMARY KEY (`rfid`)
) ENGINE=InnoDB AUTO_INCREMENT=5 DEFAULT CHARSET=latin1 COLLATE=latin1_general_cs;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `ratingform2`
--

LOCK TABLES `ratingform2` WRITE;
/*!40000 ALTER TABLE `ratingform2` DISABLE KEYS */;
INSERT INTO `ratingform2` VALUES (1,'14-01122','plpl','Very High','Supervised','Off-Campus','Working Committee Co-Chairman',5,6,30,1),(2,'14-02316','3425','High','Supervised','In-Campus','Over-all Co-Chairman',4,12,48,1),(3,'14-00978','df,ljdlksajdlaj','Very High','Supervised','Off-Campus','Coordinator',5,10,50,0),(4,'14-02316','123','Very High','Supervised','Off-Campus','Over-all Chairman',5,10,50,1);
/*!40000 ALTER TABLE `ratingform2` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `ratingform3`
--

DROP TABLE IF EXISTS `ratingform3`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `ratingform3` (
  `rfid` int(11) NOT NULL AUTO_INCREMENT,
  `StudentNo` varchar(10) COLLATE latin1_general_cs NOT NULL,
  `TitleAct` varchar(100) COLLATE latin1_general_cs NOT NULL,
  `NatAct` varchar(100) COLLATE latin1_general_cs NOT NULL,
  `ActStat` varchar(50) CHARACTER SET latin1 NOT NULL,
  `Awards` varchar(5) COLLATE latin1_general_cs DEFAULT NULL,
  `LvlAct` varchar(50) COLLATE latin1_general_cs NOT NULL,
  `Points` int(11) NOT NULL,
  `Weight` int(11) NOT NULL,
  `TWP` int(11) NOT NULL,
  `appr` int(11) DEFAULT NULL,
  PRIMARY KEY (`rfid`)
) ENGINE=InnoDB AUTO_INCREMENT=2 DEFAULT CHARSET=latin1 COLLATE=latin1_general_cs;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `ratingform3`
--

LOCK TABLES `ratingform3` WRITE;
/*!40000 ALTER TABLE `ratingform3` DISABLE KEYS */;
INSERT INTO `ratingform3` VALUES (1,'14-02316','231231','Written Material','With Awards','1','College Wide',10,15,0,1);
/*!40000 ALTER TABLE `ratingform3` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `ratingform4`
--

DROP TABLE IF EXISTS `ratingform4`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `ratingform4` (
  `rfid` int(11) NOT NULL AUTO_INCREMENT,
  `StudentNo` varchar(10) COLLATE latin1_general_cs NOT NULL,
  `TitleAct` varchar(100) COLLATE latin1_general_cs NOT NULL,
  `ActStat` varchar(45) COLLATE latin1_general_cs NOT NULL,
  `Award` varchar(5) COLLATE latin1_general_cs NOT NULL,
  `LvlAct` varchar(20) COLLATE latin1_general_cs NOT NULL,
  `points` int(11) NOT NULL,
  `weight` int(11) NOT NULL,
  `twp` int(11) NOT NULL,
  `appr` int(1) DEFAULT NULL,
  PRIMARY KEY (`rfid`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1 COLLATE=latin1_general_cs;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `ratingform4`
--

LOCK TABLES `ratingform4` WRITE;
/*!40000 ALTER TABLE `ratingform4` DISABLE KEYS */;
/*!40000 ALTER TABLE `ratingform4` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `ratingform5`
--

DROP TABLE IF EXISTS `ratingform5`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `ratingform5` (
  `rfid` int(11) NOT NULL AUTO_INCREMENT,
  `StudentNo` varchar(10) COLLATE latin1_general_cs NOT NULL,
  `Role` varchar(20) COLLATE latin1_general_cs NOT NULL,
  `relother` varchar(100) COLLATE latin1_general_cs NOT NULL,
  `senres` varchar(100) COLLATE latin1_general_cs NOT NULL,
  `res` varchar(100) COLLATE latin1_general_cs NOT NULL,
  `ini` varchar(100) COLLATE latin1_general_cs NOT NULL,
  `coop` varchar(100) COLLATE latin1_general_cs NOT NULL,
  `ability` varchar(100) COLLATE latin1_general_cs NOT NULL,
  `prompt` varchar(100) COLLATE latin1_general_cs NOT NULL,
  `tp` int(11) NOT NULL,
  `twp` int(11) NOT NULL,
  `appr` int(11) DEFAULT NULL,
  PRIMARY KEY (`rfid`)
) ENGINE=InnoDB AUTO_INCREMENT=2 DEFAULT CHARSET=latin1 COLLATE=latin1_general_cs;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `ratingform5`
--

LOCK TABLES `ratingform5` WRITE;
/*!40000 ALTER TABLE `ratingform5` DISABLE KEYS */;
INSERT INTO `ratingform5` VALUES (1,'14-00978','Marshall','rf5rbRO4','rf5rbSR5','rf5rbR5','rf5rbI5','rf5rbC4','rf5rbA4','rf5rbP4',31,155,1);
/*!40000 ALTER TABLE `ratingform5` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `ratingform6`
--

DROP TABLE IF EXISTS `ratingform6`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `ratingform6` (
  `rfid` int(11) NOT NULL AUTO_INCREMENT,
  `StudentNo` varchar(10) COLLATE latin1_general_cs NOT NULL,
  `relother` varchar(100) COLLATE latin1_general_cs NOT NULL,
  `senres` varchar(100) COLLATE latin1_general_cs NOT NULL,
  `res` varchar(100) COLLATE latin1_general_cs NOT NULL,
  `ini` varchar(100) COLLATE latin1_general_cs NOT NULL,
  `coop` varchar(100) COLLATE latin1_general_cs NOT NULL,
  `ability` varchar(100) COLLATE latin1_general_cs NOT NULL,
  `prompt` varchar(100) COLLATE latin1_general_cs NOT NULL,
  `LvlOfc` varchar(100) COLLATE latin1_general_cs NOT NULL,
  `PubOrg` varchar(20) COLLATE latin1_general_cs NOT NULL,
  `Position` varchar(100) COLLATE latin1_general_cs NOT NULL,
  `points` int(11) NOT NULL,
  `weight` int(11) NOT NULL,
  `twp` int(11) NOT NULL,
  `appr` int(11) DEFAULT NULL,
  PRIMARY KEY (`rfid`)
) ENGINE=InnoDB AUTO_INCREMENT=2 DEFAULT CHARSET=latin1 COLLATE=latin1_general_cs;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `ratingform6`
--

LOCK TABLES `ratingform6` WRITE;
/*!40000 ALTER TABLE `ratingform6` DISABLE KEYS */;
INSERT INTO `ratingform6` VALUES (1,'14-02316','rf6rbRO5','rf6rbSR5','rf6rbR5','rf6rbI5','rf6rbC5','rf6rbA5','rf6rbP5','Organization/Publication','Appointed','Vice-President/Managing Editor/University Vice Chairman',35,4,140,1);
/*!40000 ALTER TABLE `ratingform6` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `ratingform7`
--

DROP TABLE IF EXISTS `ratingform7`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `ratingform7` (
  `rfid` int(11) NOT NULL AUTO_INCREMENT,
  `StudentNo` varchar(10) COLLATE latin1_general_cs NOT NULL,
  `relother` varchar(100) COLLATE latin1_general_cs NOT NULL,
  `senres` varchar(100) COLLATE latin1_general_cs NOT NULL,
  `res` varchar(100) COLLATE latin1_general_cs NOT NULL,
  `ini` varchar(100) COLLATE latin1_general_cs NOT NULL,
  `coop` varchar(100) COLLATE latin1_general_cs NOT NULL,
  `ability` varchar(100) COLLATE latin1_general_cs NOT NULL,
  `prompt` varchar(100) COLLATE latin1_general_cs NOT NULL,
  `posit` varchar(45) COLLATE latin1_general_cs NOT NULL,
  `points` int(11) NOT NULL,
  `weight` int(11) NOT NULL,
  `inpo` int(11) NOT NULL,
  `twp` int(11) DEFAULT NULL,
  `appr` int(1) DEFAULT NULL,
  PRIMARY KEY (`rfid`)
) ENGINE=InnoDB AUTO_INCREMENT=9 DEFAULT CHARSET=latin1 COLLATE=latin1_general_cs;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `ratingform7`
--

LOCK TABLES `ratingform7` WRITE;
/*!40000 ALTER TABLE `ratingform7` DISABLE KEYS */;
INSERT INTO `ratingform7` VALUES (1,'15-01827','rf7rbRO4','rf7rbSR3','rf7rbR3','rf7rbI3','rf7rbC3','rf7rbA3','rf7rbP4','Secretary',23,17,123,3220,0),(2,'1','rf7rbRO5','rf7rbSR5','rf7rbR5','rf7rbI5','rf7rbC5','rf7rbA5','rf7rbP5','President',35,20,10,710,1),(3,'1','rf7rbRO5','rf7rbSR5','rf7rbR5','rf7rbI5','rf7rbC5','rf7rbA5','rf7rbP5','President',35,20,10,710,1),(4,'1','rf7rbRO5','rf7rbSR5','rf7rbR5','rf7rbI5','rf7rbC5','rf7rbA5','rf7rbP5','President',35,20,10,710,1),(5,'14-02316','rf7rbRO5','rf7rbSR5','rf7rbR5','rf7rbI5','rf7rbC5','rf7rbA5','rf7rbP5','President',35,20,10,710,1),(6,'14-00978','rf7rbRO5','rf7rbSR5','rf7rbR5','rf7rbI5','rf7rbC5','rf7rbA5','rf7rbP5','President',35,20,10,710,0),(7,'1','rf7rbRO5','rf7rbSR5','rf7rbR5','rf7rbI5','rf7rbC5','rf7rbA5','rf7rbP5','President',35,20,10,710,1),(8,'14-00978','rf7rbRO5','rf7rbSR5','rf7rbR5','rf7rbI5','rf7rbC5','rf7rbA5','rf7rbP5','President',35,20,10,710,1);
/*!40000 ALTER TABLE `ratingform7` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `studinfo`
--

DROP TABLE IF EXISTS `studinfo`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `studinfo` (
  `StudentNo` varchar(10) COLLATE latin1_general_cs NOT NULL,
  `LName` varchar(50) COLLATE latin1_general_cs NOT NULL,
  `FName` varchar(100) COLLATE latin1_general_cs NOT NULL,
  `MiddleIni` varchar(5) COLLATE latin1_general_cs DEFAULT NULL,
  `College_School` varchar(100) COLLATE latin1_general_cs NOT NULL,
  `Course` varchar(30) COLLATE latin1_general_cs NOT NULL,
  `YearGrad` int(11) NOT NULL,
  PRIMARY KEY (`StudentNo`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1 COLLATE=latin1_general_cs;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `studinfo`
--

LOCK TABLES `studinfo` WRITE;
/*!40000 ALTER TABLE `studinfo` DISABLE KEYS */;
INSERT INTO `studinfo` VALUES ('1','Tacay','Lester','D','School of Accountancy and Management','BS Accountancy',2026),('13-01913','David','Joshua Allenkyle','R','School of Science and Technology','BS Information Technology',2018),('14-00978','Remos','Mahealani Joy','G','School of Science and Technology','BS Information Technology',2018),('14-01122','Basa','Robe Marlui','D.','School of Science and Technology','BS Information Technology',2018),('14-02316','Ronquillo','Feli Blanca','D.','School of Science and Technology','BS Information Technology',2018),('15-01827','Romero','Adrianne','V','School of Science and Technology','BS Information Technology',2019);
/*!40000 ALTER TABLE `studinfo` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `studsum`
--

DROP TABLE IF EXISTS `studsum`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `studsum` (
  `StudentNo` varchar(30) COLLATE latin1_general_cs NOT NULL,
  `LName` varchar(100) CHARACTER SET latin1 NOT NULL,
  `FName` varchar(50) CHARACTER SET latin1 NOT NULL,
  `MiddleIni` varchar(5) CHARACTER SET latin1 DEFAULT NULL,
  `College_School` varchar(100) COLLATE latin1_general_cs DEFAULT NULL,
  `Course` varchar(45) COLLATE latin1_general_cs DEFAULT NULL,
  `YearGrad` int(11) DEFAULT NULL,
  `TotalPoints` int(11) DEFAULT NULL,
  `Remarks` varchar(45) COLLATE latin1_general_cs DEFAULT NULL,
  PRIMARY KEY (`StudentNo`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1 COLLATE=latin1_general_cs;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `studsum`
--

LOCK TABLES `studsum` WRITE;
/*!40000 ALTER TABLE `studsum` DISABLE KEYS */;
INSERT INTO `studsum` VALUES ('1','Tacay','Lester','D','School of Accountancy and Management','BS Accountancy',2026,40,''),('13-01913','David','Joshua Allenkyle','R','School of Science and Technology','BS Information Technology',2018,125,''),('14-00978','Remos','Mahealani Joy','G','School of Science and Technology','BS Information Technology',2018,51294,'Gold'),('14-01122','Basa','Robe Marlui','D.','School of Science and Technology','BS Information Technology',2018,105,''),('14-02316','Ronquillo','Feli Blanca','D.','School of Science and Technology','BS Information Technology',2018,48,''),('15-01827','Romero','Adrianne','V','School of Science and Technology','BS Information Technology',2019,0,' ');
/*!40000 ALTER TABLE `studsum` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `userinfo`
--

DROP TABLE IF EXISTS `userinfo`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `userinfo` (
  `Username` varchar(20) COLLATE latin1_general_cs NOT NULL,
  `psword` varchar(20) COLLATE latin1_general_cs NOT NULL,
  `authorization` varchar(20) COLLATE latin1_general_cs NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1 COLLATE=latin1_general_cs;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `userinfo`
--

LOCK TABLES `userinfo` WRITE;
/*!40000 ALTER TABLE `userinfo` DISABLE KEYS */;
INSERT INTO `userinfo` VALUES ('JLMillamina','malditaako','Administrator'),('lanlan_remos','ReVi1001','Student Assistant');
/*!40000 ALTER TABLE `userinfo` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2017-02-25 10:59:58
