using bank.BLL.Abstract;
using bank.DTOs.OrderDto;
using bank.DTOs.UserDto;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace bank.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrderController : ControllerBase
    {
        private readonly IOrderService _service;
        public OrderController(IOrderService service)
        {
            _service = service;

        }

        [HttpPost]
        public IActionResult Add([FromBody] OrderToAddDto dto)
        {
            _service.Add(dto);
            return Ok();
        }
    }
}
