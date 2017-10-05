CREATE TABLE [dbo].[NoteCOmments]
(
	[Id]		INT Identity(1, 1) Not Null ,
	BoardName	NVarchar(50)	Null,
	BoardId		Int Not Null,
	[Name]		NVarchar(25) Not Null,
	Opinion		NVarchar(4000) Not Null,
	PostDate	SmallDateTime Default(GetDate()),
	Password	NVarchar(20) Not Null, 
    CONSTRAINT [PK_NoteCOmments] PRIMARY KEY NONCLUSTERED ([Id])
)
