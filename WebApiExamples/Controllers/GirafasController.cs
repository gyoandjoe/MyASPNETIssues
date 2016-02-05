using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebApiExamples.Controllers
{
    public class GirafasController : ApiController
    {
        // GET: api/Girafas
        public IEnumerable<string> Get()
        {
            return new string[] { "Girafa1", "Girafa2" };
        }

        // GET: api/Girafas/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Girafas
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Girafas/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Girafas/5
        public void Delete(int id)
        {
        }
    }
}
