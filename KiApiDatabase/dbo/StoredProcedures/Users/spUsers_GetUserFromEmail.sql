CREATE PROCEDURE [dbo].[spUsers_GetUserFromEmail]
	@Email nvarchar(MAX)
AS
BEGIN

	SELECT *
	FROM tbl_Users 
	WHERE Email = @Email
END
