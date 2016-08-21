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
    [Route("api/[controller]")]
    public abstract class BaseAccess<T> : BaseApiController
    {
        public abstract IDynamicExecute<T> GetModel ();

        [HttpGet("Dates")]
        public T GetByDateRange
            (DateTime startDateTime, DateTime endDateTime) =>

            GetModel().DynamicExecute
                (new {StartDateTime = startDateTime, EndDateTime = endDateTime});

        [HttpGet("{id}")]
        public T GetById(Guid id) =>
            GetModel().DynamicExecute(new {Id = id});

        [HttpGet("")]
        public string Get() => "FOUND";

    }
}
