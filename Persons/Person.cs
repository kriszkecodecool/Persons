using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persons
{
    [Serializable]
    class Person
    {
        string name;
        string phone;
        string address;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public string Phone
        {
            get { return phone; }
            set { phone = value; }
        }

        public string Address
        {
            get { return address; }
            set { address = value; }
        }

        public Person(string name, string phone, string address)
        {
            this.name = name;
            this.phone = phone;
            this.address = address;
        }

    }
}
