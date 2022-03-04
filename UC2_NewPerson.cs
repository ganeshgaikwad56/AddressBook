using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBook
{
    public class UC2_NewPerson
    {
        public void OldPerson()
        {
            Console.WriteLine("Please Enter your First name :");
            string Name = Console.ReadLine();

            Console.WriteLine("Please Enter Your Last Name :");
            string LastNmae = Console.ReadLine();

            Console.WriteLine("Please Enter Your Address");
            var Address = Console.ReadLine();

            Console.WriteLine("Please Enter your City : ");
            string City = Console.ReadLine();

            Console.WriteLine("Please Enter your State :");
            string State = Console.ReadLine();

            Console.WriteLine("Please Enter ZipCode :");
            string Zip = Console.ReadLine();

            Console.WriteLine("Please Enter Your 10 Digit Mobile/Phone number :");
            string Number = Console.ReadLine();

            Console.WriteLine("Enter Email :");
            string Email = Console.ReadLine();

            Console.WriteLine("dear " + Name + LastNmae + " Your deatils has been saved successfully ");

            Console.WriteLine("Name: " + Name + LastNmae);
            Console.WriteLine("Address: " + Address);
            Console.WriteLine("City: " + City);
            Console.WriteLine("State: " + State);
            Console.WriteLine("Zipcode: " + Zip);
            Console.WriteLine("MoNo. : " + Number);
            Console.WriteLine("email: " + Email);
            Console.WriteLine("************Adding New Person Details *********");
            
        }
    }
}
