USE ResidentialLife
CREATE TABLE dbo.GuestLog(
    GuestLogId INT IDENTITY(1,1) PRIMARY KEY,
    GuestName VARCHAR(255) NOT NULL,
    StudentId INT NOT NULL,
    Guest_In DATETIME NOT NULL DEFAULT GETDATE(), 
    Guest_Out DATETIME,
    FOREIGN KEY (StudentId) REFERENCES dbo.Resident(StudentId)   
);

DROP TABLE dbo.GuestLog