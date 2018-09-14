using System;
using System.Collections.Generic;
using System.Text;

namespace Common.Data.Rest.Models.Account
{
    public class LoginRequest
    {
        public string LoginName { get; set; }
        public string Password { get; set; }
    }
}
