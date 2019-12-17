CREATE DATABASE SMARTBUS
USE SMARTBUS
GO

CREATE TABLE LOGINCUR (
	USERNAMES VARCHAR (30) PRIMARY KEY NOT NULL,
	PASSWORDS VARCHAR(30) NOT NULL
);
GO

CREATE TABLE REGISTER (
	USERID VARCHAR(30) PRIMARY KEY NOT NULL,
	PASSWORDID VARCHAR(30) NOT NULL,
	NAMECUR VARCHAR(50) NOT NULL,
	AGECUR INT NOT NULL,
	ISSTUDENT BIT NOT NULL DEFAULT 0
);

CREATE TABLE INFOCUR (
	USERID INT PRIMARY KEY NOT NULL,
	NAMECUR VARCHAR (50),
	IDBANK VARCHAR (15),
	ISSTUDENT BIT NOT NULL DEFAULT 0,
	NUMBERBUS INT NOT NULL
);
GO

CREATE TABLE TRACKER (
	NUMBERBUSID INT PRIMARY KEY NOT NULL,
	POSTIONBUSUP INT,
	POSTIONBUSDOWN INT
);
GO

CREATE TABLE STATIONBUS (
	NUMBERSTATION INT PRIMARY KEY NOT NULL,
);
GO

CREATE TABLE BUS (
	BUSID INT PRIMARY KEY NOT NULL,
	NUMBERCHAIRBUS INT,
	SUMHAVEPEOPLE INT,
);
GO