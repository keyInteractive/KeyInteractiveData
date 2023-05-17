CREATE PROCEDURE [dbo].[spUsers_GetUserFromToken]
	@Token nvarchar(MAX)
AS
	SELECT *
	FROM tbl_Users
	WHERE EmailVerificationToken = @Token

RETURN 0
