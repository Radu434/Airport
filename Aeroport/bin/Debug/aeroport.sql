-- phpMyAdmin SQL Dump
-- version 5.1.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: May 09, 2022 at 10:23 AM
-- Server version: 10.4.22-MariaDB
-- PHP Version: 8.0.13

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `aeroport`
--

-- --------------------------------------------------------

--
-- Table structure for table `bilet`
--

CREATE TABLE `bilet` (
  `idb` int(11) NOT NULL,
  `idc` int(11) NOT NULL,
  `idz` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `bilet`
--

INSERT INTO `bilet` (`idb`, `idc`, `idz`) VALUES
(1, 1, 7),
(2, 1, 1),
(3, 1, 5),
(4, 1, 4),
(5, 1, 7),
(6, 0, 8),
(7, 1, 3);

-- --------------------------------------------------------

--
-- Table structure for table `clienti`
--

CREATE TABLE `clienti` (
  `idc` int(11) NOT NULL,
  `nume` text NOT NULL,
  `prenume` text NOT NULL,
  `parola` text NOT NULL,
  `email` text NOT NULL,
  `telefon` text NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `clienti`
--

INSERT INTO `clienti` (`idc`, `nume`, `prenume`, `parola`, `email`, `telefon`) VALUES
(1, 'Stanescu', 'Mihai', 'nebunie22', 'misu@gmail.com', '0732937943'),
(2, 'Marinescu', 'Bogdan', 'abcd1234', 'bogdan.marinescu@gmail.com', '0734972364'),
(3, 'Ionescu', 'Andrei', 'qwertyui', 'ion@yahoo.com', '0745376031'),
(4, 'Nicolaescu\r\n', 'Pavel', '12345678', 'pavel@yahoo.com', '0765378493');

-- --------------------------------------------------------

--
-- Table structure for table `destinatie`
--

CREATE TABLE `destinatie` (
  `idd` int(11) NOT NULL,
  `oras` text NOT NULL,
  `tara` text NOT NULL,
  `aeroport` text NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `destinatie`
--

INSERT INTO `destinatie` (`idd`, `oras`, `tara`, `aeroport`) VALUES
(1, 'Munchen', 'Germania', 'Franz Josef Strauss'),
(2, 'Sydney', 'Australia', 'Sydney Airport'),
(3, 'Toronto', 'Canada', 'Toronto Pearson Airport'),
(4, 'Londra', 'Anglia', 'Heathrow'),
(5, 'Bucuresti', 'Romania', 'Aeroportul International Henri Coanda'),
(6, 'Cluj-Napoca', 'Romania', 'Avram Iancu'),
(7, 'Londra', 'Anglia', 'London City Airport'),
(8, 'Birmingham', 'Anglia', 'Birmingham Airport'),
(9, 'Manchester', 'Anglia', 'Manchester Airport'),
(10, 'Timisoara', 'Romania', 'Aeroportul International Traian Vuia'),
(11, 'Montreal', 'Canada', 'Pierre Elliott Trudeau Airport'),
(12, 'Berlin', 'Germania', 'Brandenburg Airport');

-- --------------------------------------------------------

--
-- Table structure for table `zbor`
--

CREATE TABLE `zbor` (
  `idz` int(11) NOT NULL,
  `companie` text NOT NULL,
  `idd` int(11) NOT NULL,
  `durata` text NOT NULL,
  `data_decolare` datetime NOT NULL,
  `pret` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `zbor`
--

INSERT INTO `zbor` (`idz`, `companie`, `idd`, `durata`, `data_decolare`, `pret`) VALUES
(1, 'Lufthansa', 1, '2', '2022-05-25 08:45:36', 130),
(2, 'Wizzair', 3, '8', '2022-05-17 12:20:36', 400),
(3, 'Lufthansa', 12, '2', '2022-05-26 18:00:26', 40),
(4, 'Lufthansa', 7, '4', '2022-05-13 15:25:13', 90),
(5, 'Wizzair', 2, '16', '2022-05-19 10:50:58', 400),
(6, 'Lufthansa', 1, '2', '2022-05-28 19:35:14', 80),
(7, 'Wizzair', 4, '3', '2022-05-20 19:35:14', 70),
(8, 'Wizzair', 4, '3', '2022-05-17 19:35:14', 80),
(9, 'Wizzair', 4, '3', '2022-05-23 19:35:14', 80),
(10, 'Wizzair', 3, '12', '2022-05-19 21:44:04', 300);

--
-- Indexes for dumped tables
--

--
-- Indexes for table `bilet`
--
ALTER TABLE `bilet`
  ADD PRIMARY KEY (`idb`);

--
-- Indexes for table `clienti`
--
ALTER TABLE `clienti`
  ADD PRIMARY KEY (`idc`);

--
-- Indexes for table `destinatie`
--
ALTER TABLE `destinatie`
  ADD PRIMARY KEY (`idd`);

--
-- Indexes for table `zbor`
--
ALTER TABLE `zbor`
  ADD PRIMARY KEY (`idz`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `bilet`
--
ALTER TABLE `bilet`
  MODIFY `idb` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=8;

--
-- AUTO_INCREMENT for table `clienti`
--
ALTER TABLE `clienti`
  MODIFY `idc` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=5;

--
-- AUTO_INCREMENT for table `destinatie`
--
ALTER TABLE `destinatie`
  MODIFY `idd` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=13;

--
-- AUTO_INCREMENT for table `zbor`
--
ALTER TABLE `zbor`
  MODIFY `idz` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=11;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
