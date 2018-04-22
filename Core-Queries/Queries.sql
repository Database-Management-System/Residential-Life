-- Create Database
Create database ResidentialLife
-- Create Table DeskAssistant
USE ResidentialLife
CREATE TABLE dbo.DeskAssistant (
    Username varchar(255) PRIMARY KEY,
    EmailId varchar(255) NOT NULL UNIQUE,
    Password varchar(255) NOT NULL,
	Name varchar(255) NOT NULL
);

DROP TABLE dbo.DeskAssistant
-- Create Table Resident
USE ResidentialLife
CREATE TABLE dbo.Resident
(
    StudentId INT,
    ResidentName VARCHAR(255) NOT NULL,
    Gender VARCHAR(255) NOT NULL,
    CHECK(Gender IN ('M','F','O')),
    PhoneNo VARCHAR(15),
    EmailId VARCHAR(255) NOT NULL UNIQUE,
    Hall varchar(255) NOT NULL,
    RoomNo INT NOT NULL,
    DateOfBirth DATE NOT NULL,
    CHECK(DATEDIFF(YEAR,DateOfBirth,GETDATE())>16),
    Balance DECIMAL NOT NULL,
    CHECK(Balance>0),
    PRIMARY KEY(StudentId)
);

DROP TABLE dbo.Resident
-- Create Table GuestLog
USE ResidentialLife
CREATE TABLE dbo.GuestLog(
    GuestLogId INT IDENTITY(1,1) PRIMARY KEY,
    ResidentName VARCHAR(255) NOT NULL,
    GuestName VARCHAR(255) NOT NULL,
    StudentId INT NOT NULL,
    Guest_In DATETIME NOT NULL DEFAULT GETDATE(), 
    Guest_Out DATETIME NOT NULL,
    FOREIGN KEY (StudentId) REFERENCES dbo.Resident(StudentId)   
);

DROP TABLE dbo.GuestLog
-- Create Table Package
USE ResidentialLife
CREATE TABLE dbo.Package(
    PackageId INT IDENTITY(1,1) PRIMARY KEY,
    StudentId INT NOT NULL,
    Perishable BIT NOT NULL,
    Date_In DATE NOT NULL DEFAULT GETDATE(), 
    Date_Out DATE NOT NULL,
    FOREIGN KEY (StudentId) REFERENCES dbo.Resident(StudentId)   
);

DROP TABLE dbo.Package
-- Create Table Equipment
USE ResidentialLife
CREATE TABLE dbo.Equipment(
    EquipmentId INT IDENTITY(1,1) PRIMARY KEY,
    StudentId INT NOT NULL,
    ItemName VARCHAR(255) NOT NULL,
    Availability INT,
    CHECK(Availability>0),
    Damaged BIT NOT NULL,
    Date_In DATETIME NOT NULL DEFAULT GETDATE(), 
    Date_Out DATETIME NOT NULL,
    FOREIGN KEY (StudentId) REFERENCES dbo.Resident(StudentId),
    FOREIGN KEY (ItemName) REFERENCES dbo.Stock(ItemName)   
);

DROP TABLE dbo.Equipment
-- Create Table Cafe
USE ResidentialLife
CREATE TABLE dbo.Cafe(
    ItemId INT IDENTITY(1,1) PRIMARY KEY,
    StudentId INT NOT NULL,
    ItemName VARCHAR(255) NOT NULL,
    Availability INT,
    CHECK(Availability>0),
    NoOfItems INT NOT NULL,
    CHECK(NoOfItems>0),
    Price DECIMAL NOT NULL,
    CHECK(Price>0),
    FOREIGN KEY (StudentId) REFERENCES dbo.Resident(StudentId),
    FOREIGN KEY (ItemName) REFERENCES dbo.Stock(ItemName)   
);

DROP TABLE dbo.Cafe
-- Create Table Stock
USE ResidentialLife
CREATE TABLE dbo.Stock(
   ItemName VARCHAR(255) PRIMARY KEY,
   ItemCount INT DEFAULT 0
);

DROP TABLE dbo.Stock