using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace ERPQuala.Crosscutting.Model.Response.BaseResponse
{
    public class ResponseRequest<T>
    {
        [JsonProperty("status")]
        public string Status { get; set; }
        [JsonProperty("data")]
        public T ResponseData { get; set; }
    }
}
