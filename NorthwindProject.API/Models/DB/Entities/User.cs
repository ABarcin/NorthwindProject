using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NorthwindProject.API.Models.DB.Entities
{
    public class User:IEntity
    {
        public int UserID { get; set; }
        public byte[] PasswordSalt { get; set; }
        public byte[] PasswordHash { get; set; }
        public string UserName { get; set; }
    }
}
