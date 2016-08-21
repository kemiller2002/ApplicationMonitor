  create table MiniProfilerTimings
                  (
                     RowId                               integer not null identity constraint PK_MiniProfilerTimings primary key clustered,
                     Id                                  uniqueidentifier not null,
                     MiniProfilerId                      uniqueidentifier not null,
                     ParentTimingId                      uniqueidentifier null,
                     Name                                nvarchar(200) not null,
                     Depth                               smallint not null,
                     StartMilliseconds                   decimal(7, 1) not null,
                     DurationMilliseconds                decimal(7, 1) not null,
                     DurationWithoutChildrenMilliseconds decimal(7, 1) not null,
                     SqlTimingsDurationMilliseconds      decimal(7, 1) null,
                     IsRoot                              bit not null,
                     HasChildren                         bit not null,
                     IsTrivial                           bit not null,
                     HasSqlTimings                       bit not null,
                     HasDuplicateSqlTimings              bit not null,
                     ExecutedReaders                     smallint not null,
                     ExecutedScalars                     smallint not null,
                     ExecutedNonQueries                  smallint not null
                  );