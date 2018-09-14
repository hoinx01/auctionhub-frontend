using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using System;
using System.Collections.Generic;
using System.Text;

namespace Common.Data.Rest
{
    public class BackendJsonConverter
    {
        public static T Deserialize<T>(string text)
        {
            return JsonConvert.DeserializeObject<T>(text, SNAKE);
        }

        public static string Serialize(object obj)
        {
            return JsonConvert.SerializeObject(obj, SNAKE);
        }

        private static readonly JsonSerializerSettings SNAKE = new JsonSerializerSettings
        {
            ContractResolver = new DefaultContractResolver
            {
                NamingStrategy = new SnakeCaseNamingStrategy()
            }
        };
    }
}
