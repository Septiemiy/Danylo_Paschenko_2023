using SingleResponsibility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    public class UpdateCustomerBalance : FillTheCustomers
    {
        public Customer GetById(int id)
        {
            return CustomersList.FirstOrDefault(x => x.Id == id);
        }
        public void SaveToDatabase()
        {
            Console.WriteLine("Saved!");
        }
        public void UpdateBalance(int id, decimal newBalance)
        {
            var customer = GetById(id);
            customer.Balance = newBalance;
            SaveToDatabase();
        }
    }
}
