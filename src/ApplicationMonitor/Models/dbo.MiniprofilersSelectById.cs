

using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using StructuredSight.Data;


                namespace dbo
                {
                    
                    public class MiniprofilersSelectByIdRecord
                    {
                        public MiniprofilersSelectByIdRecord (IDataRecord reader)
                        {
                            DurationMilliseconds = (Decimal)reader["DurationMilliseconds"] ;
DurationMillisecondsInSql = (Decimal)reader["DurationMillisecondsInSql"] ;
HasAllTrivialTimings = (Boolean)reader["HasAllTrivialTimings"] ;
HasDuplicateSqlTimings = (Boolean)reader["HasDuplicateSqlTimings"] ;
HasSqlTimings = (Boolean)reader["HasSqlTimings"] ;
HasTrivialTimings = (Boolean)reader["HasTrivialTimings"] ;
HasUserViewed = (Boolean)reader["HasUserViewed"] ;
Id = (Guid)reader["Id"] ;
Level = (Byte)reader["Level"] ;
MachineName = (String)reader["MachineName"] ;
Name = (String)reader["Name"] ;
RootTimingId = (Guid)reader["RootTimingId"] ;
Started = (DateTime)reader["Started"] ;
TrivialDurationThresholdMilliseconds = (Decimal)reader["TrivialDurationThresholdMilliseconds"] ;
User = (String)reader["User"] ;
                        }

                        public Decimal DurationMilliseconds{get;set;}
public Decimal DurationMillisecondsInSql{get;set;}
public Boolean HasAllTrivialTimings{get;set;}
public Boolean HasDuplicateSqlTimings{get;set;}
public Boolean HasSqlTimings{get;set;}
public Boolean HasTrivialTimings{get;set;}
public Boolean HasUserViewed{get;set;}
public Guid Id{get;set;}
public Byte Level{get;set;}
public String MachineName{get;set;}
public String Name{get;set;}
public Guid RootTimingId{get;set;}
public DateTime Started{get;set;}
public Decimal TrivialDurationThresholdMilliseconds{get;set;}
public String User{get;set;}

                    }
                }
            


                    namespace dbo
                    {
                        public class MiniprofilersSelectByIdResult
                        {
                             public IEnumerable<dbo.MiniprofilersSelectByIdRecord> Recordset {get;set;}
                    
                            
                        }

                    }
                

namespace dbo
{

    public class MiniprofilersSelectById : StructuredSight.Data.BaseAccess<MiniprofilersSelectByIdResult>
    {

        public MiniprofilersSelectById(SqlConnection connection) : base(connection)
        {
        }

        public dbo.MiniprofilersSelectByIdResult Execute(Guid? id, DateTime? startDate, DateTime? endDate)
        {
            var command = Connection.CreateCommand();
            command.CommandText = "[dbo].[MiniprofilersSelectById]";
            command.CommandType = CommandType.StoredProcedure;


            
            if (id.HasValue)
            {
                var parameter = new SqlParameter
                {
                    Value = id,
                    ParameterName = "@Id"
                    
                    , SqlDbType =  SqlDbType.UniqueIdentifier 
                };

                command.Parameters.Add(parameter);
                
            }

            if (startDate.HasValue)
            {
                var parameter = new SqlParameter
                {
                    Value = startDate,
                    ParameterName = "@StartDate"
                    
                    , SqlDbType =  SqlDbType.DateTime 
                };

                command.Parameters.Add(parameter);
                
            }

            if (endDate.HasValue)
            {
                var parameter = new SqlParameter
                {
                    Value = endDate,
                    ParameterName = "@EndDate"
                    
                    , SqlDbType =  SqlDbType.DateTime 
                };

                command.Parameters.Add(parameter);
                
            }


            
            var reader = command.ExecuteReader();
            

            return new dbo.MiniprofilersSelectByIdResult
                {
                    
                    Recordset = (from IDataRecord r in reader select new dbo.MiniprofilersSelectByIdRecord  (r) )
                };
            
        }

    }

}

