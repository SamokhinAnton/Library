CREATE PROCEDURE [dbo].[BorrowBook]
	@bookId int
AS
	insert into [dbo].[Borrows] (BookId)
	values (@bookId)
go