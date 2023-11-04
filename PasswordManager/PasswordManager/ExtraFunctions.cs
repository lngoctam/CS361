using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.Json;
using System.IO;


namespace PasswordManager
{
    public class ExtraFunctions
    {
        public static bool Email_Validation(string email)
        {
            string pattern = @"^(?!\.)(""([^""\r\\]|\\[""\r\\])*""|" + @"([-a-z0-9!#$%&'*+/=?^_`{|}~]|(?<!\.)\.)*)(?<!\.)" + @"@[a-z0-9][\w\.-]*[a-z0-9]\.[a-z][a-z\.]*[a-z]$";
            var regex = new Regex(pattern, RegexOptions.IgnoreCase);
            if (regex.IsMatch(email))
            {
                return true;
            }
            return false;
        }
        public static bool Password_Validation(string password)
        {
            var regex = new Regex("^(?=.*?[A-Z])(?=.*?[a-z])(?=.*?[0-9])(?=.*?[#?!@$%^&*-]).{8,}$");
            var match = regex.IsMatch(password);
            if (match == true)
            {
                return true;
            }
            return false;
        }
        public static List<User> Read_Json_File(string path)
        {
            string jsonString = File.ReadAllText(path);
            var users = JsonSerializer.Deserialize<List<User>>(jsonString);
            return users;
        }
        public static bool Email_Verification(string emailInput)
        {
            string pathToJsonFile = Setting.JsonPath;
            var users = Read_Json_File(pathToJsonFile);
            foreach (var user in users)
            {
                if (emailInput == user.Email)
                {
                    return true;
                }
            }
            return false;
        }
        public static bool Password_Verification(string passwordInput)
        {
            string pathToJsonFile = Setting.JsonPath;
            var users = Read_Json_File(pathToJsonFile);
            foreach (var user in users)
            {
                if (passwordInput == user.Password)
                {
                    return true;
                }
            }
            return false;
        }
        public static void Write_Json_File(string path)
        {

        }
    }
}

