using System;

namespace Interface_Types
{
    interface ICustomer
    {
        void print();

    }
    interface customer
    {
        void print();
    }
    class ClassA : ICustomer, customer
    {
        //Implicit interface Implementation
        public void print()
        {
            Console.WriteLine("print method from ClassA");
        }

        //Explicit interface Implementation
        void ICustomer.print()
        {
            Console.WriteLine("print method from ClassA implimenting interface Icustomer");
        }
        void customer.print()
        {
            Console.WriteLine("print method from ClassA implimenting interface customer");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            ClassA a = new ClassA();
            a.print();

            ICustomer b = new ClassA();
            b.print();

            customer c = new ClassA();
            c.print();
        }
    }
}