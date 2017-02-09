CREATE TABLE [dbo].[Books]
(
	[Id] INT NOT NULL PRIMARY KEY identity(1, 1),
	[Title] nvarchar(128) not null,
	[Author] nvarchar(128) not null,
	[Year] int not null,
	[Genre] tinyint not null,
	[IsBorrowed] bit not null default 0,
)
