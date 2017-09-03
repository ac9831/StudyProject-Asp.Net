CREATE PROCEDURE [dbo].[ReplyNote]
	@Name			NVarchar(25),
	@Email			NVarchar(100),
	@Title			NVarchar(150),
	@PostIp			NVarchar(15),
	@Content		NText,
	@Password		NVarchar(20),
	@Encoding		NVarchar(10),
	@Homepage		NVarchar(100),
	@ParentNum		Int,
	@FileName		NVarchar(255),
	@FileSize		Int
AS
	Declare	@MaxRefOrder	Int
	Declare	@MaxRefAnswerNum	Int
	Declare	@ParentRef	Int
	Declare	@ParentStep	Int
	Declare	@ParentRefOrder	Int

	Update Notes Set AnswerNum = AnswerNum + 1 Where Id = @ParentNum

	Select @MaxRefOrder = RefOrder, @MaxRefAnswerNum = AnswerNum From Notes
	Where ParentNum	= @ParentNum And RefOrder = (Select Max(RefOrder) From Notes Where ParentNum = @PArentNum)

	If	@MaxRefOrder Is Null
	Begin
		Select @MaxRefOrder = RefOrder From Notes Where Id = @ParentNum
		Set @MaxRefAnswerNum = 0
	End

	Select @ParentRef = Ref, @ParentStep = Step
	From Notes Where Id = @ParentNum

	Update Notes
	Set
		RefOrder = RefOrder + 1
	Where
		Ref = @ParentRef And RefOrder > (@MaxRefOrder + @MaxRefAnswerNum)

	Insert Notes
	(
		Name, Email, Title, PostIp, Content, Password, Encoding, Homepage, Ref, Step, RefOrder, ParentNum, FileName, FileSize
	)
	Values
	(
		@Name, @Email, @Title, @PostIp, @Content, @Password, @Encoding, @Homepage, @ParentRef, @ParentStep + 1,
		@MaxRefOrder + @MaxRefAnswerNum + 1, @ParentNum, @FileName, @FileSize
	)

RETURN 0
