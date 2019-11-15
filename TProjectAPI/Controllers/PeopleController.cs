using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;
using TProjectAPI.Data;

namespace TProjectAPI.Controllers
{
    [EnableCors("http://localhost:4200", "*","*")]
    public class PeopleController : ApiController
    {
        public IHttpActionResult GetPeople()
        {
            try
            {
                using (var context = new AppDbContext())
                {
                    var people = context.People.ToList();
                    return Ok(people);
                }
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }

        }
    }
}
