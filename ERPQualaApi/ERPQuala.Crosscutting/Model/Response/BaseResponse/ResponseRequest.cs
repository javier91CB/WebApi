using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace ERPQuala.Crosscutting.Model.Response.BaseResponse
{
    public class ResponseRequest<T>
    {
        public MsgResponse<T> MsgResponse { get; set; }
    }
}
