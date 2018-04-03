using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using ERPQuala.BAL.UserBAL;
using ERPQuala.Crosscutting.Model.Request;
using ERPQuala.Crosscutting.Model.Response;
using ERPQuala.Crosscutting.Model.Response.BaseResponse;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace ERPQualaApi.Controllers
{
    [Produces("application/json")]
    [Route("api/User")]
    [AllowAnonymous]
    public class UserController : Controller
    {
        private readonly IUserBl _userBl;
        public UserController(IUserBl userBl)
        {
            _userBl = userBl;
        }

        // GET: api/User/5
        [HttpPost]
        [Route("/api/GetUser")]
        public Task<ResponseRequest<UserResponse>> GetUserPost([FromBody]UserRequest user)
        {
            if (user == null) return Task.FromResult(new ResponseRequest<UserResponse>{});
            var result = _userBl.GetUserAsync(user).Result;
            return Task.FromResult(new ResponseRequest<UserResponse>
            {
                MsgResponse = new MsgResponse<UserResponse>
                {
                    body = new ResponseBody<UserResponse>
                    {
                        DataResponse = new List<UserResponse>
                        {
                            result
                        }
                    } ,
                    error = string.Format("N/A"),
                    header = string.Format(""),
                    warning = new MsgWarning
                    {
                        warningCode = StatusCodes.Status200OK,
                        warningDesc = "N/A"
                    }
                }
            });
        }

       // POST: api/User
       [HttpPost]
       [Route("/api/AddUser")]
        public Task<ResponseRequest<UserResponse>> Post([FromBody]UserRequest user)
        {
            if (user == null) return Task.FromResult(new ResponseRequest<UserResponse> { });
            var result = _userBl.CreateUserAsync(user).Result;
            return Task.FromResult(new ResponseRequest<UserResponse>
            {
                MsgResponse = new MsgResponse<UserResponse>
                {
                    body = new ResponseBody<UserResponse>
                    {
                        DataResponse = new List<UserResponse>
                        {
                            result
                        }
                    },
                    error = string.Format("N/A"),
                    header = string.Format(""),
                    warning = new MsgWarning
                    {
                        warningCode = StatusCodes.Status200OK,
                        warningDesc = "N/A"
                    }
                }
            });
        }

    }
}
