-- phpMyAdmin SQL Dump
-- version 4.7.9
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Oct 23, 2018 at 04:43 PM
-- Server version: 5.7.23-log
-- PHP Version: 7.2.3

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET AUTOCOMMIT = 0;
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `unitytest`
--

-- --------------------------------------------------------

--
-- Table structure for table `posttest`
--

CREATE TABLE `posttest` (
  `ID` int(11) NOT NULL,
  `Content` varchar(255) NOT NULL DEFAULT 'Word',
  `Date` datetime NOT NULL DEFAULT CURRENT_TIMESTAMP
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `posttest`
--

INSERT INTO `posttest` (`ID`, `Content`, `Date`) VALUES
(1, 'Apple', '2018-10-16 17:54:54'),
(2, 'Banana', '2018-10-16 17:54:54'),
(20, 'okay fine ', '2018-10-21 16:09:20'),
(21, 'yeah yeah ', '2018-10-21 16:09:24'),
(22, 'and ', '2018-10-21 16:09:29');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `posttest`
--
ALTER TABLE `posttest`
  ADD PRIMARY KEY (`ID`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `posttest`
--
ALTER TABLE `posttest`
  MODIFY `ID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=23;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
