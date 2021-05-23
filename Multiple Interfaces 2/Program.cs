using System;

namespace Multiple_Interfaces2
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
    //class ClassA : customer                                         //Error 'ClassA' does not implement interface member 'ICustomer.print()'                          
    //{
    //    public void Display()
    //    {
    //        Console.WriteLine("print method from ClassA implimenting interface customer");
    //    }
    //}

    class Program
    {
        static void Main(string[] args)
        {
            ClassA a = new ClassA();
            a.Display();
            a.print();
        }
    }
}
