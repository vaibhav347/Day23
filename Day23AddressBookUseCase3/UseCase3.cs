using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Day23AddressBookUseCase3
{
    public class UseCase3
    {
        string fname, lname, state, city;
        int zip, contact;
        //Create ArrayList obj
        ArrayList list = new ArrayList();
        public void insertData()
        {
            //Taking input from user
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
        public void edit()
        {
            Console.WriteLine("Enter Name to edit contact");
            fname = Console.ReadLine();
            if (list.Contains(fname))
            {
                Console.WriteLine("User Prsent");
                list.Remove(contact);
                Console.WriteLine("Previous contact of " + fname + " removed");
                Console.WriteLine("Please Enter New Contact");
                contact = int.Parse(Console.ReadLine());
                list.Add(contact);
                Console.WriteLine("----------------");
            }

        }
    }
}

