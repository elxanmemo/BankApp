using bank.BLL.Abstract;
using bank.DTOs.CardDto;
using bank.DTOs.UserDto;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace bank.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CardController : ControllerBase
    {
        private readonly ICardService _service;
        public CardController(ICardService service)
        {
            _service = service;

        }

        [HttpPost]
        public IActionResult Add([FromBody] CardToAddDto dto)
        {
            _service.Add(dto);
            return Ok();
        }
    }
}
