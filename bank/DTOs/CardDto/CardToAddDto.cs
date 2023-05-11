using bank.DTOs.BankDto;
using bank.Entities;

namespace bank.DTOs.CardDto
{
    public class CardToAddDto
    {
        
        public string Name { get; set; }
        public List<BankToAddDto> Banks { get; set; }
    }
}
