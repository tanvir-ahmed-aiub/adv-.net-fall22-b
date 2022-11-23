using BLL.DTOs;
using BLL.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace BloodDonate.Controllers
{
    public class GroupController : ApiController
    {
        [Route("api/groups")]
        [HttpGet]
        public HttpResponseMessage Get() {
            var data = GroupService.Get();
            return Request.CreateResponse(HttpStatusCode.OK, data);
        }

        [Route("api/groups/{id}")]
        [HttpGet]
        public HttpResponseMessage Get(int id) {
            var data = GroupService.Get(id);
            return Request.CreateResponse(HttpStatusCode.OK, data);
        }
        [Route("api/groups/add")]
        [HttpPost]
        public HttpResponseMessage Post(GroupDTO group) { 
            var resp = GroupService.Add(group);
            if (resp) { 
                return Request.CreateResponse(HttpStatusCode.OK, new { Msg = "Inserted",data = group});
            }
            return Request.CreateResponse(HttpStatusCode.InternalServerError);
        }
    }
}
