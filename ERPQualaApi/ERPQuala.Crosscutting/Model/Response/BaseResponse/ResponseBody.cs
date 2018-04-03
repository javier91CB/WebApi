using System;
using System.Collections.Generic;
using System.Text;

namespace ERPQuala.Crosscutting.Model.Response.BaseResponse
{
    public class ResponseBody<T>
    {
        public IList<T> DataResponse { get; set; }
    }
}
