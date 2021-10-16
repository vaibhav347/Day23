using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Day23AddressBookUseCase7
{
    public class UseCase7
    {
        string fname, lname, state, city;
        int zip, contact;
        //Create ArrayList obj
        ArrayList list = new ArrayList();
        public void insertData()
        {
            //Taking input from user
            if (list.Contains(fname) == false)
            {
                Console.WriteLine("Enter First Name");
                fname = Console.ReadLine();
                list.Add(fname);
                Console.WriteLine("Enter Last Name");
                lname = Console.ReadLine();
                list.Add(lname);
                Console.WriteLine("Enter Contact");
                contact = int.Parse(Console.ReadLine());
                //Inser data in ArrayList using ArrayList object
                list.Add(contact);
                Console.WriteLine("Enter City");
                city = Console.ReadLine();
                list.Add(city);
                Console.WriteLine("Enter State");
                state = Console.ReadLine();
                list.Add(city);
                Console.WriteLine("Enter Zip");
                zip = int.Parse(Console.ReadLine());
                list.Add(zip);
            }
            else
                Console.WriteLine("This record already present");
            Console.WriteLine("----------------");
        }
        public void display()
        {
            //Display ArrayList Data on console
            foreach (var data in list)
            {
                Console.WriteLine(data);
            }
            Console.WriteLine("----------------");
        }
        public void delete()
        {
            Console.WriteLine("Enter Name to delete record");
            fname = Console.ReadLine();
            if (list.Contains(fname))
            {
                Console.WriteLine("User Prsent");
                list.Remove(fname);
                list.Remove(lname);
                list.Remove(contact);
                list.Remove(city);
                list.Remove(state);
                list.Remove(zip);
                Console.WriteLine("Record removed successfully");
                Console.WriteLine("----------------");
            }
            else
                Console.WriteLine("User not present");
        }
    }
}
