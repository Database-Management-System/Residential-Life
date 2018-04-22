USE ResidentialLife
CREATE TABLE dbo.DeskAssistant (
    Username varchar(255) PRIMARY KEY,
    EmailId varchar(255) NOT NULL UNIQUE,
    Password varchar(255) NOT NULL,
	Name varchar(255) NOT NULL
);

DROP TABLE dbo.DeskAssistant