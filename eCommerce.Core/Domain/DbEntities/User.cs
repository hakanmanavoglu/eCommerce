using System;
using System.Collections.Generic;

namespace eCommerce.Core.Domain.DbEntities
{
    public class User : BaseEntity
    {
        public User()
        {
            Roles = new HashSet<Role>();
        }

        public string UserName { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public Guid ConfirmationId { get; set; }
        public bool IsConfirmed { get; set; }
        public DateTime LastLoginDate { get; set; }
        public string LastLoginIp { get; set; }
        public string ProfileImgUrl { get; set; }

        public virtual ICollection<Role> Roles { get; set; }

        
    }
}
