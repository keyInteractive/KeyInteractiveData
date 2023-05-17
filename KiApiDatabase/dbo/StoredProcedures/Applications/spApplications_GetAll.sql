CREATE PROCEDURE [dbo].[spApplications_GetAll]
AS
	SELECT *
	FROM tbl_Applications
	ORDER by Name
RETURN 0
