//using System.Text.Json;

namespace DoorAPI.Features
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