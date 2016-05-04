using System;

public class Class1
{
    public Class1()
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
