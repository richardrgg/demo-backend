 CREATE PROC [dbo].[Usp_Sel_Person_All]
 AS
 BEGIN

	SELECT 
		P.Id,
		P.Name,
		P.Lastname,
		P.DocumentNumber,
		DT.ShortName AS DocumentType,
		Birthday
	FROM [dbo].[Person] P
	INNER JOIN [dbo].[DocumentType] DT ON DT.Id = P.DocumentTypeId

 END