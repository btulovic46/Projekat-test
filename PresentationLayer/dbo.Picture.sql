CREATE TABLE [dbo].[Picture]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [Name] NVARCHAR(10) NOT NULL, 
    [Creator] NVARCHAR(10) NOT NULL, 
    [Description] NVARCHAR(10) NOT NULL, 
    [AverageGrade] REAL NOT NULL 
)
