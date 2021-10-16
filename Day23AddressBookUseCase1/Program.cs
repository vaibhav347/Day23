using System;

namespace Day23AddressBookUseCase1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Create object of class UseCase1
            UseCase1 obj = new UseCase1();
            //Call methods using object
            obj.insertData();
            obj.display();
        }
    }
}
