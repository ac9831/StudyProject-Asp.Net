﻿CREATE TABLE [dbo].[Notes]
(
	[Id]			INT Identity(1, 1) NOT NULL PRIMARY KEY,
	Name			NVarchar(25) NOT NULL,
	Email			NVarchar(100) NULL,
	Title			NVarchar(50) NOT NULL,
	PostDate		DateTime Default GetDate() Not Null,
	PostIp			NVarchar(15) Null,
	Content			NText Not Null,
	Password		NVarchar(20) Null,
	ReadCount		Int Default 0,
	Encoding		NVarchar(10) Not Null,
	Homepage		NVarchar(100) Null,
	ModifyDate		DateTime Null,
	ModifyIp		NVarchar(15) Null,
	FileName		NVarchar(255) Null,
	FileSize		Int Default 0,
	DownCount		Int Default 0,
	Ref				Int Not Null,
	Step			Int Default 0,
	RefOrder		Int	Default 0,
	AnswerNum		Int	Default 0,
	ParentNum		int Default 0,
	CommentCount	Int	Default 0,
	Category		NVarchar(10) Null
)