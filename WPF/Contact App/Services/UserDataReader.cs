using Contact_App.Model;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Text.Json;

namespace Contact_App.Services
{
    public class UserDataReader : IUserDataReader
    {
        public IEnumerable<Contact> Read(string path)
        {
            return JsonSerializer.Deserialize<IEnumerable<Contact>>(File.ReadAllText(path));
        }
    }
}
