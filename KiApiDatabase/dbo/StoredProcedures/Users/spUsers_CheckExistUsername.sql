CREATE PROCEDURE [dbo].[spUsers_CheckExistUsername]
	@UserName nvarchar(MAX)
AS
BEGIN
	SELECT * 
	FROM tbl_Users 
	WHERE Username = @UserName COLLATE SQL_Latin1_General_CP1_CS_AS
END
