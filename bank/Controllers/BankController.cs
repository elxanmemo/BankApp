using bank.BLL.Abstract;
using bank.DTOs.BankDto;
using bank.DTOs.UserDto;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace bank.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BankController : ControllerBase
    {
        private readonly IBankService _service;
        public BankController(IBankService service)
        {
            _service = service;

        }

        [HttpPost]
        public IActionResult Add([FromBody] BankToAddDto dto)
        {
            _service.Add(dto);
            return Ok();
        }


    }
}
