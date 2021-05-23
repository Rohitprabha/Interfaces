using System;

namespace Interfaces
{
    interface ICustomer
    {
        //int CID;                            //Error Interfaces cannot contain instance fields
        void print();
        //void display()                                //interface cannot contain implementation
        //{
        //    Console.WriteLine("Hello World!");
        //}
    }
    //class ClassA : ICustomer                       //Error 'ClassA' does not implement interface member 'ICustomer.print()'
    //{

    //}
    
    class ClassB : ICustomer
    {
        //public void print(int num1, int num2)                     //Error 'ClassB' does not implement interface member 'ICustomer.print()'
        //{ 
            
        //}
        public void print()
        {
            Console.WriteLine("print method from ClassB implimenting interface Icustomer");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            //ICustomer c = new ICustomer();                  //Error Cannot create an instance of the abstract type or interface 'ICustomer'	
            ClassB b = new ClassB();
            b.print();
        }
    }
}
