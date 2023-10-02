-- phpMyAdmin SQL Dump
-- version 5.2.0
-- https://www.phpmyadmin.net/
--
-- Gép: 127.0.0.1:3306
-- Létrehozás ideje: 2023. Sze 20. 09:29
-- Kiszolgáló verziója: 8.0.31
-- PHP verzió: 8.0.26

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Adatbázis: `webshop`
--
CREATE DATABASE IF NOT EXISTS `webshop` DEFAULT CHARACTER SET utf8mb4 COLLATE utf8mb4_hungarian_ci;
USE `webshop`;

-- --------------------------------------------------------

--
-- Tábla szerkezet ehhez a táblához `felhasznalok`
--

DROP TABLE IF EXISTS `felhasznalok`;
CREATE TABLE IF NOT EXISTS `felhasznalok` (
  `Id` int NOT NULL AUTO_INCREMENT,
  `LoginNev` varchar(16) COLLATE utf8mb4_hungarian_ci NOT NULL,
  `HASH` varchar(64) CHARACTER SET utf8mb4 COLLATE utf8mb4_hungarian_ci NOT NULL,
  `SALT` varchar(64) CHARACTER SET utf8mb4 COLLATE utf8mb4_hungarian_ci NOT NULL,
  `Nev` varchar(64) COLLATE utf8mb4_hungarian_ci NOT NULL,
  `Jog` int NOT NULL,
  `Aktiv` tinyint(1) NOT NULL,
  `Email` varchar(64) COLLATE utf8mb4_hungarian_ci NOT NULL,
  `ProfilKep` varchar(64) COLLATE utf8mb4_hungarian_ci NOT NULL,
  PRIMARY KEY (`Id`),
  UNIQUE KEY `LoginNev` (`LoginNev`)
) ENGINE=InnoDB AUTO_INCREMENT=5 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_hungarian_ci;

--
-- A tábla adatainak kiíratása `felhasznalok`
--

INSERT INTO `felhasznalok` (`Id`, `LoginNev`, `HASH`, `SALT`, `Nev`, `Jog`, `Aktiv`, `Email`, `ProfilKep`) VALUES
(1, 'a', 'a', 'a', 'Admin', 9, 1, 'kerenyir@kkszki.hu', 'kep.jpg'),
(2, 'awewe', 'afdrerer', 'a454545454', 'Adminewewe', 1, 1, 'kerenyireerer@kkszki.hu', 'keprrrr.jpg'),
(4, 'awewrtrtrte', 'afdrerer', 'a454545454', 'Adminewewe', 1, 0, 'kerenyireerer@kkszki.hu', 'keprrrr.jpg');
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
