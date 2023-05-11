namespace bank.Entities
{
    public class Card
    {
        public int Id { get;set; }
        public string Name { get;set; }
        public List<Bank> Banks { get; set; }
    } 
}
