using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using DataAccess;
using System.Data.Entity;

namespace DatalinkPrototype.Controllers
{
    public class DefaultController : ApiController
    {
        //public IEnumerable<MainTable> Get()
        //{
        //    using (TESTEntities entities = new TESTEntities())
        //    {
        //        return entities.MainTables.ToList();
        //    }
        //}

        [HttpGet]
        public IEnumerable<MainTable> GetAll()
        {
            TESTEntities accessModule = new TESTEntities();
            
            return accessModule.MainTables.ToList();
        }
    }
}
