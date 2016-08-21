create table MiniProfilerSqlTimingParameters
                  (
                	 RowId             integer not null identity constraint PK_MiniProfilerSqlTimingParameters primary key clustered,
                     MiniProfilerId    uniqueidentifier not null,
                     ParentSqlTimingId uniqueidentifier not null,
                     Name              nvarchar(130) not null,
                     DbType            nvarchar(50) null,
                     Size              int null,
                     Value             nvarchar(max) null
                  );