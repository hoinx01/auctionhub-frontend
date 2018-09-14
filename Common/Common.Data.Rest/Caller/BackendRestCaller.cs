using Common.Data.Rest.Exceptions;
using SrvCornet.Dal.Rest;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Common.Data.Rest.Caller
{
    public class BackendRestCaller : HttpClientBasisRestApiCaller
    {
        public BackendRestCaller(AuctionHubRestClient httpClient)
        {
            client = httpClient;
        }
        public override async Task PreprocessResponse(HttpResponseMessage response)
        {
            if (!response.IsSuccessStatusCode)
            {
                var message = await response.Content.ReadAsStringAsync();
                var exceptionModel = BackendJsonConverter.Deserialize<BackendException>(message);
                throw new AuctionHubException(exceptionModel.Messages, exceptionModel.StatusCode);
            }
        }
        protected override string SerializeObject(object obj)
        {
            return BackendJsonConverter.Serialize(obj);
        }
        protected T Deserialize<T>(string json)
        {
            return BackendJsonConverter.Deserialize<T>(json);
        }
        protected Dictionary<string, string> InitHeader()
        {
            var result = new Dictionary<string, string>();
            result.Add("Content-Type", "application/json; charset=utf-8");
            return result;
        }
        public async Task<T> PostAsync<T>(string path, Dictionary<string, string> headers = null, Dictionary<string, string> queries = null, object obj = null)
        {
            string json = await base.PostAsync(path, headers, queries, obj);
            return Deserialize<T>(json);
        }
        public async Task<T> PutAsync<T>(string path, Dictionary<string, string> headers = null, Dictionary<string, string> queries = null, object obj = null)
        {
            string json = await base.PutAsync(path, headers, queries, obj);
            return Deserialize<T>(json);
        }
        public async Task<T> DeleteAsync<T>(string path, Dictionary<string, string> headers = null, Dictionary<string, string> queries = null, object obj = null)
        {
            string json = await base.DeleteAsync(path, headers, queries, obj);
            return Deserialize<T>(json);
        }
        public async Task<T> GetAsync<T>(string path, Dictionary<string, string> headers = null, Dictionary<string, string> queries = null)
        {
            string json = await base.GetAsync(path, headers, queries);
            return Deserialize<T>(json);
        }
    }
}
