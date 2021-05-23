using System;

namespace Multiple_interface3
{
    interface ICustomer
    {
        void print();

    }
    interface customer : ICustomer              //interface can inherit from another interface
    {
        void Display();
    }
    class ClassA : customer
    {
        public void Display()
        {
            Console.WriteLine("print method from ClassA implimenting interface customer");
        }
        public void print()
        {
            Console.WriteLine("print method from ClassA implimenting interface Icustomer");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            ICustomer a = new ClassA();                     // Icustomer is parent to ClassA so reference variable of it can point to ClassA object
            a.print();
        }
    }
}
