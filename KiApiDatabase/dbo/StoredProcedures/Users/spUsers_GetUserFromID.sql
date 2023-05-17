CREATE PROCEDURE [dbo].[spUsers_GetUserFromID]
	@ID int
AS
BEGIN
	SELECT * 
	FROM tbl_Users 
	WHERE Id = @ID
END

