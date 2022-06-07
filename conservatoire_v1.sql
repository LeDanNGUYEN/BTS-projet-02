-- phpMyAdmin SQL Dump
-- version 5.0.2
-- https://www.phpmyadmin.net/
--
-- Hôte : 127.0.0.1:3306
-- Généré le : mar. 07 juin 2022 à 21:53
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
-- Base de données : `conservatoire_v1`
--

-- --------------------------------------------------------

--
-- Structure de la table `adherent`
--

DROP TABLE IF EXISTS `adherent`;
CREATE TABLE IF NOT EXISTS `adherent` (
  `adherent_id` int(100) NOT NULL,
  `adherent_niveau` int(100) NOT NULL DEFAULT '1',
  PRIMARY KEY (`adherent_id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Déchargement des données de la table `adherent`
--

INSERT INTO `adherent` (`adherent_id`, `adherent_niveau`) VALUES
(1, 1),
(7, 1),
(8, 1),
(9, 1),
(10, 1),
(11, 1),
(12, 1),
(13, 1),
(14, 1),
(15, 1),
(17, 1),
(18, 1);

-- --------------------------------------------------------

--
-- Structure de la table `cours`
--

DROP TABLE IF EXISTS `cours`;
CREATE TABLE IF NOT EXISTS `cours` (
  `cours_id` int(100) NOT NULL AUTO_INCREMENT,
  `cours_horaire` datetime NOT NULL,
  `cours_nbPlaces` int(100) NOT NULL,
  `cours_prix` int(255) NOT NULL DEFAULT '0',
  `cours_professeurId` int(100) NOT NULL,
  `cours_instrumentId` int(100) NOT NULL,
  PRIMARY KEY (`cours_id`),
  KEY `liaison cours/professeur_id` (`cours_professeurId`),
  KEY `liaison cours/instrument_id` (`cours_instrumentId`)
) ENGINE=InnoDB AUTO_INCREMENT=6 DEFAULT CHARSET=utf8;

--
-- Déchargement des données de la table `cours`
--

INSERT INTO `cours` (`cours_id`, `cours_horaire`, `cours_nbPlaces`, `cours_prix`, `cours_professeurId`, `cours_instrumentId`) VALUES
(1, '2022-07-01 09:30:09', 10, 50, 3, 1),
(2, '2022-07-01 14:00:00', 15, 60, 4, 2),
(3, '2022-07-04 08:30:00', 50, 30, 5, 3),
(4, '2022-07-04 11:00:10', 40, 40, 6, 4),
(5, '2022-07-02 09:00:00', 30, 30, 16, 5);

-- --------------------------------------------------------

--
-- Structure de la table `inscription`
--

DROP TABLE IF EXISTS `inscription`;
CREATE TABLE IF NOT EXISTS `inscription` (
  `inscription_adherentId` int(100) NOT NULL,
  `inscription_coursId` int(100) NOT NULL,
  `inscription_validee` int(1) NOT NULL DEFAULT '0',
  `inscription_montantPaye` int(255) NOT NULL DEFAULT '0',
  PRIMARY KEY (`inscription_adherentId`,`inscription_coursId`),
  KEY `inscription/cours_id` (`inscription_coursId`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Déchargement des données de la table `inscription`
--

INSERT INTO `inscription` (`inscription_adherentId`, `inscription_coursId`, `inscription_validee`, `inscription_montantPaye`) VALUES
(1, 1, 1, 50),
(1, 2, 0, 0),
(1, 3, 0, 0),
(1, 5, 0, 20),
(7, 1, 0, 0),
(7, 2, 0, 0),
(7, 3, 0, 0),
(7, 4, 0, 0),
(7, 5, 0, 0),
(8, 2, 0, 0),
(8, 4, 0, 0),
(9, 3, 0, 0),
(9, 5, 0, 0),
(10, 4, 0, 0),
(12, 5, 0, 0),
(13, 1, 0, 0),
(14, 2, 0, 0),
(15, 3, 0, 0),
(18, 1, 0, 20);

-- --------------------------------------------------------

--
-- Structure de la table `instrument`
--

DROP TABLE IF EXISTS `instrument`;
CREATE TABLE IF NOT EXISTS `instrument` (
  `instrument_id` int(100) NOT NULL AUTO_INCREMENT,
  `instrument_nom` varchar(100) NOT NULL,
  PRIMARY KEY (`instrument_id`)
) ENGINE=InnoDB AUTO_INCREMENT=6 DEFAULT CHARSET=utf8;

--
-- Déchargement des données de la table `instrument`
--

INSERT INTO `instrument` (`instrument_id`, `instrument_nom`) VALUES
(1, 'violon'),
(2, 'piano'),
(3, 'guitare'),
(4, 'hautbois'),
(5, 'chant');

-- --------------------------------------------------------

--
-- Structure de la table `person`
--

DROP TABLE IF EXISTS `person`;
CREATE TABLE IF NOT EXISTS `person` (
  `person_id` int(100) NOT NULL AUTO_INCREMENT,
  `person_nom` varchar(255) NOT NULL,
  `person_prenom` varchar(255) NOT NULL,
  `person_tel` varchar(255) NOT NULL,
  `person_adresse` varchar(255) NOT NULL,
  `person_mail` varchar(255) NOT NULL,
  `person_mdp` varchar(255) NOT NULL,
  PRIMARY KEY (`person_id`)
) ENGINE=InnoDB AUTO_INCREMENT=19 DEFAULT CHARSET=utf8;

--
-- Déchargement des données de la table `person`
--

INSERT INTO `person` (`person_id`, `person_nom`, `person_prenom`, `person_tel`, `person_adresse`, `person_mail`, `person_mdp`) VALUES
(1, 'test', 'test', '0102030405', '101 rue des Conservatoires', 'test@fakemail.com', 'test'),
(2, 'admin', 'admin', '0908070605', '09 rue des Admins', 'admin@fakemail.com', 'admin'),
(3, 'DUBOIS', 'Jean', '0604060406', '01 rue Musique', 'j.dubois@fakemail.com', 'JeanDubois'),
(4, 'GEORGES', 'Alex', '0709070907', '02 rue Musique', 'a.georges@fakemail.com', 'AlexGeorges'),
(5, 'ANTARES', 'Marie', '0205020502', '03 rue Musique', 'm.antares@fakemail.com', 'MarieAntares'),
(6, 'YUN', 'Chi', '0103010301', '04 rue Musique', 'c.yun@fakemail.com', 'ChiYun'),
(7, 'marie', 'marie', '0102030405', '11 rue Marie', 'marie2@fakemail.com', 'marie'),
(8, 'paul', 'paul', '0102030405', '01 rue Paul', 'paul@fakemail.com', 'paul'),
(9, 'BOB MALKOVITCH', 'John', '0203040506', '01 rue Bob Malkovitch', 'malkovitch@fakemail.com', 'malkovitch'),
(10, 'bob', 'bob', '0405060708', '01 rue Bob', 'bob@fakemail.com', 'bob'),
(11, 'test2', 'test2', '0809101112', '02 rue des Tests', 'test2@fakemail.com', 'test2'),
(12, 'CONSTANTINE', 'John Doe', '0807060504', '01 rue de l\'Eglise', 'jdc@fakemail.com', 'jdc'),
(13, 'PEN', 'Henry', '0104070205', '01 rue des Henry', 'henry@fakemail.com', 'henry'),
(14, 'CINE', 'cine', '0707070707', '07 rue des Arts', '7art@fakemail.com', 'cine'),
(15, 'PORTER', 'Jack', '0709080205', '01 avenue Porte', 'j.porter@fakemail.com', 'porter'),
(16, 'GOULCHEV', 'Dimitry', '0808080808', '05 rue Kolkin', 'd.goulchev@fakemail.com', 'goulchev'),
(17, 'test3', 'test3', '0000000000', '03 rue test3', 'test3@fakemail.com', 'test3'),
(18, 'test4', 'test4', '1111111111', '42 rue Test4', 'test42@fakemail.com', 'test4');

--
-- Déclencheurs `person`
--
DROP TRIGGER IF EXISTS `verifPersonDouble`;
DELIMITER $$
CREATE TRIGGER `verifPersonDouble` BEFORE INSERT ON `person` FOR EACH ROW Begin

DECLARE nb INTEGER ;
SELECT COUNT(*) INTO nb
FROM person
WHERE person_nom = NEW.person_nom 
and person_prenom = NEW.person_prenom;
  
   IF (nb>0) THEN
      SIGNAL SQLSTATE "45000" 
      SET MESSAGE_TEXT = "adherent déja existant" ; 
   END IF ;

END
$$
DELIMITER ;

-- --------------------------------------------------------

--
-- Structure de la table `prof`
--

DROP TABLE IF EXISTS `prof`;
CREATE TABLE IF NOT EXISTS `prof` (
  `prof_id` int(100) NOT NULL,
  `prof_salaire` int(255) NOT NULL DEFAULT '0',
  PRIMARY KEY (`prof_id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Déchargement des données de la table `prof`
--

INSERT INTO `prof` (`prof_id`, `prof_salaire`) VALUES
(3, 0),
(4, 0),
(5, 0),
(6, 0),
(16, 0);

--
-- Contraintes pour les tables déchargées
--

--
-- Contraintes pour la table `adherent`
--
ALTER TABLE `adherent`
  ADD CONSTRAINT `liaison adherent_id/personne_id` FOREIGN KEY (`adherent_id`) REFERENCES `person` (`person_id`);

--
-- Contraintes pour la table `cours`
--
ALTER TABLE `cours`
  ADD CONSTRAINT `liaison cours/instrument_id` FOREIGN KEY (`cours_instrumentId`) REFERENCES `instrument` (`instrument_id`),
  ADD CONSTRAINT `liaison cours/professeur_id` FOREIGN KEY (`cours_professeurId`) REFERENCES `prof` (`prof_id`);

--
-- Contraintes pour la table `inscription`
--
ALTER TABLE `inscription`
  ADD CONSTRAINT `inscription/adherent_id` FOREIGN KEY (`inscription_adherentId`) REFERENCES `adherent` (`adherent_id`),
  ADD CONSTRAINT `inscription/cours_id` FOREIGN KEY (`inscription_coursId`) REFERENCES `cours` (`cours_id`);

--
-- Contraintes pour la table `prof`
--
ALTER TABLE `prof`
  ADD CONSTRAINT `liaison prof_id/personne_id` FOREIGN KEY (`prof_id`) REFERENCES `person` (`person_id`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
