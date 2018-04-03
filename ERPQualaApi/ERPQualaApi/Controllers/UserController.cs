using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using ERPQuala.BAL.UserBAL;
using ERPQuala.Crosscutting.Model.Request;
using ERPQuala.Crosscutting.Model.Response;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace ERPQualaApi.Controllers
{
    [Produces("application/json")]
    [Route("api/User")]
    public class UserController : Controller
    {
        private IUserBl _userBl;
        public UserController(IUserBl userBl)
        {
            _userBl = userBl;
        }

        // GET: api/User/5
        [HttpPost]
        [Route("/GetUser")]
        public Task<HttpResponseMessage> GetUserPost([FromBody]UserRequest user)
        {
            if (user == null) return Task.FromResult(new HttpResponseMessage { StatusCode = System.Net.HttpStatusCode.BadRequest, Content = new StringContent("Error") });
            var result = _userBl.GetUserAsync(user);
            return Task.FromResult(new HttpResponseMessage { StatusCode = System.Net.HttpStatusCode.OK, Content = new StringContent(JsonConvert.SerializeObject(result.Result)) });
        }

        // POST: api/User
        [HttpPost]
        public Task<HttpResponseMessage> Post([FromBody]UserRequest user)
        {
            if (user == null) return Task.FromResult(new HttpResponseMessage { StatusCode = System.Net.HttpStatusCode.BadRequest, Content = new StringContent("Error") });
            var result = _userBl.CreateUserAsync(user);
            return Task.FromResult(new HttpResponseMessage { StatusCode = System.Net.HttpStatusCode.OK, Content = new StringContent(JsonConvert.SerializeObject(result)) });
        }
        
    }
}
