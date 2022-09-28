 CREATE PROC [dbo].[Usp_Ins_Person]
 (@Name VARCHAR(50),
  @Lastname VARCHAR(50),
  @DocumentTypeId INT,
  @DocumentNumber VARCHAR(20),
  @Birthday DATETIME)
  AS
  BEGIN
	
	INSERT INTO [dbo].[Person]
	(Name, Lastname, DocumentNumber, DocumentTypeId, Birthday)
	VALUES
	(@Name, @Lastname, @DocumentNumber, @DocumentTypeId, @Birthday)

  END
