create table MiniProfilerSqlTimings
                  (
                     RowId                          integer not null identity constraint PK_MiniProfilerSqlTimings primary key clustered,
                     Id                             uniqueidentifier not null,
                     MiniProfilerId                 uniqueidentifier not null,
                     ParentTimingId                 uniqueidentifier not null,
                     ExecuteType                    tinyint not null,
                     StartMilliseconds              decimal(7, 1) not null,
                     DurationMilliseconds           decimal(7, 1) not null,
                     FirstFetchDurationMilliseconds decimal(7, 1) null,
                     IsDuplicate                    bit not null,
                     StackTraceSnippet              nvarchar(200) not null,
                     CommandString                  nvarchar(max) not null
                  );