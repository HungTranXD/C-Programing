using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.assignment2
{
    internal class PhoneBook : AbstractPhone
    {
        private List<PhoneNumber> phoneList = new List<PhoneNumber>();

        //Properties
        public List<PhoneNumber> PhoneList 
        { 
            get { return phoneList; } 
            set { phoneList = value; }
        }

        //Constructors
        public PhoneBook() { }
        public PhoneBook(List<PhoneNumber> phoneList)
        {
            this.PhoneList = phoneList;
        }


        public override void InsertPhone(string name, string phone)
        {
            foreach (PhoneNumber pn in PhoneList) 
            { 
                //Kiểm tra tên
                if (pn.Name.Equals(name))
                {
                    //Nếu tên đã có thì kiểm tra số điện thoại
                    foreach (string n in pn.Numbers)
                    {
                        if (n.Equals(phone))
                        {
                            return;
                        }
                    }
                    pn.Numbers.Add(phone);
                    return;
                }
            }
            PhoneList.Add(new PhoneNumber(name, new List<string>(1) { phone }));
        }

        public override void RemovePhone(string name)
        {
            foreach (PhoneNumber pn in PhoneList)
            {
                if (pn.Name.Equals(name))
                {
                    PhoneList.Remove(pn);
                    return;
                }
            }
        }

        public override void UpdatePhone(string name, string oldPhone, string newPhone)
        {
            foreach (PhoneNumber pn in PhoneList)
            {
                //Tìm đến tên
                if (pn.Name.Equals(name))
                {
                    pn.Numbers.Remove(oldPhone);
                    pn.Numbers.Add(newPhone);
                    return;
                }
            }
        }

        public override PhoneNumber SearchPhone(string name)
        {
            foreach (PhoneNumber pn in PhoneList)
            {
                //Tìm đến tên
                if (pn.Name.Equals(name))
                {
                    return pn;
                }
            }
            return null;
        }

        public override void Sort()
        {
            PhoneList.Sort((x, y) => x.Name.CompareTo(y.Name));
        }

        

    }
}
