using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebApp.EF.Entries.Users
{
    public class UserType
    {
        public int UserTypeId { get; set; }

        public string Name { get; set; }

        public virtual ICollection<User> Users { get; set; }
    }
}
