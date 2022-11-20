using BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace AppAPILayer.Controllers
{
    public class StudentController : ApiController
    {
        public HttpResponseMessage Get() {
            var data = StudentService.GetStudents();
            return Request.CreateResponse(HttpStatusCode.OK, data); 
        }
    }
}
