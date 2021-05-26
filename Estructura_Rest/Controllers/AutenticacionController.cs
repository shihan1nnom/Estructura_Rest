using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Estructura_Rest.Controllers
{
    public class AutenticacionController : ApiController
    {
        // GET: api/Autenticacion
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/Autenticacion/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Autenticacion
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Autenticacion/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Autenticacion/5
        public void Delete(int id)
        {
        }
    }
}
