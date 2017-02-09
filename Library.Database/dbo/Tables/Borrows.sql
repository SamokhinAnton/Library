CREATE TABLE [dbo].[Borrows]
(
	[Id] int not null primary key identity(1, 1),
	[BookId] int not null,
	[Name] nvarchar(128) not null, 
	[BorrowAt] datetime not null default getdate(),
	[ReturnedAt] datetime null,
)
