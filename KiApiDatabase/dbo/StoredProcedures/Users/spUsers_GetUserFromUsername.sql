CREATE PROCEDURE [dbo].[spUsers_GetUserFromUsername]
	@UserName nvarchar(MAX)
AS
BEGIN
	SELECT * 
	FROM tbl_Users 
	WHERE Username = @UserName
END
