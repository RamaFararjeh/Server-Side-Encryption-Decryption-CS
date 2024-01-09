using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace client_server
{
    public class User
    {
        public int Userid { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Address { get; set; }
        public string Email { get; set; }

        public User(int Userid, string Username, string Password, string Address, string Email)
        {
            this.Userid = Userid;
            this.Username = Username;
            this.Password = Password;
            this.Address = Address;
            this.Email = Email;
        }
    }
}
