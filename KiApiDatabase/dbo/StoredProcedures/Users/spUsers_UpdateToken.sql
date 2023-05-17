CREATE PROCEDURE [dbo].[spUsers_UpdateToken]
	@Id int,
	@Token nvarchar(MAX),
	@Expiration datetime
AS
	UPDATE tbl_Users
	SET EmailVerificationToken = @Token, EmailVerificationTokenExpires = @Expiration
	WHERE Id = @Id

RETURN 0