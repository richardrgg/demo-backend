 CREATE PROC [dbo].[Usp_Sel_Person_ById]
 (@Id INT)
 AS
 BEGIN

	SELECT 
		Id,
		Name,
		Lastname,
		DocumentNumber,
		DocumentTypeId,
		Birthday
	FROM [dbo].[Person]
	WHERE Id = @Id

 END
