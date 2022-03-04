using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBook
{
    public class EditDetail
    {
        public void EditAddressBook()
        {
            

            Boolean menu = true;
            do
            {
                Console.WriteLine("Welcome to my address book program");
                Console.WriteLine("*****************************");
                Console.WriteLine("Press 1 to Add an entry to the address book :");
                Console.WriteLine("Press 2 to Remove any entry in the address book :");
                Console.WriteLine("Press 3 to Print the book to the screen :");
                Console.WriteLine("Press 4 to Edit a record :");
                Console.WriteLine("Press 5 to Search for a record :");
                Console.ReadLine();

                Console.WriteLine("Please Enter your First Name=:");
                string FIrst_Name = "FirstName";
                FIrst_Name = Console.ReadLine();
                string valueString1 = FIrst_Name;

                Console.WriteLine("Please Enter your last Name=:");
                string Last_Name = "LastName";
                Last_Name = Console.ReadLine();
                string valueString2 = Last_Name;

                Console.WriteLine("Please Enter your Address");
                string Add = "Address";
                Add = Console.ReadLine();
                string valueString3 = Add;

                Console.WriteLine("Please Enter your State:");
                string stat = "State";
                stat = Console.ReadLine();
                string valueString5 = stat;

                Console.WriteLine("Please Enter your Postcode");
                string code = "Postcode";
                code = Console.ReadLine();
                string valueString6 = code;

                Console.WriteLine("Please Enter your Email:");
                string Email = "Email";
                Email = Console.ReadLine();
                string valueString7 = Email;

                Console.WriteLine("Please Enter your Phone number:");
                string Num = "PhoneNum";
                Num = Console.ReadLine();
                string valueString8 = Num;

                Console.WriteLine("Your Address Book is Processing please enter the number What you want");
                Console.WriteLine("---***---***---***---***---***---***---***---***---***---***---***---");
                Console.WriteLine("Enter a number to Continue.........");
                Console.ReadLine();

                Console.WriteLine("Lastname you entered: " + valueString1);
                Console.WriteLine("Firstname you entered: " + valueString2);
                Console.WriteLine("Address and house number and town you entered: " + valueString3);
                Console.WriteLine("County you entered: " + valueString5);
                Console.WriteLine("Postcode you entered: " + valueString6);
                Console.WriteLine("Enter your Mail Adress: " + valueString7);
                Console.WriteLine("Enter your phone number: " + valueString8);
                Console.ReadLine();

            }
            while (menu == true);


        }

    }
}
