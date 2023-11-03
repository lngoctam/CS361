using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PasswordManager
{
    public class User
    {
        public string Email { get; set; }
        public string Password { get; set; }
        public List<DataEntry> Data { get; set; } 
    }
    public class DataEntry
    {
        public string Name { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
    }
    public class GetData
    {
        public List<DataEntry> Data { get; set; }
    }

}
