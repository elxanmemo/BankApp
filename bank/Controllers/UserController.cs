using bank.BLL.Abstract;
using bank.DTOs.UserDto;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace bank.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserService _service;
        public UserController(IUserService service)
        {
            _service = service;

        }

        [HttpPost]
        public IActionResult Add([FromBody] UserToAddDto dto)
        {
            _service.Add(dto);
            return Ok();
        }

    }
}
