using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ApplicationMonitor.Models;
using dbo;
using Microsoft.AspNetCore.Mvc;
using StructuredSight.Data;

namespace ApplicationMonitor.Controllers
{
    
    public class SystemLoggingController : BaseAccess<SystemLoggingSelectResult>
    {
        public override IDynamicExecute<SystemLoggingSelectResult> GetModel()
            => new SystemLoggingSelect(base.GetDatabaseConnection());
        
    }


}
