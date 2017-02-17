CREATE TABLE [dbo].[Borrows]
(
	[Id] int not null primary key identity(1, 1),
	[BookId] int not null,
	[BorrowAt] datetime not null default getdate(),
	[ReturnedAt] datetime null,
	Constraint [Borrows_books] FOREIGN KEY (BookId) REFERENCES Books(Id)
)
