--[1] 입력 저장 프로시저
Create Proc dbo.WriteUsers
	@UserID Nvarchar(25),
	@Password NVarchar(20)
AS
	Insert Into Users Values(@UserID, @Password)
GO

--[2] 출력 저장 프로시저
Create Proc dbo.ListUsers
AS
	Select [UID], [UserID], [Password] From Users Order By UID Desc
Go

--[3] 상세 저장 프로시저
Create Proc dbo.ViewUsers
	@UID Int
As
	Select [UID], [UserID], [Password] From Users Where UID = @UID
Go

--[4] 수정 저장 프로시저
Create Proc dbo.ModifyUsers
	@UserID NVarchar(25),
	@Password NVarchar(20),
	@UID Int
As
	Begin Tran
		Update Users
		Set
			UserID = @UserID,
			[Password] = @Password
		Where UID = @UID
	Commit Tran
Go

--[5] 삭제 저장 프로시저
Create Proc dbo.DeleteUsers
	@UID Int
As
	Delete Users Where UID = @UID
Go

--[6] 검색 저장 프로시저
Create Proc dbo.SearchUsers
	@SearchField NVarchar(25),
	@SearchQuery NVarchar(25)
As
	Declare @strSql Nvarchar(255)
	Set @strSql = 'Select * From Users Where ' + @SearchField + ' Like ''%' + @SearchQuery + '%'' '
	Exec(@strSql)
Go
