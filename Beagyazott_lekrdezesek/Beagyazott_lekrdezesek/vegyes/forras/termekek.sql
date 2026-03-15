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
