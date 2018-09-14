using Common.Data.Rest.Caller.Interfaces;
using Common.Data.Rest.Models.Account;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Common.Data.Rest.Caller
{
    public class AccountRestCaller : BackendRestCaller, IAccountRestCaller
    {
        public AccountRestCaller(AuctionHubRestClient client) : base(client)
        {

        }
        public async Task<LoginResponse> Login(LoginRequest loginModel)
        {
            string path = "/admin/accounts/login";
            var loginResponse = await PostAsync<LoginResponse>(path, null, null, loginModel);
            return loginResponse;
        }
    }
}
