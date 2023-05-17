CREATE PROCEDURE [dbo].[spUsers_UpdateOTP]
	@Id int,
	@Otp int,
	@Expiration datetime
AS
	UPDATE tbl_Users
	SET SmsVerificationToken = @Otp, SmsVerificationTokenExpires = @Expiration
	WHERE Id = @Id

RETURN 0
