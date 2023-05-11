using bank.BLL.Abstract;
using bank.DAL.DataContext;
using bank.DTOs.RegisterDto;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace bank.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LoginController : ControllerBase
    {
        private readonly ILoginService _service;
        public LoginController(ILoginService service)
        {
            _service=service;
        }
        [HttpPost]
        public IActionResult GetRegister([FromBody] LoginToGetDto dto)
        {
            if (_service.Get(dto))
            {
                return Ok(new { message = "Login successful!" });
            }
            else
            {
                return Unauthorized(new { message = "Invalid username or password" });
            }
        }
    }
}
