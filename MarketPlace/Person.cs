using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace MarketPlace
{
    public abstract class Person
    {
        private string name;
        private string login;
        private string password;
        public string Name
        { 
            get 
            { 
                return name; 
            } 
            set 
            { 
                name = value; 
            } 
        }
        public UserRole Role { get; set; }
        public string Login 
        { 
            get 
            { 
                return login; 
            } 
            set 
            { 
                login = value; 
            } 
        }
        public string Password 
        { 
            get 
            { 
                return password; 
            } 
            set 
            { 
                password = EncryptPassword(value); 
            } 
        }
        public Person(string name, UserRole role, string login, string password) 
        { 
            this.name = name;
            this.Role = role;
            this.login = login;
            this.password = EncryptPassword(password); 
        }
        private string EncryptPassword(string password)
        { 
           return Convert.ToBase64String(System.Text.Encoding.UTF8.GetBytes(password)); 
        } 
    }
}
