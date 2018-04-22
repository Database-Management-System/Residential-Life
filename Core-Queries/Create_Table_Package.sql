USE ResidentialLife
CREATE TABLE dbo.Package(
    PackageId INT IDENTITY(1,1) PRIMARY KEY,
    StudentId INT NOT NULL,
    Perishable VARCHAR(255) NOT NULL,
    Date_In DATE NOT NULL, 
    Date_Out DATE ,
    FOREIGN KEY (StudentId) REFERENCES dbo.Resident(StudentId)   
);

DROP TABLE dbo.Package