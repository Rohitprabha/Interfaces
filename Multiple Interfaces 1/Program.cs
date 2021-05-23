using System;

namespace Multiple_Interfaces
{
    interface ICustomer
    {
        void print();

    }
    interface customer
    {
        void Display();
    }
    class ClassA : ICustomer, customer                          //class can inherit from more than one interface at the same time
    {
        public void print()
        {
            Console.WriteLine("print method from ClassA implimenting interface Icustomer");
        }
        public void Display()
        {
            Console.WriteLine("print method from ClassA implimenting interface customer");
        }
    }
    class ClassB
    {

    }
    class Program : ClassA
    {
        static void Main(string[] args)
        {
            Program p = new Program();
            p.Display();
            p.print();
        }
    }
    //class Program : ClassA, ClassB                               //Error Class 'Program' cannot have multiple base classes: 'ClassA' and 'ClassB'
    //{
    //    static void Main(string[] args)
    //    {
    //        ClassA a = new ClassA();
    //        a.print();
    //        a.Display();
    //    }
    //}
}
