CREATE PROCEDURE [dbo].[spUsers_OtpVerificationSucceded]
	@UserID int,
	@UtcDate datetime
AS
	UPDATE tbl_Users
	SET SmsVerified = 1, SmsVerifiedAt = @UtcDate
	WHERE Id = @UserID

RETURN 0
