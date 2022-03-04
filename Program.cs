using System;

namespace AddressBook
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Address Book Program.");

            //UC1_FirstPerson person = new UC1_FirstPerson();
            //person.FirstPerson();

            //EditDetail editDetail = new EditDetail();
            //editDetail.EditAddressBook();

            ModifyPrebviousDetails.GetCustomer();
            ModifyPrebviousDetails.ListingPeople();

            
        }
    }
}