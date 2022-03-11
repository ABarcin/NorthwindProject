using NorthwindProject.API.Models.DTOS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NorthwindProject.API.Models.DAL
{
    public interface ISaleDAL
    {
        int AddSale(SalesDTO sales);
    }
}
