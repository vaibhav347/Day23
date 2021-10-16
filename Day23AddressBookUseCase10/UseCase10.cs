using System;
using System.Collections.Generic;
using System.Text;

namespace Day23AddressBookUseCase10
{
    public class UseCase10
    {
        Dictionary<long, string> contact = new Dictionary<long, string>();
        Dictionary<string, string> state = new Dictionary<string, string>();
        public void insertData()
        {
            contact.Add(9359864239, "Vaibhav");
            contact.Add(9359864240,"Pratibha");
            contact.Add(9359864241,"Nita");
            int a=contact.Count;
            Console.WriteLine("Total contacts : " + a);
        }
        public void display()
        {
            foreach (var data in contact)
            {

                Console.WriteLine(data);
            }
            
        }

    }
}
