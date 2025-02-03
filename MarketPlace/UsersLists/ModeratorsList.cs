using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MarketPlace.Users;

namespace MarketPlace.UsersLists
{
    public static class ModeratorsList             // этот класс для фиксированного списка модераторов
    {
        public static List<Moderator> Moderators
        {
            get;
            private set;
        }
        static ModeratorsList()
        {
            Moderators = new List<Moderator>
            {
                new Moderator("Artem", UserRole.Moderator, "Artem1991", "19911991", "1991"),
                new Moderator("Alexandr", UserRole.Moderator, "Alex34", "343434", "34")
            };
        }
        public static List<Moderator> GetModerators()
        {
            return Moderators;
        }
    }
}
