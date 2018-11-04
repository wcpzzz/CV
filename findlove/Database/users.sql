-- phpMyAdmin SQL Dump
-- version 4.8.3
-- https://www.phpmyadmin.net/
--
-- 主机： 127.0.0.1:3306
-- 生成日期： 2018-10-22 10:54:26
-- 服务器版本： 5.7.23
-- PHP 版本： 7.2.10

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET AUTOCOMMIT = 0;
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- 数据库： `login_test`
--

-- --------------------------------------------------------

--
-- 表的结构 `users`
--

DROP TABLE IF EXISTS `users`;
CREATE TABLE IF NOT EXISTS `users` (
  `user_id` int(11) NOT NULL AUTO_INCREMENT,
  `user_name` varchar(256) NOT NULL,
  `user_email` varchar(256) DEFAULT NULL,
  `user_uid` varchar(256) DEFAULT NULL,
  `user_pwd` varchar(256) NOT NULL,
  `user_qq` varchar(256) DEFAULT NULL,
  `user_phone` varchar(256) NOT NULL,
  `user_professed` json DEFAULT NULL,
  PRIMARY KEY (`user_id`)
) ENGINE=MyISAM AUTO_INCREMENT=2 DEFAULT CHARSET=utf8mb4;

--
-- 转存表中的数据 `users`
--

INSERT INTO `users` (`user_id`, `user_name`, `user_email`, `user_uid`, `user_pwd`, `user_qq`, `user_phone`, `user_professed`) VALUES
(1, 'é©¬å¸…', 'pinatsu@outlook.com', NULL, '$2y$10$D902hy8DtSnJrIV8E1CE4edlOA4gF.18Bo1Abo79I/SSCeD1tJAwy', '1109681438', '18647900152', '{\"friends\": [\"44444\", \"ssss\", \"mashuai\", \"6666\", \"7777777\"]}');
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
