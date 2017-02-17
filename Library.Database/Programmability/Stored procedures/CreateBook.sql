CREATE PROCEDURE [dbo].[CreateBook]
	@title nvarchar(128),
	@author nvarchar(128),
	@releasedAt datetime,
	@genre tinyint
as
	insert into [dbo].[Books](Title, Author, ReleasedAt, Genre)
	values(@title, @author, @releasedAt, @genre)
go
