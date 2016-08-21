CREATE PROCEDURE [dbo].[MiniprofilersSelectById]
	@Id UNIQUEIDENTIFIER = NULL
	,@StartDate DATETIME = NULL
	,@EndDate DATETIME = NULL
AS

	SELECT * FROM MiniProfilers WHERE 
		(
			id = @id
			OR @Id IS NULL
		)
		OR 
		(
			(Started >= @StartDate OR @StartDate IS NULL)
			AND
			(Started <= @EndDate OR @EndDate IS NULL)
		)