 CREATE PROC [dbo].[Usp_Ins_Person]
 (@Name VARCHAR(50),
  @Lastname VARCHAR(50),
  @DocumentTypeId INT,
  @DocumentNumber VARCHAR(20))
  AS
  BEGIN
	
	INSERT INTO [dbo].[Person]
	(Name, Lastname, DocumentNumber, DocumentTypeId)
	VALUES
	(@Name, @Lastname, @DocumentNumber, @DocumentTypeId)

  END
