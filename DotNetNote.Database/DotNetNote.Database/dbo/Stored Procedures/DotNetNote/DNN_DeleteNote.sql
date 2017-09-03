CREATE PROCEDURE [dbo].[DeleteNote]
	@Id Int,
	@Password NVarchar(30)
AS
	Declare @cnt Int
	Select @cnt = Count(*) From Notes
	Where Id = @Id And Password = @Password

	If @cnt = 0
	Begin
		Return 
	End

	Declare @AnswerNum Int
	Declare @RefOrder Int
	Declare @Ref Int
	Declare @ParentNum Int

	Select @AnswerNum = AnswerNum,	@RefOrder = RefOrder,
		   @Ref = Ref,				@ParentNum = ParentNum
	From Notes
	Where Id = @Id

	If @AnswerNum = 0
	Begin 
		If @RefOrder > 0
		Begin
			Update Notes Set RefOrder = RefOrder - 1
			Where Ref = @Ref And RefOrder > @RefOrder
			Update Notes Set AnswerNum = AnswerNum - 1 Where Id = @ParentNum
		End
		Delete Notes Where ID = @Id
		Delete Notes
		Where Id = @ParentNum And ModifyIp = N'((Deleted))' And AnswerNum = 0
	End
	Else
	Begin
		Update Notes
		Set
			Name = N'(Unknown)', Email = '', Password = '',
			Title = N'(삭제된 글입니다.)',
			Content = N'(삭제된 글입니다. 현재 답변이 포함되어 있기 떄문에 내용만 삭제되었습니다.)',
			ModifyIp = N'((Deleted))', FileName = '',
			FileSize = 0, CommentCount = 0
		Where Id = @Id
	End
RETURN 0
