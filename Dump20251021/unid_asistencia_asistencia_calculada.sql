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
-- Table structure for table `asistencia_calculada`
--

DROP TABLE IF EXISTS `asistencia_calculada`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `asistencia_calculada` (
  `ID_Asistencia` int NOT NULL AUTO_INCREMENT,
  `ID_Horario` int NOT NULL,
  `ID_Profesor` int NOT NULL,
  `Fecha_Clase` date NOT NULL,
  `Hora_Entrada_Real` time DEFAULT NULL,
  `Hora_Salida_Real` time DEFAULT NULL,
  `Minutos_Retardo` int NOT NULL DEFAULT '0',
  `Estatus` varchar(50) NOT NULL,
  PRIMARY KEY (`ID_Asistencia`),
  KEY `ID_Horario` (`ID_Horario`),
  KEY `ID_Profesor` (`ID_Profesor`),
  CONSTRAINT `asistencia_calculada_ibfk_1` FOREIGN KEY (`ID_Horario`) REFERENCES `horarios_clases` (`ID_Horario`),
  CONSTRAINT `asistencia_calculada_ibfk_2` FOREIGN KEY (`ID_Profesor`) REFERENCES `profesores` (`ID_Profesor`)
) ENGINE=InnoDB AUTO_INCREMENT=2 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `asistencia_calculada`
--

LOCK TABLES `asistencia_calculada` WRITE;
/*!40000 ALTER TABLE `asistencia_calculada` DISABLE KEYS */;
INSERT INTO `asistencia_calculada` VALUES (1,1,3,'2025-10-21','08:15:00',NULL,15,'Tardanza');
/*!40000 ALTER TABLE `asistencia_calculada` ENABLE KEYS */;
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
