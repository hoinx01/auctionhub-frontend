using SrvCornet.Core;
using SrvCornet.Dal.Rest;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;

namespace Common.Data.Rest
{
    public class AuctionHubRestClient : HttpClient
    {
        public AuctionHubRestClient()
        {
            BaseAddress = new Uri(AppSettings.GetString("BackendConfigs.BaseUrl"));
            Timeout = TimeSpan.FromSeconds(60);
            MaxResponseContentBufferSize = 10 * 1024 * 1024;

        }
        public static AuctionHubRestClient Create()
        {
            var client = new AuctionHubRestClient();
            client.DefaultRequestHeaders
              .Accept
              .Add(new MediaTypeWithQualityHeaderValue("application/json"));
            return client;
        }
    }
}
