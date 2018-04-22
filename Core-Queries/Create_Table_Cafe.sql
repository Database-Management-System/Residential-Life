USE ResidentialLife
CREATE TABLE dbo.Cafe(
    ItemId INT IDENTITY(1,1) PRIMARY KEY,
    StudentId INT NOT NULL,
    ItemName VARCHAR(255) NOT NULL,
    FOREIGN KEY (StudentId) REFERENCES dbo.Resident(StudentId),
    FOREIGN KEY (ItemName) REFERENCES dbo.Stock(ItemName)   
);

DROP TABLE dbo.Cafe