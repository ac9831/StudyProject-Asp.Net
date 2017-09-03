
Create Proc dbo.SearchMemo
(
	@SearchField NVarChar(10),
	@SearchQuery NVarChar(50)
)

As 
	Declare @strSql NVarChar(150)
	Set @strSql = 'Select Num, Name,Email, Title, PostDate, PostIP
					From Memos Where ' + @SearchField + ' Like
					N''%' + @SearchQuery + '%''
					Order By Num Desc'
	Exec (@strSql)
