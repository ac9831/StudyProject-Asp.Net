CREATE PROCEDURE [dbo].[WriteNote]
	@Name		NVarchar(25),
	@Email		NVarchar(100),
	@Title		NVarchar(150),
	@PostIp		NVarchar(15),
	@Content	NText,
	@Password	NVarchar(20),
	@Encoding	NVarchar(10),
	@HomePage	NVarchar(100),
	@FileName	NVarchar(255),
	@FileSize	Int
AS
	Declare		@MaxRef	Int
	Select @MaxRef = Max(Ref) From Notes

	If @MaxRef is Null
		Set @MaxRef = 1
	Else
		Set @MaxRef = @MaxRef + 1

	Insert Notes
	(
		Name, Email, Title, PostIp, Content, Password, Encoding, Homepage, Ref, FileName, FileSize
	)
	Values
	(
		@Name, @Email, @Title, @PostIp, @Content, @Password, @Encoding, @HomePage, @MaxRef, @FileName, @FileSize
	)
RETURN 0
