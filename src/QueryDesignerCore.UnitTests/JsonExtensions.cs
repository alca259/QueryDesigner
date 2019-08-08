using Newtonsoft.Json;

namespace QueryDesignerCore.UnitTests
{
    public static class JsonExtensions
    {
        public static string ToJson(this object obj)
        {
            return JsonConvert.SerializeObject(obj);
        }
    }
}
