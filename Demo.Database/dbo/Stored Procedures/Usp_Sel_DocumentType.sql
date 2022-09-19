 CREATE PROC [dbo].[Usp_Sel_DocumentType]
 AS
 BEGIN

	SELECT
		Id,
		Name,
		ShortName
	FROM [dbo].[DocumentType]

 END