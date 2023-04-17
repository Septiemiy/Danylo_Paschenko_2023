using SingleResponsibility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    public class UpdateBalanceAndSaveDB
    {
        public Customer Customer { get; }
        public Customer GetById(int id)
        {
            return Customer.CustomersList.FirstOrDefault(x => x.Id == id);
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
