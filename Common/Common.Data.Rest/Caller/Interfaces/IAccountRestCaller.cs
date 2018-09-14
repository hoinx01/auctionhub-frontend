using Common.Data.Rest.Models.Account;
using SrvCornet.Dal.Rest;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Common.Data.Rest.Caller.Interfaces
{
    public interface IAccountRestCaller : IBackendRestCaller
    {
        Task<LoginResponse> Login(LoginRequest loginModel);
    }
}
