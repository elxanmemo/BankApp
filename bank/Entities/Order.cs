namespace bank.Entities
{
    public class Order
    {
        public int Id { get; set; }
        public List<Card> Cards { get; set; }
        public int CardId { get; set; }
        public User Users { get; set; }
        public int UsersId { get; set; }
        public string OrderStatus { get; set; }
    }
}
