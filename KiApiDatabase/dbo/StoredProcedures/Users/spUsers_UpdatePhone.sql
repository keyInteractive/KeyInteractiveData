CREATE PROCEDURE [dbo].[spUsers_UpdatePhone]
	@UserId int,
	@Prefix nvarchar(5),
	@Phone nvarchar(50)
AS
	UPDATE tbl_Users
	SET PhonePrefix = @Prefix, Phone = @Phone
	WHERE Id = @UserId
RETURN 0
