-- phpMyAdmin SQL Dump
-- version 5.2.0
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Jan 03, 2023 at 04:15 PM
-- Server version: 10.4.27-MariaDB
-- PHP Version: 8.2.0

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `gorsal`
--

-- --------------------------------------------------------

--
-- Table structure for table `bilgi`
--

CREATE TABLE `bilgi` (
  `id` int(11) NOT NULL,
  `adi` text NOT NULL,
  `soyadi` text NOT NULL,
  `email` text NOT NULL,
  `telefone` int(11) NOT NULL,
  `adres` text NOT NULL,
  `adet` int(11) NOT NULL,
  `size` text NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `bilgi`
--

INSERT INTO `bilgi` (`id`, `adi`, `soyadi`, `email`, `telefone`, `adres`, `adet`, `size`) VALUES
(1, 'muhammed', 'korc', 'mhmdkorg@gmail.com', 2147483647, 'oefjiopfjwfj', 3, ''),
(2, 'muhammed23', 'korc', 'ksljfkld', 53723423, 'iefusoifuiw;af', 4, '41'),
(3, 'motasem', 'alhomsi', 'motasem@gmail.com', 59985243, 'dgfje kjlkjoi ghg khiukh', 3, 'XL');

-- --------------------------------------------------------

--
-- Table structure for table `odeme`
--

CREATE TABLE `odeme` (
  `id` int(11) NOT NULL,
  `kartno` int(11) NOT NULL,
  `ay` int(11) NOT NULL,
  `cvv` int(11) NOT NULL,
  `kartname` text NOT NULL,
  `not` text NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `odeme`
--

INSERT INTO `odeme` (`id`, `kartno`, `ay`, `cvv`, `kartname`, `not`) VALUES
(1, 54738392, 23, 344, 'sfnkSAFJ;SKFJ', 'EJIFQOHEOFIQA'),
(2, 2147483647, 20, 366, 'motasem', 'jhdjdhf uyegduyshk yrugfedshkuj');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `bilgi`
--
ALTER TABLE `bilgi`
  ADD PRIMARY KEY (`id`);

--
-- Indexes for table `odeme`
--
ALTER TABLE `odeme`
  ADD PRIMARY KEY (`id`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `bilgi`
--
ALTER TABLE `bilgi`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=4;

--
-- AUTO_INCREMENT for table `odeme`
--
ALTER TABLE `odeme`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
