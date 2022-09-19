 CREATE PROC [dbo].[Usp_Del_Person]
 (@Id INT)
 AS
 BEGIN

	DELETE FROM [dbo].[Person]
	WHERE Id = @Id

 END