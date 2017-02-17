CREATE PROCEDURE [dbo].[RemoveBook]
	@bookId int
as
	delete [dbo].[Borrows] where BookId = @bookId
	delete [dbo].[Books] where Id = @bookId
go
