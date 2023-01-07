using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.assignmnet3
{
    internal class Customer
    {
        //Feilds
        private string customerCode;
        private string fullName;
        private DateOnly dateOfBill;
        private int electricityConsumed;

        //Properties
        public string CustomerCode 
        {
            get => customerCode;
            set => customerCode = value;
        }
        public string FullName 
        {
            get => fullName;
            set => fullName = value;
        }
        public DateOnly DateOfBill 
        {
            get => dateOfBill; 
            set => dateOfBill = value;
        }
        public int ElectricityConsumed 
        {
            get => electricityConsumed; 
            set => electricityConsumed = value;
        }
        
        //Constructors
        public Customer() { }
        public Customer(string customerCode, string fullName, DateOnly dateOfBill, int electricityConsumed)
        {
            CustomerCode = customerCode;
            FullName = fullName;
            DateOfBill = dateOfBill;
            ElectricityConsumed = electricityConsumed;
        }

        //Method to Caculate payment amount
        public virtual double CalPayment()
        {
            if (ElectricityConsumed < 50)
                return (double) ElectricityConsumed * 1000;
            else if (ElectricityConsumed < 100)
                return (double) 50 * 1000 + (ElectricityConsumed - 50) * 1200;
            else if (ElectricityConsumed < 200)
                return (double) 50 * 1000 + 50 * 1200 + (ElectricityConsumed - 100) * 1500;
            else
                return (double) 50 * 1000 + 50 * 1200 + 100 * 1500 + (ElectricityConsumed - 200) * 2000;
        }

    }
}
