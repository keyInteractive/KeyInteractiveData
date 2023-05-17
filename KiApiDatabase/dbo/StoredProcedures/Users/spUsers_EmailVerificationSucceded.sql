CREATE PROCEDURE [dbo].[spUsers_EmailVerificationSucceded]
	@UserID int,
	@UtcDate datetime
AS
	UPDATE tbl_Users
	SET EmailVerified = 1, EmailVerifiedAt = @UtcDate, EmailVerificationToken = NULL
	WHERE Id = @UserID

RETURN 0
