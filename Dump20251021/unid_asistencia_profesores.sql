-- MySQL dump 10.13  Distrib 8.0.43, for Win64 (x86_64)
--
-- Host: localhost    Database: unid_asistencia
-- ------------------------------------------------------
-- Server version	8.0.43

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
-- Table structure for table `profesores`
--

DROP TABLE IF EXISTS `profesores`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `profesores` (
  `ID_Profesor` int NOT NULL AUTO_INCREMENT,
  `Nombre_Completo` varchar(150) NOT NULL,
  `Correo_Electronico` varchar(100) NOT NULL,
  `ID_Lector_Biometrico` varchar(20) NOT NULL,
  `Color_Display_Hex` varchar(7) DEFAULT NULL,
  `Activo` tinyint NOT NULL DEFAULT '1',
  `Ruta_Foto_Perfil` varchar(255) DEFAULT NULL,
  PRIMARY KEY (`ID_Profesor`),
  UNIQUE KEY `ID_Lector_Biometrico_UNIQUE` (`ID_Lector_Biometrico`)
) ENGINE=InnoDB AUTO_INCREMENT=21 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `profesores`
--

LOCK TABLES `profesores` WRITE;
/*!40000 ALTER TABLE `profesores` DISABLE KEYS */;
INSERT INTO `profesores` VALUES (1,'David Chacon (Test)','actualizado@unid.edu.mx','9501','#00FF00',1,NULL),(3,'David Chacon Velueta (Test)','david.chacon@unid.edu.mx','9888','#0000FF',1,NULL),(6,'David Chacon Velueta (Test)','david.chacon@unid.edu.mx','9878','#0000FF',1,NULL),(9,'Prueba Final','mmnvallada@gmail.com','9999','#00FF00',1,NULL),(10,'Mauy','Correocawdac@gmail.com','2333','Color',0,NULL),(11,'Nombre','Correo','Id','Color',0,NULL),(13,'Nombre','Correo','dsada','Color',0,NULL),(15,'dgvf','efs','Ifesfes','fse',1,NULL),(17,'fds','sdf','fsd','fds',1,NULL),(19,'efsf','Corfesf','4334','Cfse',0,NULL),(20,'No21','2','2122','Co2',0,NULL);
/*!40000 ALTER TABLE `profesores` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2025-10-21 18:28:58
