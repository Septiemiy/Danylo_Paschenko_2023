using SingleResponsibility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    public class GetCustomerBalance
    {
        public Customer Customer { get; }

        public void GetBalance(int id)
        {
            Console.WriteLine($"Your balance is: {GetBalanceById(id)}");
        }
        public decimal GetBalanceById(int id)
        {
            var customer = Customer.CustomersList.FirstOrDefault(x => x.Id == id);
            return customer.Balance;
        }
    }
}
