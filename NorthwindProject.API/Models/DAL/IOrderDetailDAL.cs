using NorthwindProject.API.Models.DB.Entities;
using NorthwindProject.API.Models.DB.Repo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NorthwindProject.API.Models.DAL
{
    public interface IOrderDetailDAL:IEntityRepository<OrderDetail>
    {
    }
}
