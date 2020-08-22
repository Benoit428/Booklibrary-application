using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bibliotheek_Console
{
    class Admin
    {
        // private setter so it can't be adjusted
        public string Username
        { 
            get; private set;
        }
        private string Password
        {
            get; set;
        }

        public Admin(string username, string password)
        {
            Username = username;
            Password = password;
        }

        
    }
}
