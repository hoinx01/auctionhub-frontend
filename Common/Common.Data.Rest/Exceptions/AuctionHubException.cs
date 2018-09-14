using SrvCornet.Http.Exceptions;
using System;
using System.Collections.Generic;
using System.Net;
using System.Text;

namespace Common.Data.Rest.Exceptions
{
    public class AuctionHubException : BaseCustomException
    {
        public AuctionHubException(List<string> messages, int statusCode) : base(messages, (HttpStatusCode)statusCode)
        {
        }
    }
}
