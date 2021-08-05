using System;

namespace OOPPrinciples
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person;
            Random rand = new Random();
            int myRandomInt = rand.Next(0, 2);
            if (myRandomInt == 0)
            {
                person = new Customer("Alex", "Rae", "White House");
            }
            else
            {
                person = new Employee("Michael", "Jordan", "Basketball");
            }
            person.Print();

            //Customer cust = new Customer("Alex", "Rae", "White House");
            //cust.LastName = "Smith";
            //cust.Print();

            //Employee emp = new Employee("Michael", "Jordan", "Basketball");
            //emp.Print();
        }
    }
}
