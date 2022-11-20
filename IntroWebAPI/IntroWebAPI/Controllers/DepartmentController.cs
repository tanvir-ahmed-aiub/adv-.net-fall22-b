using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace IntroWebAPI.Controllers
{
    public class DepartmentController : ApiController
    {
        [Route("api/department/all")]
        [HttpGet]
        public HttpResponseMessage AllDept()
        {
            string[] names = new string[] { "CS","EEE","BBA"};
            return Request.CreateResponse(HttpStatusCode.OK, names);    
        }
        //[Route("api/department/{id?}/{name?}")]
        [Route("api/department/{id}/{name}")]
        [HttpGet]
        public HttpResponseMessage Get(int id, string name) {
            var data = new { Name = name, Id = id };
            return Request.CreateResponse(HttpStatusCode.OK, data);
        }
    }
}
