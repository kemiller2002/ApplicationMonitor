create table MiniProfilers
                  (
                     Id                                   uniqueidentifier not null constraint PK_MiniProfilers primary key nonclustered, -- don't cluster on a guid
                     Name                                 nvarchar(200) not null,
                     Started                              datetime not null,
                     MachineName                          nvarchar(100) null,
                     [User]                               nvarchar(100) null,
                     Level                                tinyint null,
                     RootTimingId                         uniqueidentifier null,
                     DurationMilliseconds                 decimal(7, 1) not null,
                     DurationMillisecondsInSql            decimal(7, 1) null,
                     HasSqlTimings                        bit not null,
                     HasDuplicateSqlTimings               bit not null,
                     HasTrivialTimings                    bit not null,
                     HasAllTrivialTimings                 bit not null,
                     TrivialDurationThresholdMilliseconds decimal(5, 1) null,
                     HasUserViewed                        bit not null
                  );