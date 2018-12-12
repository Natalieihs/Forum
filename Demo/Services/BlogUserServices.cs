using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Demo.Services
{
    public class BlogUserServices : IUserServices
    {
        public bool ValidateUser(string username, string password)
        {
            return "demo".Equals(username) && password.Equals(password);
        }
    }
}
