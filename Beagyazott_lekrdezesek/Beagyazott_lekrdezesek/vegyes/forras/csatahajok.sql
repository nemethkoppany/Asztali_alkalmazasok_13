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
