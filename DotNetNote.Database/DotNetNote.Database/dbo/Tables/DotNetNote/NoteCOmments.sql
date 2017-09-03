CREATE TABLE [dbo].[NoteCOmments]
(
	[Id]		INT Identity(1, 1) Not Null Primary Key,
	BoardName	NVarchar(50)	Null,
	BoardId		Int Not Null,
	NAme		NVarchar(25) Not Null,
	Opinion		NVarchar(4000) Not Null,
	PostDate	SmallDateTime Default(GetDate()),
	Password	NVarchar(20) Not Null
)
