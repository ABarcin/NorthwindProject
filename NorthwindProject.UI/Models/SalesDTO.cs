using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NorthwindProject.UI.Models
{
    public class SalesDTO
    {
        public SalesDTO()
        {
            OrderDetailDTO = new List<OrderDetailDTO>();
        }
        public OrderDTO Order { get; set; }
        public List<OrderDetailDTO> OrderDetailDTO { get; set; }
    }
}
