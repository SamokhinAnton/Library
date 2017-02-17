CREATE PROCEDURE [dbo].[GetAllBooks]

as
	select 
		b.Id,
		b.Title, 
		b.Author, 
		b.ReleasedAt, 
		b.Genre as GenreId,
		CONVERT(bit , (select count(br.Id) from [dbo].[Borrows] br where br.BookId = b.Id and br.ReturnedAt is null)) as IsBorrowed
	from [dbo].[Books] b
go
