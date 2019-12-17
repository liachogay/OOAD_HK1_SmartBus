CREATE DATABASE SMARTBUS
go
USE SMARTBUS

GO

CREATE TABLE BANK (
	BANKID varchar(10) PRIMARY KEY NOT NULL,
	BANKMONEY INT NOT NULL DEFAULT 200000,
);
GO

CREATE TABLE CUSTOMER (
	USERID VARCHAR(30) PRIMARY KEY NOT NULL,
	PASSWORDID VARCHAR(30) NOT NULL,
	NAMECUS VARCHAR(50) NOT NULL,
	AGECUS INT NOT NULL,
	BANKID varchar(10) NOT NULL,
	ISSTUDENT BIT NOT NULL DEFAULT 0,
	CONSTRAINT FK_BANKID FOREIGN KEY (BANKID) REFERENCES BANK(BANKID)
);
GO

CREATE TABLE BUS (
	BUSID INT PRIMARY KEY NOT NULL,
	NUMBERCHAIRBUS INT,
);
GO

CREATE TABLE STATIONBUS (
	NUMBERSTATION NUMERIC PRIMARY KEY NOT NULL,
	BUSID INT NOT NULL,
	ADDRESSSTATION VARCHAR(100) NOT NULL,
	CONSTRAINT FK_BUSID FOREIGN KEY (BUSID) REFERENCES BUS(BUSID)
);
GO

CREATE TABLE TRACKER (
	USERNAMEID VARCHAR(30) NOT NULL,
	NUMBERBUSID INT NOT NULL,
	POSTIONBUSUP INT NOT NULL,
	POSTIONBUSDOWN INT NOT NULL,
	CONSTRAINT FK_USERNAMEID FOREIGN KEY (USERNAMEID) REFERENCES CUSTOMER(USERID),
	CONSTRAINT FK_NUMBERBUSID FOREIGN KEY (NUMBERBUSID) REFERENCES BUS(BUSID)
);
GO