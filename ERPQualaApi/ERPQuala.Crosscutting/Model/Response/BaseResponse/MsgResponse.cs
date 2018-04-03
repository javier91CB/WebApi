using System;
using System.Collections.Generic;
using System.Text;

namespace ERPQuala.Crosscutting.Model.Response.BaseResponse
{
    public class MsgResponse<T>
    {
        public ResponseBody<T> body { get; set; }
        public string error { get; set; }
        public string header { get; set; }
        public MsgWarning warning { get; set; }
    }
}
