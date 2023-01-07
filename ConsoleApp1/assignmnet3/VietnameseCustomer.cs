using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.assignmnet3
{
    enum VnCusType
    {
        SinhHoat,
        KinhDoanh,
        SanXuat
    }
    internal class VietnameseCustomer : Customer
    {
        private VnCusType cusType;
        public VnCusType CusType
        {
            get => cusType;
            set => cusType = value;
        }
        
        //Constructors
        public VietnameseCustomer() { }
        public VietnameseCustomer(string customerCode, string fullName, DateOnly dateOfBill, int electricityConsumed, VnCusType type) :base(customerCode, fullName, dateOfBill, electricityConsumed)
        {
            CusType = type;
        }

        //Method CalPayment() is the same as base class 
    }
}
