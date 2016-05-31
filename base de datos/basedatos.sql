-- MySQL dump 10.13  Distrib 5.6.24, for Win64 (x86_64)
--
-- Host: 127.0.0.1    Database: ventassysbd
-- ------------------------------------------------------
-- Server version	5.6.26

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
-- Table structure for table `cat_productos`
--

DROP TABLE IF EXISTS `cat_productos`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `cat_productos` (
  `idcat_productos` int(11) NOT NULL AUTO_INCREMENT,
  `nombre` varchar(100) NOT NULL,
  `codigo_barras` varchar(25) DEFAULT NULL,
  `marca` varchar(45) NOT NULL,
  `precio` double NOT NULL,
  PRIMARY KEY (`idcat_productos`)
) ENGINE=InnoDB AUTO_INCREMENT=6 DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `cat_productos`
--

LOCK TABLES `cat_productos` WRITE;
/*!40000 ALTER TABLE `cat_productos` DISABLE KEYS */;
INSERT INTO `cat_productos` VALUES (1,'Un lapiz','9823982','Mirado',10),(2,'Libreta','938498','Pencil',200),(3,'Yoyo','ksahdksjhdf','Pencil',800),(4,'Chicles motita','asdasdasd','asd',100),(5,'chicles motita','kajsdlk','Sabritas',10);
/*!40000 ALTER TABLE `cat_productos` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `contador_productos`
--

DROP TABLE IF EXISTS `contador_productos`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `contador_productos` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `numeroproductos` int(11) NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `contador_productos`
--

LOCK TABLES `contador_productos` WRITE;
/*!40000 ALTER TABLE `contador_productos` DISABLE KEYS */;
INSERT INTO `contador_productos` VALUES (1,5);
/*!40000 ALTER TABLE `contador_productos` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Dumping events for database 'ventassysbd'
--

--
-- Dumping routines for database 'ventassysbd'
--
/*!50003 DROP PROCEDURE IF EXISTS `registrar_producto` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8 */ ;
/*!50003 SET character_set_results = utf8 */ ;
/*!50003 SET collation_connection  = utf8_general_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `registrar_producto`(pid int, pnombre 
                 varchar(100), 
				pcodigobarras varchar(25), 
                pmarca varchar(45), 
                pprecio double)
BEGIN

    INSERT INTO cat_productos VALUES
           (pid, pnombre, pcodigobarras,
		pmarca,pprecio); 
	
    UPDATE contador_productos SET 
	numeroproductos = numeroproductos+1 
    WHERE id=1;
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2016-05-31 11:38:24
