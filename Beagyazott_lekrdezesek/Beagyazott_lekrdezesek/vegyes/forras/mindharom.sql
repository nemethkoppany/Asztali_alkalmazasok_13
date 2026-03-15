SET NAMES utf8mb4;
SET FOREIGN_KEY_CHECKS = 0;

DROP DATABASE IF EXISTS `csatahajok`;
CREATE DATABASE `csatahajok` CHARACTER SET utf8mb4 COLLATE utf8mb4_hungarian_ci;
USE `csatahajok`;

--
DROP TABLE IF EXISTS Kimenetelek;
DROP TABLE IF EXISTS Csatak;
DROP TABLE IF EXISTS Hajok;
DROP TABLE IF EXISTS Hajoosztalyok;
--
CREATE TABLE Hajoosztalyok
(
	osztaly varchar(15),
	tipus varchar(3),
	orszag varchar(20),
	agyukszama int,
	kaliber int,
	vizkiszoritas int
);
INSERT INTO Hajoosztalyok values ( 'Bismark','bb','Németorszag',8,15,42000) ;
INSERT INTO Hajoosztalyok values ( 'Iowa','bb','USA',9,16,46000);
INSERT INTO Hajoosztalyok values ( 'Kongo','bc','Japán',8,14,32000);
INSERT INTO Hajoosztalyok values ( 'North Carolina','bb','USA',9,16,37000);
INSERT INTO Hajoosztalyok values ( 'Renown','bc','Nagy Britannia',6,15,32000);
INSERT INTO Hajoosztalyok values ( 'Revenge','bb','Nagy Britannia',8,15,29000);
INSERT INTO Hajoosztalyok values ( 'Tennessee','bb','USA',12,14,32000);
INSERT INTO Hajoosztalyok values ( 'Yamato','bb','Japán',9,18,65000);

--
CREATE TABLE Hajok
(
	hajonev varchar(20),
	osztaly varchar(15),
	felavatva int
);
INSERT INTO Hajok values ( 'California','Tennessee',1921);
INSERT INTO Hajok values ( 'Haruna','Kongo',1915);
INSERT INTO Hajok values ( 'Hiei','Kongo',1914);
INSERT INTO Hajok values ( 'Iowa','Iowa',1943);
INSERT INTO Hajok values ( 'Kirishima','Kongo',1915);
INSERT INTO Hajok values ( 'Kongo','Kongo',1913);
INSERT INTO Hajok values ( 'Missuri','Iowa',1944);
INSERT INTO Hajok values ( 'Musashi','Yamato',1942);
INSERT INTO Hajok values ( 'New Jersey','Iowa',1943);
INSERT INTO Hajok values ( 'North Carolina','North Carolina',1941);
INSERT INTO Hajok values ( 'Ramillies','Revenge',1917);
INSERT INTO Hajok values ( 'Renown','Renown',1916);
INSERT INTO Hajok values ( 'Repulse','Renown',1916);
INSERT INTO Hajok values ( 'Resolution','Revenge',1916);
INSERT INTO Hajok values ( 'Revenge','Revenge',1916);
INSERT INTO Hajok values ( 'Royal Oak','Revenge',1916);
INSERT INTO Hajok values ( 'Royal Sovereign','Revenge',1916);
INSERT INTO Hajok values ( 'Tennesse','Tennessee',1920);
INSERT INTO Hajok values ( 'Washington','North Carolina',1941);
INSERT INTO Hajok values ( 'Wisconsin','Iowa',1944);
INSERT INTO Hajok values ( 'Yamato','Yamato',1941);

--
CREATE TABLE Csatak
(
	csatanev varchar(15),
	datum varchar(15)
);
INSERT INTO Csatak values ( 'Denmark Strait','5/24-27/41');
INSERT INTO Csatak values ( 'Guadalcanal','11/15/42');
INSERT INTO Csatak values ( 'North Cape','12/26/43');
INSERT INTO Csatak values ( 'Suriago Strait','10/25/44');

--
CREATE TABLE Kimenetelek
(
	hajonev varchar(20),
	csatanev varchar(15),
	eredmeny varchar(15)
);
INSERT INTO Kimenetelek values ( 'Arizona','Pearl Harbour','elsüllyedt');
INSERT INTO Kimenetelek values ( 'Bismark','Denmark Strait','elsüllyedt');
INSERT INTO Kimenetelek values ( 'California','Surigao Strait','ép');
INSERT INTO Kimenetelek values ( 'Duke of York','North Cape','ép');
INSERT INTO Kimenetelek values ( 'Fuso','Surigao Strait','elsüllyedt');
INSERT INTO Kimenetelek values ( 'Hood','Denmark Strait','elsüllyedt');
INSERT INTO Kimenetelek values ( 'King George V','Denmark Strait','ép');
INSERT INTO Kimenetelek values ( 'Kirishima','Guadalcanal','elsüllyedt');
INSERT INTO Kimenetelek values ( 'Prince of Wales','Denmark Strait','megsérült');
INSERT INTO Kimenetelek values ( 'Rodney','Denmark Strait','ép');
INSERT INTO Kimenetelek values ( 'Scharnhorst','North Cape','elsüllyedt');
INSERT INTO Kimenetelek values ( 'South of Dakota','Guadalcanal','megsérült');
INSERT INTO Kimenetelek values ( 'Tennessee','Surigao Strait','ép');
INSERT INTO Kimenetelek values ( 'Washington','Guadalcanal','ép');
INSERT INTO Kimenetelek values ( 'West Wirginia','Surigao Strait','ép');
INSERT INTO Kimenetelek values ( 'Yamashiro','Surigao Strait','elsüllyedt');

