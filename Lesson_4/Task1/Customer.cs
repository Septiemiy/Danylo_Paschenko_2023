namespace SingleResponsibility
{
    public class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Balance { get; set; }

        public Customer(int id, string name, decimal balance)
        {
            Id = id;
            Name = name;
            Balance = balance;
        }

        public List<Customer> CustomersList = new List<Customer>()
        {
            new Customer(1, "Fikus", 0),
            new Customer(2, "VHarbar", 100000)
        };
    }
}