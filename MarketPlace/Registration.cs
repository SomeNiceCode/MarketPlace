using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace MarketPlace
{
    public class Registration
    {
        private List<Person> users = new List<Person>();

        public void RegisterUser(string name, string email, string phone, string username, string password, UserRole role, string additionalInfo = null)
        {
            Person newUser;

            switch (role)
            {
                case UserRole.Seller:
                    newUser = new Seller(name, email, phone, role, username, password, additionalInfo);
                    break;
                case UserRole.Customer:
                    newUser = new Customer(name, email, phone, role, username, password, additionalInfo);
                    break;
                default: throw new ArgumentException("Шось пишло як обычно...Спробуй опять");
            }
            users.Add(newUser);

        }
        public List<Person> GetUsers() { return users; }

    }
}