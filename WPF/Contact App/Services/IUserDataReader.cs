using Contact_App.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace Contact_App.Services
{
    public interface IUserDataReader
    {
        IEnumerable<Contact> Read(string path);
    }
}
