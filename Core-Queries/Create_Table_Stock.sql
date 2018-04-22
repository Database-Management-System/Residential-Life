USE ResidentialLife
CREATE TABLE dbo.Stock(
   ItemName VARCHAR(255) PRIMARY KEY,
   ItemCount INT DEFAULT 0,
   CHECK(ItemCount>0),
   Price FLOAT
);

DROP TABLE dbo.Stock