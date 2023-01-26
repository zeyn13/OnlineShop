using Microsoft.AspNetCore.Http;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Newtonsoft.Json;

namespace OnlineShop.Utility
{
    public static class SessionExtensions
    {
        public static void Set<T>(this ISession session, string key, T valvue)
        {
            session.SetString(key, JsonConvert.SerializeObject(valvue));
        }

        public static T Get<T>(this ISession session, string key)
        {
            var value = session.GetString(key);
            return value == null ? default(T) :
                JsonConvert.DeserializeObject<T>(value);

        }

    }
}
