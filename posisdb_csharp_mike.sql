-- phpMyAdmin SQL Dump
-- version 4.7.4
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1:3306
-- Generation Time: Feb 08, 2018 at 09:10 AM
-- Server version: 5.7.19
-- PHP Version: 5.6.31

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET AUTOCOMMIT = 0;
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `posisdb_csharp_mike`
--
CREATE DATABASE IF NOT EXISTS `posisdb_csharp_mike` DEFAULT CHARACTER SET latin1 COLLATE latin1_swedish_ci;
USE `posisdb_csharp_mike`;

-- --------------------------------------------------------

--
-- Table structure for table `login`
--

DROP TABLE IF EXISTS `login`;
CREATE TABLE IF NOT EXISTS `login` (
  `Username` varchar(50) NOT NULL,
  `Password` varchar(50) NOT NULL,
  `Role` varchar(50) NOT NULL
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

--
-- Dumping data for table `login`
--

INSERT INTO `login` (`Username`, `Password`, `Role`) VALUES
('Azwad', '123', 'Admin'),
('Bapon', '456', 'Client'),
('Azwad', '123', 'Admin'),
('Bapon', '456', 'Client');

-- --------------------------------------------------------

--
-- Table structure for table `ordertable`
--

DROP TABLE IF EXISTS `ordertable`;
CREATE TABLE IF NOT EXISTS `ordertable` (
  `Order_ID` int(50) NOT NULL,
  `Order_Code` varchar(50) NOT NULL,
  `Order_Desc` varchar(100) NOT NULL,
  `Order_Price` int(100) NOT NULL
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

--
-- Dumping data for table `ordertable`
--

INSERT INTO `ordertable` (`Order_ID`, `Order_Code`, `Order_Desc`, `Order_Price`) VALUES
(1, '1', 'Handy Cam', 30000),
(2, '2', 'Refrigerator', 89000),
(3, '10', 'Medicine', 10000),
(4, '11', 'Food', 11000),
(1, '1', 'Handy Cam', 30000),
(2, '2', 'Refrigerator', 89000),
(3, '10', 'Medicine', 10000),
(4, '11', 'Food', 11000),
(5, '14', 'Canera', 12000),
(6, '16', 'Graphics Card', 13000),
(7, '18', 'Drones', 14000),
(8, '20', 'Home Materials', 14000),
(9, '22', 'Frozen Foods', 15000),
(10, '24', 'Motherboards', 15000),
(1, '1', 'Handy Cam', 30000),
(2, '2', 'Refrigerator', 89001),
(3, '10', 'Medicine', 10000),
(4, '11', 'Food', 11000),
(1, '1', 'Handy Cam', 30000),
(2, '2', 'Refrigerator', 89001),
(3, '10', 'Medicine', 10000),
(4, '11', 'Food', 11000);

-- --------------------------------------------------------

--
-- Table structure for table `products`
--

DROP TABLE IF EXISTS `products`;
CREATE TABLE IF NOT EXISTS `products` (
  `Product_ID` int(50) NOT NULL,
  `Product_Code` int(50) NOT NULL,
  `Description` varchar(6000) NOT NULL,
  `StocksOnHand` varchar(50) NOT NULL,
  `Category_ID` int(50) NOT NULL,
  `Unit_Price` varchar(50) NOT NULL,
  PRIMARY KEY (`Product_ID`)
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

--
-- Dumping data for table `products`
--

INSERT INTO `products` (`Product_ID`, `Product_Code`, `Description`, `StocksOnHand`, `Category_ID`, `Unit_Price`) VALUES
(1, 1, 'Handy Cam', '5', 1, '30000'),
(2, 2, 'Refrigerator', '8', 2, '89001'),
(3, 10, 'Medicine', '101', 11, '10000'),
(4, 11, 'Food', '101', 12, '11000'),
(5, 14, 'Camera', '102', 15, '12000'),
(6, 16, 'Graphics Card', '103', 17, '13000'),
(7, 18, 'Drones', '104', 19, '14000'),
(8, 20, 'Home Materials ZONE', '104', 21, '14000'),
(9, 22, 'Frozen Foods', '105', 23, '15000'),
(10, 24, 'Motherboards', '104', 25, '15000');

-- --------------------------------------------------------

--
-- Table structure for table `renttable`
--

DROP TABLE IF EXISTS `renttable`;
CREATE TABLE IF NOT EXISTS `renttable` (
  `Rent_ID` int(50) NOT NULL,
  `Rent_Code` varchar(50) NOT NULL,
  `Rent_Desc` varchar(100) NOT NULL,
  `Rent_Price` int(100) NOT NULL
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

--
-- Dumping data for table `renttable`
--

INSERT INTO `renttable` (`Rent_ID`, `Rent_Code`, `Rent_Desc`, `Rent_Price`) VALUES
(1, '1', 'Handy Cam', 30000),
(2, '2', 'Refrigerator', 89000),
(3, '10', 'Medicine', 10000),
(4, '11', 'Food', 11000),
(5, '14', 'Canera', 12000),
(6, '16', 'Graphics Card', 13000),
(7, '18', 'Drones', 14000),
(8, '20', 'Home Materials', 14000),
(9, '22', 'Frozen Foods', 15000),
(10, '24', 'Motherboards', 15000),
(4, '11', 'Food', 11000),
(5, '14', 'Canera', 12000),
(6, '16', 'Graphics Card', 13000),
(7, '18', 'Drones', 14000),
(1, '1', 'Handy Cam', 30000),
(2, '2', 'Refrigerator', 89001),
(3, '10', 'Medicine', 10000),
(4, '11', 'Food', 11000),
(5, '14', 'Camera', 12000),
(1, '1', 'Handy Cam', 30000),
(2, '2', 'Refrigerator', 89001),
(3, '10', 'Medicine', 10000),
(4, '11', 'Food', 11000);

-- --------------------------------------------------------

--
-- Table structure for table `signup`
--

DROP TABLE IF EXISTS `signup`;
CREATE TABLE IF NOT EXISTS `signup` (
  `ID` int(50) NOT NULL AUTO_INCREMENT,
  `NewUser` varchar(50) NOT NULL,
  `NewPass` varchar(50) NOT NULL,
  `Address` varchar(50) NOT NULL,
  `Contact_No` varchar(50) NOT NULL,
  PRIMARY KEY (`ID`)
) ENGINE=MyISAM AUTO_INCREMENT=12 DEFAULT CHARSET=latin1;

--
-- Dumping data for table `signup`
--

INSERT INTO `signup` (`ID`, `NewUser`, `NewPass`, `Address`, `Contact_No`) VALUES
(3, 'Hello', '123456', '183/1,Arambagh', '015545'),
(4, 'Bapon', '789', '567,shantinagar', '56789'),
(6, 'paladin', '456', 'tytyty', '568711'),
(11, 'BAR STROM', '7894', 'BattleField 1', '5689741'),
(10, 'Cyclone', '1234', '', '');
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
