using Newtonsoft.Json;

namespace INFT3050.Extensions
{
    public static class SessionExtensions
    {
        public static void SetObjectAsJsonWithExpiry(this ISession session, string key, object value, TimeSpan expiry)
        {
            var expiringObject = new ExpiringObject
            {
                Value = value,
                ExpiryDate = DateTime.UtcNow.Add(expiry)
            };

            session.SetString(key, JsonConvert.SerializeObject(expiringObject));
        }

        public static T GetObjectFromJsonWithExpiry<T>(this ISession session, string key)
        {
            var value = session.GetString(key);
            if (value == null)
            {
                return default(T);
            }

            var expiringObject = JsonConvert.DeserializeObject<ExpiringObject>(value);
            if (DateTime.UtcNow > expiringObject.ExpiryDate)
            {
                session.Remove(key);
                return default(T);
            }

            return JsonConvert.DeserializeObject<T>(expiringObject.Value.ToString());
        }

        private class ExpiringObject
        {
            public object Value { get; set; }
            public DateTime ExpiryDate { get; set; }
        }
    }
}
