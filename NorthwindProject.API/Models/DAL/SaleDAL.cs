using AutoMapper;
using NorthwindProject.API.Models.DB.Entities;
using NorthwindProject.API.Models.DTOS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Transactions;

namespace NorthwindProject.API.Models.DAL
{
    public class SaleDAL : ISaleDAL
    {
        IMapper _mapper;
        IOrderDAL _orderDAL;
        IOrderDetailDAL _orderDetailDAL;
        IProductDAL _productDAL;
        public SaleDAL(IMapper mapper,IOrderDAL orderDAL,IOrderDetailDAL orderDetailDAL,IProductDAL productDAL)
        {
            _mapper = mapper;
            _orderDAL = orderDAL;
            _orderDetailDAL = orderDetailDAL;
            _productDAL = productDAL;
        }
        public int AddSale(SalesDTO sales)
        {
            using (TransactionScope scope=new TransactionScope())
            {
                try
                {
                    Order order = new Order()
                    {
                        CustomerID=sales.Order.CustomerID,
                        EmployeeID=sales.Order.EmployeeID,
                        ShipVia=sales.Order.ShipVia,
                        ShipAddress=sales.Order.ShipAddress,
                        ShipCity=sales.Order.ShipCity,
                        ShipName=sales.Order.ShipName,
                        ShipCountry=sales.Order.ShipCountry
                    };
                    var myOrder = _orderDAL.Add(order);
                    var orderID = myOrder > 0 ? order.OrderID : throw new Exception();
                    foreach (var item in sales.OrderDetailDTO)
                    {
                        OrderDetail odetail = new OrderDetail()
                        {
                            OrderID = orderID,
                            ProductID = item.ProductID,
                            Quantity = item.Quantity,
                            UnitPrice = _productDAL.Get(item.ProductID).UnitPrice,
                            Discount=0
                        };
                        _orderDetailDAL.Add(odetail);
                    }
                    scope.Complete();
                }
                catch (Exception ex)
                {

                    throw;
                }
            }
            return 0;
        }
    }
}
