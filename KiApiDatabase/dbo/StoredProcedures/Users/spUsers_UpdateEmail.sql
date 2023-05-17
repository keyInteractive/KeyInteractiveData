CREATE PROCEDURE [dbo].[spUsers_UpdateEmail]
	@UserId int,
	@Email nvarchar(50)
AS
	UPDATE tbl_Users
	SET Email = @Email
	WHERE Id = @UserId
RETURN 0
