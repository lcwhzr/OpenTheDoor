//using System.Text.Json;

namespace API.Features
{
    public static class DefaultJsonSerializerOptions
    {
        public static int Options => new int
        {
            //PropertyNamingPolicy = JsonNamingPolicy.CamelCase,
            //IgnoreNullValues = true
        };
        //public static JsonSerializerOptions Options => new JsonSerializerOptions
        //{
        //    //PropertyNamingPolicy = JsonNamingPolicy.CamelCase,
        //    IgnoreNullValues = true
        //};
    }
}