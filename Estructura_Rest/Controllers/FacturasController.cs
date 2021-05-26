using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Estructura_Rest.Controllers
{
    public class FacturasController : ApiController
    {
        // GET: api/Facturas
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/Facturas/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Facturas
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Facturas/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Facturas/5
        public void Delete(int id)
        {
        }
    }
}
