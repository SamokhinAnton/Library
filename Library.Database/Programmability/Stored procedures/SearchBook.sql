CREATE PROCEDURE [dbo].[SearchBook]
	@pattern nvarchar(256),
	@genre tinyint = 255
AS
	SELECT 
		b.Id,
		b.Title, 
		b.Author, 
		b.ReleasedAt, 
		b.Genre as GenreId,
		CONVERT(bit , (select count(br.Id) from [dbo].[Borrows] br where br.BookId = b.Id and br.ReturnedAt is null)) as IsBorrowed
	from [dbo].[Books] b
	where (b.Author LIKE '%'+@pattern+'%') OR (YEAR(b.ReleasedAt) LIKE '%'+@pattern+'%') OR (b.Genre = @genre)
go
