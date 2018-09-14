using System;
using System.Collections.Generic;
using System.Text;

namespace Common.Data.Rest.Exceptions
{
    public class BackendException
    {
        public List<string> Messages { get; set; }
        public int StatusCode { get; set; }
    }
}
