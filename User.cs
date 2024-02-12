using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Takumi_Saito_Project
{
    public class User
    {
        public string UserName { get; set; }
        public string Password { get; set; }
        public List<Subject> Subjects { get; set; }

        public User(string userName, string password)
        {
            UserName = userName;
            Password = password;
            Subjects = new List<Subject>();
        }

        public bool PasswordCheck(string password)
        {
            return (this.Password == password);
        }
    }
}
