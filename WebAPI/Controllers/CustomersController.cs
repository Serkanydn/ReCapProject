using Business.Abstract;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomersController : ControllerBase
    {
        ICustomerService _customerService;

        public CustomersController(ICustomerService customerService)
        {
            _customerService = customerService;
        }

        [HttpGet("getcustomerdetaildtos")]
        public IActionResult GetCustomerDetailDtos()
        {
            var result = _customerService.GetCustomerDetailDtos();
            if (result.Success)
                return Ok(result);
            return BadRequest(result);
        }
    }
}
