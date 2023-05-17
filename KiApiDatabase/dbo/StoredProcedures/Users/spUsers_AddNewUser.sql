CREATE PROCEDURE [dbo].[spUsers_AddNewUser]
	@Name nvarchar(50),
	@Surname nvarchar(50),
	@Username nvarchar(50),
	@DateOfBirth date,
	@Email nvarchar(50),
	@PhonePrefix nvarchar(5),
	@Phone nvarchar(50),
	@Adress nvarchar(50),
	@City nvarchar(50),
	@Country nvarchar(50),
	@State nvarchar(50),
	@ZipCode nvarchar(50),
	@EmailVerificationToken  nvarchar(MAX),
	@EmailVerificationTokenExpires datetime2,
	@SmsVerificationToken  int,
	@SmsVerificationTokenExpires datetime2,
	@PasswordSalt varbinary(MAX),
	@PasswordHash varbinary(MAX),
	@StripeID nvarchar(MAX),
	@UserType int,
	@CustomerCode nvarchar(50) NULL

AS
BEGIN
	DECLARE 
	@CreationDate datetime2 = GETDATE(),
	@InsertedUserId int,
	@Role int = 1

	--INSERT A NEW USE IN USERS TABLE
	INSERT INTO tbl_Users(Name, Surname, Username, DateOfBirth, Email, PhonePrefix, Phone, Adress, City, Country, State, ZipCode, Role, StripeID, EmailVerificationToken, EmailVerificationTokenExpires, EmailVerified, SmsVerificationToken, SmsVerificationTokenExpires, SmsVerified, PasswordHash, PasswordSalt, CreationDate, UserType, CustomerCode)
	VALUES (@Name, @Surname, @Username, @DateOfBirth, @Email, @PhonePrefix,  @Phone, @Adress, @City, @Country, @State, @ZipCode, @Role, @StripeID, @EmailVerificationToken, @EmailVerificationTokenExpires, 0, @SmsVerificationToken, @SmsVerificationTokenExpires, 0, @PasswordHash, @PasswordSalt, @CreationDate, @UserType, @CustomerCode)
	
	--RETRIEVE THE ASSIGNED ID
	SET @InsertedUserId = SCOPE_IDENTITY();
END
