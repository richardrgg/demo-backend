CREATE TABLE [dbo].[DocumentType] (
    [Id]        INT          IDENTITY (1, 1) NOT NULL,
    [Name]      VARCHAR (50) NULL,
    [ShortName] VARCHAR (10) NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);

