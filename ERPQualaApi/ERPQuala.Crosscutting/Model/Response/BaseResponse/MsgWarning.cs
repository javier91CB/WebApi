using System;
using System.Collections.Generic;
using System.Text;

namespace ERPQuala.Crosscutting.Model.Response.BaseResponse
{
    public class MsgWarning
    {
        public Int32 warningCode { get; set; }
        public string warningDesc { get; set; }
    }
}
