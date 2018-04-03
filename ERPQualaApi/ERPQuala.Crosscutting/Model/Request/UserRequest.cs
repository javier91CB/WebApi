using System;
using System.Collections.Generic;
using System.Text;

namespace ERPQuala.Crosscutting.Model.Request
{
    public class UserRequest
    {
        public int id { get; set; }
        public string userName { get; set; }
        public string password { get; set; }
        public string firstName { get; set; }
        public string secondName { get; set; }
        public string dni { get; set; }
        public bool isProvider { get; set; }
    }
}
