 CREATE PROCEDURE [dbo].[Usp_Sel_Person]
 AS
 BEGIN

	SELECT
		Id,
		Name,
		Lastname,
		Birthday
	FROM [dbo].[Person]

 END