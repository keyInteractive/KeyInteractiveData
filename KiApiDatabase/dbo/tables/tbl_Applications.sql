CREATE TABLE [dbo].[tbl_Applications]
(
	[ID] INT IDENTITY(1,1) NOT NULL PRIMARY KEY, 
    [Name] NVARCHAR(MAX) NULL, 
    [ShortDescription] NVARCHAR(MAX) NULL, 
    [LongDescription] NVARCHAR(MAX) NULL, 
    [ReleaseDate] DATE NULL, 
    [Windows] BIT NULL DEFAULT 0, 
    [Mac] BIT NULL DEFAULT 0, 
    [Web] BIT NULL DEFAULT 0, 
    [Android] BIT NULL DEFAULT 0, 
    [IOS] BIT NULL DEFAULT 0, 
)
