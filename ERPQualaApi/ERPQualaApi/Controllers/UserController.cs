﻿using System;
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
        public IActionResult GetUserPost([FromBody]UserRequest user)
        {
            if (user == null) return BadRequest();
            var result = _userBl.GetUserAsync(user).Result;

            return Ok(result);
            //return Task.FromResult(new ResponseRequest<UserResponse>
            //{
            //    MsgResponse = new MsgResponse<UserResponse>
            //    {
            //        body = new ResponseBody<UserResponse>
            //        {
            //            DataResponse = new List<UserResponse>
            //            {
            //                result
            //            }
            //        } ,
            //        warning = new MsgWarning
            //        {
            //            warningCode = StatusCodes.Status200OK,
            //        }
            //    }
            //});
        }

       // POST: api/User
       [HttpPost]
       [Route("/api/AddUser")]
        public IActionResult Post([FromBody]UserRequest user)
        {
            if (user == null) return BadRequest();
            var result = _userBl.CreateUserAsync(user).Result;
            return Ok(result);
            //return Task.FromResult(new ResponseRequest<UserResponse>
            //{
            //    MsgResponse = new MsgResponse<UserResponse>
            //    {
            //        body = new ResponseBody<UserResponse>
            //        {
            //            DataResponse = new List<UserResponse>
            //            {
            //                result
            //            }
            //        },
            //        warning = new MsgWarning
            //        {
            //            warningCode = StatusCodes.Status200OK,
            //        }
            //    }
            //});
        }

    }
}
