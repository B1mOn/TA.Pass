using Newtonsoft.Json;
using System;


namespace ТА.Пароли.Models.JSON
{
    public class JSON_Manager
    {
        public void Load()
        {

        }

        public void Save(Users users, string name) 
        {
            string output = JsonConvert.SerializeObject(users.UsersJSON);
            Console.WriteLine(output);
        }

    }
}
