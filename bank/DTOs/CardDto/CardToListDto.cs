using bank.DTOs.BankDto;
using bank.Entities;

namespace bank.DTOs.CardDto
{
    public record CardToListDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public BankToAddDto Banks { get; set; }
    }
}
