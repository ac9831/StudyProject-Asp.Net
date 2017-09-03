CREATE PROCEDURE [dbo].[ModifyNote]
	@Name			NVarchar(25),
	@Email			NVarchar(100),
	@Title			NVarchar(150),
	@ModifyIp		NVarchar(15),
	@Content		NText,
	@Password		NVarchar(30),
	@Encoding		NVarchar(10),
	@HomePage		NVarchar(100),
	@FileName		NVarchar(255),
	@FileSize		Int,

	@Id Int
AS
	Declare @cnt Int

	Select @cnt = Count(*)	From Notes
	Where Id = @Id And Password = @Password

	If @cnt > 0
	Begin
		Update Notes
		Set
			Name = @Name, Email = @Email, Title = @Title,
			ModifyIp = @ModifyIp, ModifyDate = GetDate(),
			Content = @Content, Encoding = @Encoding,
			Homepage = @HomePage, FileName = @FileName, FileSize = @FileSize
		Where Id = @Id

		Select '1'
	End
	Else
		Select '0'
RETURN 0
