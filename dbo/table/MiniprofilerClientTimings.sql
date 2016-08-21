create table MiniProfilerClientTimings
                (
                  RowId             integer not null identity constraint PK_MiniProfilerClientTimings primary key clustered,
                  MiniProfilerId    uniqueidentifier not null,
                  Name				nvarchar(200) not null,
                  Start				decimal(7,1),
                  Duration			decimal(7,1)    
                );