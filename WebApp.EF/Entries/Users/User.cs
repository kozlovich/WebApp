using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebApp.EF.Entries.Users
{
    public class User
    {
        public int UserId { get; set; }

        public string UserName { get; set; }

        public string Password { get; set; }

        public string Email { get; set; }

        public string IsActive { get; set; }

        public int? UserType_UserTypeId { get; set; }
        [ForeignKey("UserType_UserTypeId")]
        public virtual UserType UserType { get; set; }
    }
}
