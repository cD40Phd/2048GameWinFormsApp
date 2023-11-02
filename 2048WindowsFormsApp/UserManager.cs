using Newtonsoft.Json;
using System.Collections.Generic;

namespace _2048WindowsFormsApp
{
    public class UserManager
    {
        public static string path = "result.json";
        public static List<User> GetAll()
        {
            if (FileProvider.Exists(path))
            {
                var jsonData = FileProvider.GetValue(path);
                return JsonConvert.DeserializeObject<List<User>>(jsonData);
            }
            return new List<User>();
            
        }

        public static void Add(User newUser)
        {
            var user = GetAll();
            user.Add(newUser);

            var jsonData = JsonConvert.SerializeObject(user);
            FileProvider.Replace(path, jsonData);
        }

    }
}
