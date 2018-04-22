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
    Balance FLOAT NOT NULL,
    PRIMARY KEY(StudentId)
);

DROP TABLE dbo.Resident