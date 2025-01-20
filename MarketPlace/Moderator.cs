using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketPlace
{
    public class Moderator : Person
    {
        public string Uniquepass { get; set; }
        public string UniqueLogin { get; set; }

        public Moderator(string name, string email, string phone, UserRole role, string login, string password, string uniquepass, string uniquelogin) : base(name, email, phone, role, login, password)
        {
            Uniquepass = uniquepass;
            UniqueLogin = uniquelogin;
        }
    }
}
