using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketPlace
{
    public class Moderator : Person
    {
        private readonly string securityCode;
        public string SecurityCode
        {
            get
            {
                return securityCode;
            }
        }
        public Moderator(string name, UserRole role, string login, string password, string securityCode) : base(name, role, login, password) { this.securityCode = securityCode; }
    }
}
