-- phpMyAdmin SQL Dump
-- version 5.0.2
-- https://www.phpmyadmin.net/
--
-- Hôte : 127.0.0.1:3306
-- Généré le : mar. 04 mai 2021 à 04:32
-- Version du serveur :  5.7.31
-- Version de PHP : 7.3.21

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Base de données : `frais`
--

-- --------------------------------------------------------

--
-- Structure de la table `fichefrais`
--

DROP TABLE IF EXISTS `fichefrais`;
CREATE TABLE IF NOT EXISTS `fichefrais` (
  `idvisiteur` char(4) NOT NULL,
  `mois` char(6) NOT NULL,
  `nbjustificatifs` int(11) DEFAULT NULL,
  `montantvalide` decimal(10,2) DEFAULT NULL,
  `datemodif` date DEFAULT NULL,
  `idetat` char(2) DEFAULT 'CR',
  PRIMARY KEY (`idvisiteur`,`mois`),
  KEY `idetat` (`idetat`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Déchargement des données de la table `fichefrais`
--

INSERT INTO `fichefrais` (`idvisiteur`, `mois`, `nbjustificatifs`, `montantvalide`, `datemodif`, `idetat`) VALUES
('a131', '202102', 0, '170.00', '2021-05-04', 'MP'),
('a131', '202103', 0, '139.00', '2021-04-07', 'RB'),
('a131', '202104', 3, '0.00', '2021-04-05', 'CL'),
('a131', '202105', 0, '0.00', '2021-04-04', 'CR'),
('a17', '202104', 2, '921.00', '2021-04-07', 'CL'),
('a17', '202105', 0, '0.00', '2021-04-03', 'CR'),
('a55', '202101', 0, '142.00', '2021-04-07', 'RB'),
('a55', '202104', 0, '0.00', '2021-04-05', 'CL'),
('a93', '202103', 1, '0.00', '2021-02-28', 'CL'),
('a93', '202104', 0, '0.00', '2021-04-05', 'CL'),
('b13', '202104', 0, '0.00', '2021-04-07', 'CL'),
('b16', '202101', 0, '113.00', '2021-04-07', 'RB'),
('b16', '202102', 0, '92.00', '2021-04-07', 'RB'),
('b19', '202104', 0, '0.00', '2021-04-05', 'CL'),
('b25', '202104', 0, '0.00', '2021-04-07', 'CL'),
('b28', '202104', 0, '0.00', '2021-04-07', 'CL'),
('b34', '202101', 0, '130.00', '2021-04-07', 'RB'),
('b34', '202102', 0, '771.00', '2021-04-07', 'RB'),
('b34', '202104', 0, '0.00', '2021-04-07', 'CL'),
('b4', '202104', 0, '0.00', '2021-04-07', 'CL'),
('b50', '202104', 0, '0.00', '2021-04-07', 'CL'),
('b59', '202104', 0, '0.00', '2021-04-07', 'CL'),
('c14', '202104', 0, '0.00', '2021-04-07', 'CL'),
('c3', '202104', 0, '0.00', '2021-04-07', 'CL'),
('c54', '202104', 0, '5500.00', '2021-05-04', 'VA'),
('d13', '202104', 0, '0.00', '2021-04-07', 'CL'),
('d51', '202104', 0, '0.00', '2021-04-07', 'CL'),
('e22', '202104', 0, '0.00', '2021-04-07', 'CL'),
('e24', '202104', 0, '0.00', '2021-04-07', 'CL'),
('e39', '202104', 0, '0.00', '2021-04-07', 'CL'),
('e49', '202104', 0, '0.00', '2021-04-07', 'CL'),
('e5', '202104', 0, '0.00', '2021-04-07', 'CL'),
('e52', '202104', 0, '0.00', '2021-04-07', 'CL'),
('f21', '202104', 0, '0.00', '2021-04-07', 'CL'),
('f319', '202104', 0, '0.00', '2021-04-07', 'CL'),
('f4', '202104', 0, '0.00', '2021-04-07', 'CL');

--
-- Contraintes pour les tables déchargées
--

--
-- Contraintes pour la table `fichefrais`
--
ALTER TABLE `fichefrais`
  ADD CONSTRAINT `fichefrais_ibfk_1` FOREIGN KEY (`idetat`) REFERENCES `etat` (`id`),
  ADD CONSTRAINT `fichefrais_ibfk_2` FOREIGN KEY (`idvisiteur`) REFERENCES `visiteurs` (`id`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
