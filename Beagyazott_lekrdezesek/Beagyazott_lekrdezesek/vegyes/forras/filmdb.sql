SET NAMES utf8mb4;
SET FOREIGN_KEY_CHECKS = 0;

DROP DATABASE IF EXISTS `filmdb`;
CREATE DATABASE `filmdb` CHARACTER SET utf8mb4 COLLATE utf8mb4_hungarian_ci;
USE `filmdb`;

-- Adatbázis és alapstruktúra

DROP TABLE IF EXISTS Naplo;
DROP TABLE IF EXISTS SzerepelBenne;
DROP TABLE IF EXISTS FilmSzínész;
DROP TABLE IF EXISTS Filmek;
DROP TABLE IF EXISTS Stúdió;
DROP TABLE IF EXISTS GyártásIrányító;
CREATE TABLE GyártásIrányító (
  azonosító INT PRIMARY KEY,
  név VARCHAR(100) NOT NULL,
  cím VARCHAR(200),
  nettóBevétel INT
);
CREATE TABLE Stúdió (
  név VARCHAR(50) PRIMARY KEY,
  cím VARCHAR(200),
  elnökAzon INT,
  CONSTRAINT fk_studio_vezeto FOREIGN KEY (elnökAzon) REFERENCES GyártásIrányító(azonosító)
);
CREATE TABLE Filmek (
  filmcím VARCHAR(100) NOT NULL,
  év INT NOT NULL,
  hossz INT NOT NULL,
  műfaj VARCHAR(30),
  stúdióNév VARCHAR(50),
  producerAzon INT,
  PRIMARY KEY (filmcím, év),
  CONSTRAINT fk_film_studio FOREIGN KEY (stúdióNév) REFERENCES Stúdió(név),
  CONSTRAINT fk_film_producer FOREIGN KEY (producerAzon) REFERENCES GyártásIrányító(azonosító)
) ENGINE=InnoDB;
CREATE TABLE FilmSzínész (
  név VARCHAR(100) PRIMARY KEY,
  cím VARCHAR(200),
  nem CHAR(1) CHECK (nem IN ('N','F')),
  születésiDátum DATE
);
CREATE TABLE SzerepelBenne (
  filmCím VARCHAR(100) NOT NULL,
  filmÉv INT NOT NULL,
  színészNév VARCHAR(100) NOT NULL,
  PRIMARY KEY (filmCím, filmÉv, színészNév),
  CONSTRAINT fk_szb_film FOREIGN KEY (filmCím, filmÉv) REFERENCES Filmek(filmcím, év),
  CONSTRAINT fk_szb_szin FOREIGN KEY (színészNév) REFERENCES FilmSzínész(név)
) ENGINE=InnoDB;
CREATE TABLE Naplo (
  id INT AUTO_INCREMENT PRIMARY KEY,
  művelet ENUM('INSERT','UPDATE','DELETE') NOT NULL,
  filmcím VARCHAR(100),
  év INT,
  időpont TIMESTAMP DEFAULT CURRENT_TIMESTAMP,
  megjegyzés TEXT
) ENGINE=InnoDB;

-- Mintaadatok
INSERT INTO GyártásIrányító (azonosító, név, cím, nettóBevétel) VALUES
  (10,'John Producer','Los Angeles',5000000),
  (20,'Jane Boss','New York',8000000),
  (30,'P. Elnök','Paramount HQ',12000000);
INSERT INTO Stúdió (név, cím, elnökAzon) VALUES
  ('Paramount','Hollywood Blvd 1.',30),
  ('MGM','MGM Avenue 5.',NULL),
  ('Universal','Studio City 99.',NULL);
INSERT INTO FilmSzínész (név, cím, nem, születésiDátum) VALUES
  ('Emma Stone','LA', 'N','1988-11-06'),
  ('Tom Hanks','LA', 'F','1956-07-09'),
  ('Scarlett Johansson','NY', 'N','1984-11-22');
INSERT INTO Filmek (filmcím, év, hossz, műfaj, stúdióNév, producerAzon) VALUES
  ('Wayne világa',1992,95,'vígjáték','Paramount',10),
  ('Forrest Gump',1994,142,'dráma','Paramount',20),
  ('Jurassic World',2015,124,'sci-fi','Universal',20),
  ('Dune',2021,155,'sci-fi','MGM',10);
INSERT INTO SzerepelBenne (filmCím, filmÉv, színészNév) VALUES
  ('Forrest Gump',1994,'Tom Hanks'),
  ('Jurassic World',2015,'Scarlett Johansson'); -- (csak példa)

SET FOREIGN_KEY_CHECKS = 1;
