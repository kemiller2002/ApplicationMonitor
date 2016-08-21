CREATE PROCEDURE [dbo].[SystemLoggingSelect]
	@SystemLogId UNIQUEIDENTIFIER = NULL
	,@StartDate DATETIME = NULL
	,@EndDate DATETIME = NULL
AS

	SELECT * FROM SystemLogging 
		WHERE 
			(
				SystemLogId = @SystemLogId
				OR
				@SystemLogId IS NULL
			)
			AND
			(
				(Date >= @StartDate OR @StartDate IS NULL)
				AND 
				(Date <= @EndDate OR @EndDate IS NULL)
			)
