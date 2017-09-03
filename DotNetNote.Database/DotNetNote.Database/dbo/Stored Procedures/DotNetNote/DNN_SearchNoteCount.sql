CREATE PROCEDURE [dbo].[SearchNoteCount]
	@SearchField NVarchar(25),
	@SearchQuery	NVarchar(25)
AS
	Set @SearchQuery = '%' + @SearchQuery+ '%'

	Select Count(*)
	From Notes
	Where
	(
		Case @SearchField
			When 'Name' Then [Name]
			When 'Title' Then Title
			When 'Content' Then Content
			Else @SearchQuery
		End
	)
	Like
	@SearchQuery
RETURN 0
