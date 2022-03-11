using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NorthwindProject.API.Models.DAL;
using NorthwindProject.API.Models.DTOS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NorthwindProject.API.Controllers
{
    [Route("api/sale")]
    [ApiController]
    public class SaleController : ControllerBase
    {
        ISaleDAL _dal;
        public SaleController(ISaleDAL dal)
        {
            _dal = dal;
        }

        [HttpPost]
        [Route("addsale")]
        public IActionResult POST([FromBody] SalesDTO sales)
        {
            try
            {
                _dal.AddSale(sales);
                return new StatusCodeResult(201);
            }
            catch (Exception ex)
            {
                return BadRequest();
            }
        }
    }
}
