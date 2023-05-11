using bank.DTOs.CardDto;
using bank.DTOs.UserDto;
using bank.Entities;

namespace bank.DTOs.OrderDto
{
    public record OrderToAddDto
    {
        
        public CardToAddDto Card { get; set; }
               public UserToAddDto Users { get; set; }
        public string OrderStatus { get; set; }
    }
}
