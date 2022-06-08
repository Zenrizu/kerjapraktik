-- phpMyAdmin SQL Dump
-- version 4.8.4
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Jun 08, 2022 at 04:43 AM
-- Server version: 10.1.37-MariaDB
-- PHP Version: 7.3.1

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET AUTOCOMMIT = 0;
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `toga_abadi_v2`
--

-- --------------------------------------------------------

--
-- Table structure for table `artikelpotongs`
--

CREATE TABLE `artikelpotongs` (
  `id` varchar(30) NOT NULL,
  `brand` varchar(45) NOT NULL,
  `kain` varchar(45) NOT NULL,
  `seri` varchar(2) NOT NULL,
  `yard` int(11) NOT NULL DEFAULT '1',
  `size_S` int(11) NOT NULL DEFAULT '0',
  `size_M` int(11) NOT NULL DEFAULT '0',
  `size_L` int(11) NOT NULL DEFAULT '0',
  `size_XL` int(11) NOT NULL DEFAULT '0'
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Dumping data for table `artikelpotongs`
--

INSERT INTO `artikelpotongs` (`id`, `brand`, `kain`, `seri`, `yard`, `size_S`, `size_M`, `size_L`, `size_XL`) VALUES
('L001-06-06-2022-17-40-39', 'Cruz', 'Flanel', 'A', 20, 10, 10, 10, 10),
('L002-06-07-2022-12-04-04', 'Zotyco', 'Spandex', 'A', 15, 20, 20, 20, 20);

-- --------------------------------------------------------

--
-- Table structure for table `bagians`
--

CREATE TABLE `bagians` (
  `id` int(11) NOT NULL,
  `id_artikel` varchar(30) NOT NULL,
  `bagian` varchar(30) NOT NULL,
  `tersedia` int(11) NOT NULL,
  `biaya_satuan` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Dumping data for table `bagians`
--

INSERT INTO `bagians` (`id`, `id_artikel`, `bagian`, `tersedia`, `biaya_satuan`) VALUES
(1, 'L001-06-06-2022-17-40-39', 'Badan (include badan depan, be', 20, 6000),
(2, 'L001-06-06-2022-17-40-39', 'Krah ', 40, 2000),
(3, 'L001-06-06-2022-17-40-39', 'Tindes tangan', 10, 5000),
(4, 'L002-06-07-2022-12-04-04', 'Lipat bawah', 60, 2000),
(5, 'L002-06-07-2022-12-04-04', 'Badan (include badan depan, be', 80, 25000),
(6, 'L002-06-07-2022-12-04-04', 'Tindes tangan', 80, 5000);

-- --------------------------------------------------------

--
-- Table structure for table `gajis`
--

CREATE TABLE `gajis` (
  `id` int(11) NOT NULL,
  `pekerjas_id` int(11) NOT NULL,
  `tempat` varchar(45) NOT NULL,
  `tanggal` datetime NOT NULL DEFAULT CURRENT_TIMESTAMP,
  `subtotal` int(11) NOT NULL,
  `kasbon` int(11) NOT NULL,
  `totalGaji` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Dumping data for table `gajis`
--

INSERT INTO `gajis` (`id`, `pekerjas_id`, `tempat`, `tanggal`, `subtotal`, `kasbon`, `totalGaji`) VALUES
(59, 2, 'pusat', '2022-06-07 14:20:35', 75000, 25000, 100000),
(60, 1, 'pusat', '2022-06-07 15:24:52', 190000, 25000, 165000),
(61, 1, 'Pusat', '2022-05-06 14:29:31', 130000, 50000, 155000),
(66, 1, 'porong', '2022-06-08 09:23:29', 120000, 0, 70000),
(67, 2, 'Darmo', '2022-06-08 09:38:45', 150000, 0, 125000);

-- --------------------------------------------------------

--
-- Table structure for table `pekerjas`
--

CREATE TABLE `pekerjas` (
  `id` int(11) NOT NULL,
  `nama` varchar(45) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Dumping data for table `pekerjas`
--

INSERT INTO `pekerjas` (`id`, `nama`) VALUES
(1, 'marcopolo'),
(2, 'christo');

-- --------------------------------------------------------

--
-- Table structure for table `terambils`
--

CREATE TABLE `terambils` (
  `bagians_id` int(11) NOT NULL,
  `gajis_id` int(11) NOT NULL,
  `diambil` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Dumping data for table `terambils`
--

INSERT INTO `terambils` (`bagians_id`, `gajis_id`, `diambil`) VALUES
(1, 59, 10),
(1, 62, 30),
(1, 66, 20),
(2, 59, 10),
(3, 60, 30),
(3, 67, 30),
(4, 60, 20);

-- --------------------------------------------------------

--
-- Table structure for table `users`
--

CREATE TABLE `users` (
  `username` varchar(16) NOT NULL,
  `password` varchar(45) NOT NULL,
  `pekerjas_id` int(11) NOT NULL,
  `IsAdmin` tinyint(4) NOT NULL DEFAULT '0'
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Dumping data for table `users`
--

INSERT INTO `users` (`username`, `password`, `pekerjas_id`, `IsAdmin`) VALUES
('admin1', 'admin', 1, 1),
('admin2', 'admin', 2, 1);

--
-- Indexes for dumped tables
--

--
-- Indexes for table `artikelpotongs`
--
ALTER TABLE `artikelpotongs`
  ADD PRIMARY KEY (`id`);

--
-- Indexes for table `bagians`
--
ALTER TABLE `bagians`
  ADD PRIMARY KEY (`id`),
  ADD KEY `fk_models_artikelPotongs1_idx` (`id_artikel`);

--
-- Indexes for table `gajis`
--
ALTER TABLE `gajis`
  ADD PRIMARY KEY (`id`),
  ADD KEY `fk_gajis_pekerjas2_idx` (`pekerjas_id`);

--
-- Indexes for table `pekerjas`
--
ALTER TABLE `pekerjas`
  ADD PRIMARY KEY (`id`);

--
-- Indexes for table `terambils`
--
ALTER TABLE `terambils`
  ADD PRIMARY KEY (`bagians_id`,`gajis_id`),
  ADD KEY `fk_bagians_has_gajis_gajis1_idx` (`gajis_id`),
  ADD KEY `fk_bagians_has_gajis_bagians1_idx` (`bagians_id`);

--
-- Indexes for table `users`
--
ALTER TABLE `users`
  ADD PRIMARY KEY (`username`),
  ADD KEY `fk_users_pekerjas1_idx` (`pekerjas_id`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `bagians`
--
ALTER TABLE `bagians`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=7;

--
-- AUTO_INCREMENT for table `gajis`
--
ALTER TABLE `gajis`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=68;

--
-- AUTO_INCREMENT for table `pekerjas`
--
ALTER TABLE `pekerjas`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;

--
-- Constraints for dumped tables
--

--
-- Constraints for table `bagians`
--
ALTER TABLE `bagians`
  ADD CONSTRAINT `fk_models_artikelPotongs1` FOREIGN KEY (`id_artikel`) REFERENCES `artikelpotongs` (`id`) ON DELETE NO ACTION ON UPDATE NO ACTION;

--
-- Constraints for table `gajis`
--
ALTER TABLE `gajis`
  ADD CONSTRAINT `fk_gajis_pekerjas2` FOREIGN KEY (`pekerjas_id`) REFERENCES `pekerjas` (`id`) ON DELETE NO ACTION ON UPDATE NO ACTION;

--
-- Constraints for table `terambils`
--
ALTER TABLE `terambils`
  ADD CONSTRAINT `fk_bagians_has_gajis_bagians1` FOREIGN KEY (`bagians_id`) REFERENCES `bagians` (`id`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  ADD CONSTRAINT `fk_bagians_has_gajis_gajis1` FOREIGN KEY (`gajis_id`) REFERENCES `gajis` (`id`) ON DELETE NO ACTION ON UPDATE NO ACTION;

--
-- Constraints for table `users`
--
ALTER TABLE `users`
  ADD CONSTRAINT `fk_users_pekerjas1` FOREIGN KEY (`pekerjas_id`) REFERENCES `pekerjas` (`id`) ON DELETE NO ACTION ON UPDATE NO ACTION;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
