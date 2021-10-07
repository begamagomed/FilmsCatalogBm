using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FilmsCatalog.Models
{
    public static class UserUtils
    {
        public static string GetUserName(this User user)
        {
            return $"{user.FirstName} {user.LastName}";
        }
    }
}
