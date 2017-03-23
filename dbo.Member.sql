CREATE TABLE [dbo].[Member] (
    [Id]       INT           IDENTITY (1, 1) NOT NULL,
    [Email]    VARCHAR (MAX) NOT NULL,
    [Password] VARCHAR (MAX) NOT NULL,
    [Name] VARCHAR(MAX) NOT NULL, 
    [DOB] DATE NOT NULL, 
    [Phone Number] INT NOT NULL, 
    [Address] VARCHAR(MAX) NOT NULL, 
    PRIMARY KEY CLUSTERED ([Id] ASC)
);

