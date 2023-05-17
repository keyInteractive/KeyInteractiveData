CREATE PROCEDURE [dbo].[spApplications_GetAllUserApplications]
	@UserId int
AS
	SELECT *
	FROM tbl_UsersApplications
	WHERE UserID = @UserId
RETURN 0
