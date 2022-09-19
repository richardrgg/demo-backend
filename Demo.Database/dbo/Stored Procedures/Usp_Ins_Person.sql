 CREATE PROC [dbo].[Usp_Ins_Person]
 (@Name VARCHAR(50),
  @Lastname VARCHAR(50),
  @DocumentTypeId INT,
  @DocumentNumber VARCHAR(20),
  @Birthdate DATE)
  AS
  BEGIN
	
	INSERT INTO [dbo].[Person]
	(Name, Lastname, DocumentNumber, DocumentTypeId,  Birthdate)
	VALUES
	(@Name, @Lastname, @DocumentNumber, @DocumentTypeId, @Birthdate)

  END
