-- phpMyAdmin SQL Dump
-- version 5.2.0
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Jan 26, 2023 at 06:34 PM
-- Server version: 10.4.27-MariaDB
-- PHP Version: 8.0.25

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `bookstoremanagement`
--

-- --------------------------------------------------------

--
-- Table structure for table `db_books`
--

CREATE TABLE `db_books` (
  `bookid` char(7) NOT NULL,
  `name` varchar(250) NOT NULL,
  `price` varchar(50) NOT NULL,
  `writer` varchar(250) DEFAULT NULL,
  `quantity` int(50) DEFAULT NULL,
  `category` varchar(250) DEFAULT NULL,
  `publication_year` varchar(4) DEFAULT NULL,
  `publisher` varchar(250) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `db_books`
--

INSERT INTO `db_books` (`bookid`, `name`, `price`, `writer`, `quantity`, `category`, `publication_year`, `publisher`) VALUES
('BOK0001', 'LASKAR PELANGI', '65000', 'ANDREA HIRATA', 50, 'ANAK ANAK', '2010', 'ERLANGGA'),
('BOK0002', 'SANG PEMIMPI', '65000', 'ANDREA HIRATA', 100, 'FIKSI', '2014', 'GRAMEDIA PUSTAKA UTAMA'),
('BOK0003', 'PULANG', '85000', 'TERE LIYE', 50, 'FIKSI', '2017', 'GRAMEDIA PUSTAKA UTAMA'),
('BOK0004', 'PERGI', '85000', 'TERE LIYE', 60, 'FIKSI', '2016', 'GRAMEDIA PUSTAKA UTAMA'),
('BOK0005', 'POLARIS FUKUOKA', '75000', 'SINTA YUDISIA', 65, 'FIKSI', '2017', 'MIZAN'),
('BOK0006', 'THE ARCHITECTURE OF LOVE', '85000', 'IKA NATASHA', 80, 'FIKSI', '2016', 'GRAMEDIA PUSTAKA UTAMA'),
('BOK0008', 'A BITE SIZED OF MAGIC', '75000', 'KATHRYN LITTLEWOOD', 70, 'FIKSI', '2014', 'MIZAN FANTASI');

-- --------------------------------------------------------

--
-- Table structure for table `db_categories`
--

CREATE TABLE `db_categories` (
  `catid` char(7) NOT NULL,
  `catname` varchar(250) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `db_categories`
--

INSERT INTO `db_categories` (`catid`, `catname`) VALUES
('CAT0001', 'FISIKA'),
('CAT0002', 'MATEMATIKA'),
('CAT0003', 'FIKSI'),
('CAT0005', 'ANAK ANAK'),
('CAT0006', 'POLITIK'),
('CAT0007', 'KIMIA');

-- --------------------------------------------------------

--
-- Table structure for table `db_checkout`
--

CREATE TABLE `db_checkout` (
  `invoiceid` char(7) NOT NULL,
  `cusid` char(7) NOT NULL,
  `bookid` char(7) NOT NULL,
  `name` varchar(250) NOT NULL,
  `quantity` varchar(250) NOT NULL,
  `price` varchar(250) NOT NULL,
  `totalprice` varchar(250) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `db_checkout`
--

INSERT INTO `db_checkout` (`invoiceid`, `cusid`, `bookid`, `name`, `quantity`, `price`, `totalprice`) VALUES
('INV0001', 'CUS0001', 'BOK0001', 'LASKAR PELANGI', '3', '65000', '195000'),
('INV0001', 'CUS0001', 'BOK0002', 'SANG PEMIMPI', '4', '65000', '260000'),
('INV0002', 'CUS0001', 'BOK0001', 'LASKAR PELANGI', '5', '65000', '325000'),
('INV0003', 'CUS0001', 'BOK0002', 'SANG PEMIMPI', '5', '65000', '325000'),
('INV0003', 'CUS0001', 'BOK0001', 'LASKAR PELANGI', '5', '65000', '325000'),
('INV0004', 'CUS0001', 'BOK0001', 'LASKAR PELANGI', '5', '65000', '325000'),
('INV0005', 'CUS0001', 'BOK0001', 'LASKAR PELANGI', '1', '65000', '65000'),
('INV0006', 'CUS0001', 'BOK0001', 'LASKAR PELANGI', '5', '65000', '325000'),
('INV0007', 'CUS0001', 'BOK0002', 'SANG PEMIMPI', '1', '65000', '65000'),
('INV0008', 'CUS0002', 'BOK0003', 'PULANG', '2', '85000', '170000'),
('INV0008', 'CUS0001', 'BOK0002', 'SANG PEMIMPI', '1', '65000', '65000'),
('INV0009', 'CUS0002', 'BOK0003', 'PULANG', '1', '85000', '85000'),
('INV0009', 'CUS0002', 'BOK0002', 'SANG PEMIMPI', '2', '65000', '130000'),
('INV0010', 'CUS0002', 'BOK0004', 'PERGI', '2', '85000', '170000'),
('INV0010', 'CUS0002', 'BOK0003', 'PULANG', '1', '85000', '85000'),
('INV0011', 'CUS0003', 'BOK0006', 'THE ARCHITECTURE OF LOVE', '1', '85000', '85000'),
('INV0012', 'CUS0003', 'BOK0005', 'POLARIS FUKUOKA', '2', '75000', '150000'),
('INV0013', 'CUS0001', 'BOK0004', 'PERGI', '2', '85000', '170000'),
('INV0013', 'CUS0002', 'BOK0003', 'PULANG', '1', '85000', '85000'),
('INV0014', 'CUS0001', 'BOK0004', 'PERGI', '2', '85000', '170000');

-- --------------------------------------------------------

--
-- Table structure for table `db_customers`
--

CREATE TABLE `db_customers` (
  `cusid` char(7) NOT NULL,
  `cusname` varchar(250) DEFAULT NULL,
  `cuscontact` varchar(250) DEFAULT NULL,
  `cusaddress` varchar(250) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `db_customers`
--

INSERT INTO `db_customers` (`cusid`, `cusname`, `cuscontact`, `cusaddress`) VALUES
('CUS0001', 'GILANG', '087854215642', 'BABARSARI'),
('CUS0002', 'DANIEL KATAMANDARA', '087549384205', 'MUNTILAN'),
('CUS0003', 'YOHANES NADELIAN', '087594382777', 'KLATEN');

-- --------------------------------------------------------

--
-- Table structure for table `db_employee`
--

CREATE TABLE `db_employee` (
  `empid` char(7) NOT NULL,
  `empuname` varchar(250) NOT NULL,
  `empfname` varchar(250) NOT NULL,
  `emppassword` varchar(250) NOT NULL,
  `empcontact` varchar(250) NOT NULL,
  `empemail` varchar(250) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `db_employee`
--

INSERT INTO `db_employee` (`empid`, `empuname`, `empfname`, `emppassword`, `empcontact`, `empemail`) VALUES
('EMP0001', 'sidiq', 'MUHAMMAD SIDIQ FIRMANSYAH', '123', '085740031048', 'sidiq.firman@students.amikom.ac.id'),
('EMP0002', 'keenan', 'GABRIEL KEENAN FAREZA', '1004', '085438473223', 'kinan_gab@gmail.com'),
('EMP0003', 'arga', 'ARGATHA BINTANG', 'bulanbintang', '087654983723', 'bintang.arga@gmail.com');

-- --------------------------------------------------------

--
-- Table structure for table `db_orders`
--

CREATE TABLE `db_orders` (
  `invoicedate` varchar(250) NOT NULL,
  `invoiceid` char(7) NOT NULL,
  `cusid` char(7) NOT NULL,
  `cusname` varchar(250) NOT NULL,
  `cuscontact` varchar(250) NOT NULL,
  `cusaddress` varchar(250) NOT NULL,
  `grandtotal` varchar(250) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `db_orders`
--

INSERT INTO `db_orders` (`invoicedate`, `invoiceid`, `cusid`, `cusname`, `cuscontact`, `cusaddress`, `grandtotal`) VALUES
('12/01/2023', '42774', '75441', 'ADAM', '082138876452', 'KLATEN', '90000'),
('24/01/2023', 'INV0003', 'CUS0001', 'GILANG', '087854215642', 'BABARSARI', '650000'),
('24/01/2023', 'INV0004', 'CUS0001', 'GILANG', '087854215642', 'BABARSARI', '325000'),
('24/01/2023', 'INV0005', 'CUS0001', 'GILANG', '087854215642', 'BABARSARI', '65000'),
('24/01/2023', 'INV0006', 'CUS0001', 'GILANG', '087854215642', 'BABARSARI', '325000'),
('1/24/2023', 'INV0008', 'CUS0001', 'GILANG', '087854215642', 'BABARSARI', ''),
('1/24/2023', 'INV0008', 'CUS0001', 'GILANG', '087854215642', 'BABARSARI', '235000'),
('1/25/2023', 'INV0009', 'CUS0002', 'DANIEL KATAMANDARA', '087549384205', 'MAGUWOHARJO', '215000'),
('1/25/2023', 'INV0010', 'CUS0002', 'DANIEL KATAMANDARA', '087549384205', 'MUNTILAN', '255000'),
('26/01/2023', 'INV0013', 'CUS0002', 'DANIEL KATAMANDARA', '087549384205', 'MUNTILAN', '255000'),
('26/01/2023', 'INV0014', 'CUS0001', 'GILANG', '087854215642', 'BABARSARI', '170000');

-- --------------------------------------------------------

--
-- Table structure for table `db_publisher`
--

CREATE TABLE `db_publisher` (
  `pubid` char(7) NOT NULL,
  `pubname` varchar(250) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `db_publisher`
--

INSERT INTO `db_publisher` (`pubid`, `pubname`) VALUES
('PUB0001', 'ERLANGGA'),
('PUB0002', 'GRAMEDIA PUSTAKA UTAMA'),
('PUB0003', 'GRASINDO'),
('PUB0004', 'BINTANG MEDIA'),
('PUB0005', 'BUKUNESIA'),
('PUB0006', 'MIZAN'),
('PUB0007', 'MIZAN FANTASI');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `db_books`
--
ALTER TABLE `db_books`
  ADD PRIMARY KEY (`bookid`);

--
-- Indexes for table `db_categories`
--
ALTER TABLE `db_categories`
  ADD PRIMARY KEY (`catid`);

--
-- Indexes for table `db_employee`
--
ALTER TABLE `db_employee`
  ADD PRIMARY KEY (`empid`);

--
-- Indexes for table `db_publisher`
--
ALTER TABLE `db_publisher`
  ADD PRIMARY KEY (`pubid`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
