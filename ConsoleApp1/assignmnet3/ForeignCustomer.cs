using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.assignmnet3
{
    internal class ForeignCustomer : Customer
    {
        //Constructors
        public ForeignCustomer() { }
        public ForeignCustomer(string customerCode, string fullName, DateOnly dateOfBill, int electricityConsumed) : base(customerCode, fullName, dateOfBill, electricityConsumed) { }
        
        //Overide method
        public override double CalPayment()
        {
            return (double) ElectricityConsumed * 2000;
        }
    }
}
