using System;

namespace Day23AddressBookUseCase2
{
    class Program
    {
        static void Main(string[] args)
        {
            int ch;
            //Create obj of class UseCase2
            UseCase2 obj = new UseCase2();
            do
            {
                Console.WriteLine("Insert Data : 1");
                Console.WriteLine("Display Data : 2");
                Console.WriteLine("Exit : 3");
                Console.WriteLine("----------------");
                Console.WriteLine("Enter Your Choice");
                ch = int.Parse(Console.ReadLine());
                //Switch case 
                switch(ch)
                {
                    case 1:
                        obj.insertData();
                        break;
                    case 2:
                        obj.display();
                        break;
                    default:
                        Console.WriteLine("Please enter valid choice");
                        break;

                }
            } while (ch != 3);
        }
    }
}
