using System;
using System.Collections.Generic;
using System.Text;

namespace Day23AddressBookUseCase9
{
    public class UseCase9
    {
      Dictionary<string,string> city = new Dictionary<string,string>();
        Dictionary<string, string> state = new Dictionary<string, string>();
       public void insertData()
        {
            city.Add("Vaibhav","Pune");
            city.Add("Pratibha","Pune");
            city.Add("Nita","Aurangabad");
            state.Add("Pune", "Maharashtra");
            state.Add("Aurangabad", "Goa");
        }
        public void display()
        {
            if (city.ContainsValue("Pune") == state.ContainsValue("Pune"))
            {
                foreach(var data in state)
                {
                    Console.WriteLine(data);
                }
            }
                foreach (var data in city)
            {
                
                Console.WriteLine(data);
            }
            foreach(var data in state)
            {
                Console.WriteLine(data);
            }
        }

        
    }
}
