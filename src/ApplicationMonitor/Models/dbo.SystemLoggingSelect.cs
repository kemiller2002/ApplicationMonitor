

using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using StructuredSight.Data;


                namespace dbo
                {
                    
                    public class SystemLoggingSelectRecord
                    {
                        public SystemLoggingSelectRecord (IDataRecord reader)
                        {
                            CallSite = (String)reader["CallSite"] ;
Date = (DateTime)reader["Date"] ;
Exception = (String)reader["Exception"] ;
FilePath = (String)reader["FilePath"] ;
Id = (Int32)reader["Id"] ;
Level = (String)reader["Level"] ;
LineNumber = (Int32)reader["LineNumber"] ;
Logger = (String)reader["Logger"] ;
MachineName = (String)reader["MachineName"] ;
Message = (String)reader["Message"] ;
MethodName = (String)reader["MethodName"] ;
Module = (String)reader["Module"] ;
ParentLogId = (String)reader["ParentLogId"] ;
Stacktrace = (String)reader["Stacktrace"] ;
SystemLogId = (Guid)reader["SystemLogId"] ;
Thread = (String)reader["Thread"] ;
Username = (String)reader["Username"] ;
                        }

                        public String CallSite{get;set;}
public DateTime Date{get;set;}
public String Exception{get;set;}
public String FilePath{get;set;}
public Int32 Id{get;set;}
public String Level{get;set;}
public Int32 LineNumber{get;set;}
public String Logger{get;set;}
public String MachineName{get;set;}
public String Message{get;set;}
public String MethodName{get;set;}
public String Module{get;set;}
public String ParentLogId{get;set;}
public String Stacktrace{get;set;}
public Guid SystemLogId{get;set;}
public String Thread{get;set;}
public String Username{get;set;}

                    }
                }
            


                    namespace dbo
                    {
                        public class SystemLoggingSelectResult
                        {
                             public IEnumerable<dbo.SystemLoggingSelectRecord> Recordset {get;set;}
                    
                            
                        }

                    }
                

namespace dbo
{

    public class SystemLoggingSelect : StructuredSight.Data.BaseAccess<SystemLoggingSelectResult>
    {

        public SystemLoggingSelect(SqlConnection connection) : base(connection)
        {
        }

        public dbo.SystemLoggingSelectResult Execute(Guid? systemLogId, DateTime? startDate, DateTime? endDate)
        {
            var command = Connection.CreateCommand();
            command.CommandText = "[dbo].[SystemLoggingSelect]";
            command.CommandType = CommandType.StoredProcedure;


            
            if (systemLogId.HasValue)
            {
                var parameter = new SqlParameter
                {
                    Value = systemLogId,
                    ParameterName = "@SystemLogId"
                    
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
            

            return new dbo.SystemLoggingSelectResult
                {
                    
                    Recordset = (from IDataRecord r in reader select new dbo.SystemLoggingSelectRecord  (r) )
                };
            
        }

    }

}

