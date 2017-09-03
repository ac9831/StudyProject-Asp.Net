CREATE PROCEDURE [dbo].[GetCountNotes]
AS
	Select Count(*) From Notes
GO
