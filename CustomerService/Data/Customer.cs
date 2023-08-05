namespace CustomerService.Data
{
    public class Customer
    {
        public int Id { get; set; }
        public Guid ProductId { get; set; }
        public string Name { get; set; }
        public int ItemInCart { get; set; } 
    }
}
