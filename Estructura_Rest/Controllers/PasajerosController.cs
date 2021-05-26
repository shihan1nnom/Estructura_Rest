using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Estructura_Rest.Controllers
{
    public class PasajerosController : ApiController
    {
        // GET: api/Pasajeros
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/Pasajeros/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Pasajeros
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Pasajeros/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Pasajeros/5
        public void Delete(int id)
        {
        }
    }
}
