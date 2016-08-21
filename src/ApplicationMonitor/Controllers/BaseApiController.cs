using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using ApplicationMonitor.Models;
using Microsoft.AspNetCore.Mvc;

namespace ApplicationMonitor.Controllers
{
    public abstract class BaseApiController : Controller
    {

        private Queue<SqlConnection> _dispostalQueue = new Queue<SqlConnection>();

        public SqlConnection GetDatabaseConnection()
        {
            try
            {

                var connection = new SqlConnection(Constants.DefaultConnectionString);
                connection.Open();

                _dispostalQueue.Enqueue(connection);

                return connection;
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine(ex.Message);
                throw;
            }
        }


        protected override void Dispose(bool disposing)
        {
            foreach (var sqlConnection in _dispostalQueue)
            {
                try
                {
                    sqlConnection.Dispose();
                }
                catch 
                {
                    
                }
            }
            base.Dispose(disposing);
        }
    }
}
