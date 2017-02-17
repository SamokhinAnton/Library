CREATE PROCEDURE [dbo].[ReturnBook]
	@bookId int
AS
	update [dbo].[Borrows]
	set ReturnedAt = getdate()
	where BookId = @bookId and ReturnedAt is null
go
