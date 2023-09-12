using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class User
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public string Rule { get; set; }
        public User()
        {

        }

        public User(string username, string password, string email, string rule)
        {
            Username = username;
            Password = password;
            Email = email;
            Rule = rule;
        }
    }
    
}
