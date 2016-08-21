

using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using StructuredSight.Data;


                namespace dbo
                {
                    
                    public class MiniprofilerTimingsSelectByGuidsRecord
                    {
                        public MiniprofilerTimingsSelectByGuidsRecord (IDataRecord reader)
                        {
                            Depth = (Int16)reader["Depth"] ;
DurationMilliseconds = (Decimal)reader["DurationMilliseconds"] ;
DurationWithoutChildrenMilliseconds = (Decimal)reader["DurationWithoutChildrenMilliseconds"] ;
ExecutedNonQueries = (Int16)reader["ExecutedNonQueries"] ;
ExecutedReaders = (Int16)reader["ExecutedReaders"] ;
ExecutedScalars = (Int16)reader["ExecutedScalars"] ;
HasChildren = (Boolean)reader["HasChildren"] ;
HasDuplicateSqlTimings = (Boolean)reader["HasDuplicateSqlTimings"] ;
HasSqlTimings = (Boolean)reader["HasSqlTimings"] ;
Id = (Guid)reader["Id"] ;
IsRoot = (Boolean)reader["IsRoot"] ;
IsTrivial = (Boolean)reader["IsTrivial"] ;
MiniProfilerId = (Guid)reader["MiniProfilerId"] ;
Name = (String)reader["Name"] ;
ParentTimingId = (Guid)reader["ParentTimingId"] ;
RowId = (Int32)reader["RowId"] ;
SqlTimingsDurationMilliseconds = (Decimal)reader["SqlTimingsDurationMilliseconds"] ;
StartMilliseconds = (Decimal)reader["StartMilliseconds"] ;
                        }

                        public Int16 Depth{get;set;}
public Decimal DurationMilliseconds{get;set;}
public Decimal DurationWithoutChildrenMilliseconds{get;set;}
public Int16 ExecutedNonQueries{get;set;}
public Int16 ExecutedReaders{get;set;}
public Int16 ExecutedScalars{get;set;}
public Boolean HasChildren{get;set;}
public Boolean HasDuplicateSqlTimings{get;set;}
public Boolean HasSqlTimings{get;set;}
public Guid Id{get;set;}
public Boolean IsRoot{get;set;}
public Boolean IsTrivial{get;set;}
public Guid MiniProfilerId{get;set;}
public String Name{get;set;}
public Guid ParentTimingId{get;set;}
public Int32 RowId{get;set;}
public Decimal SqlTimingsDurationMilliseconds{get;set;}
public Decimal StartMilliseconds{get;set;}

                    }
                }
            


                    namespace dbo
                    {
                        public class MiniprofilerTimingsSelectByGuidsResult
                        {
                             public IEnumerable<dbo.MiniprofilerTimingsSelectByGuidsRecord> Recordset {get;set;}
                    
                            
                        }

                    }
                

namespace dbo
{

    public class MiniprofilerTimingsSelectByGuids : StructuredSight.Data.BaseAccess<MiniprofilerTimingsSelectByGuidsResult>
    {

        public MiniprofilerTimingsSelectByGuids(SqlConnection connection) : base(connection)
        {
        }

        public dbo.MiniprofilerTimingsSelectByGuidsResult Execute(dbo.GuidList guids)
        {
            var command = Connection.CreateCommand();
            command.CommandText = "[dbo].[MiniprofilerTimingsSelectByGuids]";
            command.CommandType = CommandType.StoredProcedure;


            

             if(guids == null)
                    {
                        throw new ArgumentException("@Guids cannot be null");
                    }
                
            if(guids != null)
            {
                var @GuidsParameter = new SqlParameter
                {
                     Value = guids,
                    ParameterName = "@Guids"
                    
                    , SqlDbType =  SqlDbType.BigInt 
                };
                
                command.Parameters.Add(@GuidsParameter);
            }
            
            


            
            var reader = command.ExecuteReader();
            

            return new dbo.MiniprofilerTimingsSelectByGuidsResult
                {
                    
                    Recordset = (from IDataRecord r in reader select new dbo.MiniprofilerTimingsSelectByGuidsRecord  (r) )
                };
            
        }

    }

}

