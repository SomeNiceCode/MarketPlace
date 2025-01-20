using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketPlace
{
    public abstract class Person
    {
        string Name { get; set; }
        string Email { get; set; }
        string Phone { get; set; }
        public UserRole Role { get; set; }
        string Login { get; set; }
        string Password { get; set; }
        

        public Person (string name, string email, string phone, UserRole role, string login, string password)
        {
            Name = name;
            Email = email;
            Phone = phone;
            Role = role;
            Login = login;
            Password = password;
        }
    }
}