--
commit; 

--
select * from Hajoosztalyok;
select * from Hajok;
select * from Csatak;
select * from Kimenetelek;

SET FOREIGN_KEY_CHECKS = 1;

SET NAMES utf8mb4;
SET FOREIGN_KEY_CHECKS = 0;

DROP DATABASE IF EXISTS `termekek`;
CREATE DATABASE `termekek` CHARACTER SET utf8mb4 COLLATE utf8mb4_hungarian_ci;
USE `termekek`;

DROP TABLE IF EXISTS Nyomtato;
DROP TABLE IF EXISTS Laptop;
DROP TABLE IF EXISTS PC;
DROP TABLE IF EXISTS Termek;
CREATE TABLE Termek(
	gyarto varchar(10),
	modell integer,
	tipus varchar(10)
	);
INSERT INTO Termek values ('A',1001,'pc');
INSERT INTO Termek values ('A',1002,'pc');
INSERT INTO Termek values ('A',1003,'pc');
INSERT INTO Termek values ('A',2004,'laptop');
INSERT INTO Termek values ('A',2005,'laptop');
INSERT INTO Termek values ('A',2006,'laptop');
INSERT INTO Termek values ('B',1004,'pc');
INSERT INTO Termek values ('B',1005,'pc');
INSERT INTO Termek values ('B',1006,'pc');
INSERT INTO Termek values ('B',2007,'laptop');
INSERT INTO Termek values ('C',1007,'pc');
INSERT INTO Termek values ('D',1008,'pc');
INSERT INTO Termek values ('D',1009,'pc');
INSERT INTO Termek values ('D',1010,'pc');
INSERT INTO Termek values ('D',3004,'nyomtató');
INSERT INTO Termek values ('D',3005,'nyomtató');
INSERT INTO Termek values ('E',1011,'pc');
INSERT INTO Termek values ('E',1012,'pc');
INSERT INTO Termek values ('E',1013,'pc');
INSERT INTO Termek values ('E',2001,'laptop');
INSERT INTO Termek values ('E',2002,'laptop');
INSERT INTO Termek values ('E',2003,'laptop');
INSERT INTO Termek values ('E',3001,'nyomtató');
INSERT INTO Termek values ('E',3002,'nyomtató');
INSERT INTO Termek values ('E',3003,'nyomtató');
INSERT INTO Termek values ('F',2008,'laptop');
INSERT INTO Termek values ('F',2009,'laptop');
INSERT INTO Termek values ('G',2010,'laptop');
INSERT INTO Termek values ('H',3006,'nyomtató');
INSERT INTO Termek values ('H',3007,'nyomtató');
CREATE TABLE PC(
	modell integer,
	sebesseg float,
	memoria integer,
	merevlemez integer,
	ar integer
	);
INSERT INTO PC values (1001,2.66,1024,250,2114);
INSERT INTO PC values (1002,2.10,512,250,995);
INSERT INTO PC values (1003,1.42,512,80,478);
INSERT INTO PC values (1004,2.80,1024,250,649);
INSERT INTO PC values (1005,3.20,512,250,630);
INSERT INTO PC values (1006,3.20,1024,320,1049);
INSERT INTO PC values (1007,2.20,1024,200,510);
INSERT INTO PC values (1008,2.20,2048,250,770);
INSERT INTO PC values (1009,2.00,1024,250,650);
INSERT INTO PC values (1010,2.80,2048,300,770);
INSERT INTO PC values (1011,1.86,2048,160,959);
INSERT INTO PC values (1012,2.80,1024,160,649);
INSERT INTO PC values (1013,3.06,512,80,529);
CREATE TABLE Laptop(
	modell integer,
	sebesseg float,
	memoria integer,
	merevlemez integer,
	kepernyo float,
	ar integer
	);
INSERT INTO Laptop values (2001,2.00,2048,240,20.1,3673);
INSERT INTO Laptop values (2002,1.73,1024,80,17.0,949);
INSERT INTO Laptop values (2003,1.80,512,60,15.4,549);
INSERT INTO Laptop values (2004,2.00,512,60,13.3,1150);
INSERT INTO Laptop values (2005,2.16,1024,120,17.0,2500);
INSERT INTO Laptop values (2006,2.00,2048,80,15.4,1700);
INSERT INTO Laptop values (2007,1.83,1024,120,13.3,1429);
INSERT INTO Laptop values (2008,1.60,1024,100,15.4,900);
INSERT INTO Laptop values (2009,1.60,512,80,14.1,680);
INSERT INTO Laptop values (2010,2.00,2048,160,15.4,2300);
CREATE TABLE Nyomtato(
	modell integer,
	szines varchar(5),
	tipus varchar(15),
	ar integer);
INSERT INTO Nyomtato values (3001,'igen','tintasugaras',3673);
INSERT INTO Nyomtato values (3002,'nem','lézer',949);
INSERT INTO Nyomtato values (3003,'igen','lézer',549);
INSERT INTO Nyomtato values (3004,'igen','tintasugaras',1150);
INSERT INTO Nyomtato values (3005,'nem','lézer',2500);
INSERT INTO Nyomtato values (3006,'igen','tintasugaras',1700);
INSERT INTO Nyomtato values (3007,'igen','lézer',1429);

commit; 

select * from Termek;
select * from PC;
select * from Laptop;
select * from Nyomtato;

SET FOREIGN_KEY_CHECKS = 1;

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
