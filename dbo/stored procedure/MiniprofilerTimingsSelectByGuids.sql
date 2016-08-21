CREATE PROCEDURE [dbo].[MiniprofilerTimingsSelectByGuids]
	@Guids [GuidList] READONLY

AS
	SELECT m.* FROM MiniProfilerTimings m 
		JOIN @Guids g ON m.MiniProfilerId = g.Id