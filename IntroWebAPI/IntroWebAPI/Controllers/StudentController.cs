using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace IntroWebAPI.Controllers
{
    public class StudentController : ApiController
    {
        public HttpResponseMessage Get() {
            var data = new {Name ="Tanvir",Id=1 };
            return Request.CreateResponse(HttpStatusCode.OK,data);
        }
        public HttpResponseMessage Post() { 
            return Request.CreateResponse(HttpStatusCode.OK,"THis is post");   
        }
        public HttpResponseMessage Delete() {
            return Request.CreateResponse(HttpStatusCode.OK, "This is delte");
        }
    }
}
