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
-- Table structure for table `asignaturas`
--

DROP TABLE IF EXISTS `asignaturas`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `asignaturas` (
  `ID_Asignatura` int NOT NULL AUTO_INCREMENT,
  `Nombre_Clase` varchar(100) NOT NULL,
  `Licenciatura` varchar(100) NOT NULL,
  PRIMARY KEY (`ID_Asignatura`)
) ENGINE=InnoDB AUTO_INCREMENT=6 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `asignaturas`
--

LOCK TABLES `asignaturas` WRITE;
/*!40000 ALTER TABLE `asignaturas` DISABLE KEYS */;
INSERT INTO `asignaturas` VALUES (1,'cha cha','Ingenieria'),(2,'dwadw ','dawdaw'),(3,'tutiut','diseño'),(4,'ssq','SWDWAD'),(5,'holaola','222');
/*!40000 ALTER TABLE `asignaturas` ENABLE KEYS */;
UNLOCK TABLES;

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

--
-- Table structure for table `horarios_clases`
--

DROP TABLE IF EXISTS `horarios_clases`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `horarios_clases` (
  `ID_Horario` int NOT NULL AUTO_INCREMENT,
  `ID_Profesor` int NOT NULL,
  `ID_Asignatura` int NOT NULL,
  `Dia_Semana` varchar(10) NOT NULL,
  `Salon_Asignado` varchar(20) DEFAULT NULL,
  `Hora_Entrada_Oficial` time NOT NULL,
  `Hora_Salida_Oficial` time NOT NULL,
  PRIMARY KEY (`ID_Horario`),
  KEY `ID_Profesor` (`ID_Profesor`),
  KEY `ID_Asignatura` (`ID_Asignatura`),
  CONSTRAINT `horarios_clases_ibfk_1` FOREIGN KEY (`ID_Profesor`) REFERENCES `profesores` (`ID_Profesor`),
  CONSTRAINT `horarios_clases_ibfk_2` FOREIGN KEY (`ID_Asignatura`) REFERENCES `asignaturas` (`ID_Asignatura`)
) ENGINE=InnoDB AUTO_INCREMENT=2 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `horarios_clases`
--

LOCK TABLES `horarios_clases` WRITE;
/*!40000 ALTER TABLE `horarios_clases` DISABLE KEYS */;
INSERT INTO `horarios_clases` VALUES (1,1,1,'martes','105','08:00:00','10:00:00');
/*!40000 ALTER TABLE `horarios_clases` ENABLE KEYS */;
UNLOCK TABLES;

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
  PRIMARY KEY (`ID_Profesor`),
  UNIQUE KEY `ID_Lector_Biometrico_UNIQUE` (`ID_Lector_Biometrico`)
) ENGINE=InnoDB AUTO_INCREMENT=10 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `profesores`
--

LOCK TABLES `profesores` WRITE;
/*!40000 ALTER TABLE `profesores` DISABLE KEYS */;
INSERT INTO `profesores` VALUES (1,'David Chacon (Test)','actualizado@unid.edu.mx','9501','#00FF00',1),(3,'David Chacon Velueta (Test)','david.chacon@unid.edu.mx','9888','#0000FF',1),(6,'David Chacon Velueta (Test)','david.chacon@unid.edu.mx','9878','#0000FF',1),(9,'Prueba Final','mmnvallada@gmail.com','9999','#00FF00',1);
/*!40000 ALTER TABLE `profesores` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `registros_lector_bruto`
--

DROP TABLE IF EXISTS `registros_lector_bruto`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `registros_lector_bruto` (
  `ID_Registro_Bruto` int NOT NULL,
  `ID_Lector_Biometrico` varchar(20) NOT NULL,
  `Timestamp_Checada` datetime NOT NULL,
  `Tipo_Movimiento` varchar(10) DEFAULT NULL,
  PRIMARY KEY (`ID_Registro_Bruto`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `registros_lector_bruto`
--

LOCK TABLES `registros_lector_bruto` WRITE;
/*!40000 ALTER TABLE `registros_lector_bruto` DISABLE KEYS */;
/*!40000 ALTER TABLE `registros_lector_bruto` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2025-10-21  4:23:40
