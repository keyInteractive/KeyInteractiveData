CREATE TABLE [dbo].[tbl_UsersApplications]
(
	[ID] INT IDENTITY(1,1) NOT NULL PRIMARY KEY, 
    [UserID] INT NULL, 
    [ApplicationID] INT NULL, 
    [PurchaseDate] DATETIME2 NULL, 
    [Active] BIT NULL, 

)
