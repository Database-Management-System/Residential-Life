USE ResidentialLife
CREATE TABLE dbo.Equipment(
    EquipmentId INT IDENTITY(1,1) PRIMARY KEY,
    StudentId INT NOT NULL,
    ItemName VARCHAR(255) NOT NULL,
    Damaged VARCHAR(255) NOT NULL,
    Date_In DATETIME NOT NULL DEFAULT GETDATE(), 
    Date_Out DATETIME NOT NULL,
    FOREIGN KEY (StudentId) REFERENCES dbo.Resident(StudentId),
    FOREIGN KEY (ItemName) REFERENCES dbo.Stock(ItemName)   
);

DROP TABLE dbo.Equipment