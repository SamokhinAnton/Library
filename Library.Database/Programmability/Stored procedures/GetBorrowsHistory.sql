CREATE PROCEDURE [dbo].[GetBorrowsHistory]
	@bookId int
AS
	select b.Title, b.Author, br.BorrowAt, br.ReturnedAt, b.Id 
	from [dbo].[Books] b
	left join [dbo].[Borrows] br on br.BookId = b.Id
	where b.Id = @bookId
go
