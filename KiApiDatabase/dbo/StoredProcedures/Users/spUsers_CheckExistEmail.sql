CREATE PROCEDURE [dbo].[spUsers_CheckExistEmail]
	@Email nvarchar(MAX)
AS
BEGIN

	SELECT *
	FROM tbl_Users 
	WHERE Email = @Email
END
