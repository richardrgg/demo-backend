﻿ CREATE PROC [dbo].[Usp_Upd_Person]
 (@Id INT,
  @Name VARCHAR(50),
  @Lastname VARCHAR(50),
  @DocumentNumber VARCHAR(20),
  @DocumentTypeId INT)
 AS
 BEGIN

	UPDATE [dbo].[Person] SET
		Name = @Name,
		Lastname = @Lastname,
		DocumentNumber = @DocumentNumber,
		DocumentTypeId = @DocumentTypeId
	WHERE Id = @Id

 END
