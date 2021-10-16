using System;

namespace Day23AddressBookUseCase5
{
    class Program
    {
        static void Main(string[] args)
        {
            int ch;
            //Create obj of class UseCase2
            UseCase5 obj = new UseCase5();
            do
            {
                Console.WriteLine("Insert Data : 1");
                Console.WriteLine("Display Data : 2");
                Console.WriteLine("Edit Contact : 3");
                Console.WriteLine("Exit : 4");
                Console.WriteLine("----------------");
                Console.WriteLine("Enter Your Choice");
                ch = int.Parse(Console.ReadLine());
                //Switch case 
                switch (ch)
                {
                    case 1:
                        obj.insertData();
                        break;
                    case 2:
                        obj.display();
                        break;
                    case 3:
                        obj.delete();
                        break;
                    default:
                        Console.WriteLine("Please enter valid choice");
                        break;

                }
            } while (ch != 4);
        }
    }
}
