using System.IO.Pipes;

namespace AddressBook
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Address Book  \n");

            ContactDetails contactDetail = new ContactDetails();

            Boolean flag = true;


            while (flag)
            {
                Console.WriteLine("Enter 1 for Add person Details ");
                Console.WriteLine("Enter 2 for displaying person details");
                Console.WriteLine("Enter 3 for Exit");

                int userInput = int.Parse(Console.ReadLine());

                switch (userInput)
                {
                    case 1:
                        Console.WriteLine("Please Add All the Details :");
                        Console.Write("Enter the First Name : ");
                        string first_Name = Console.ReadLine();
                        Console.Write("Enter the Last Name : ");
                        string last_Name = Console.ReadLine();
                        Console.Write("Enter the Mobile Number : ");
                        string mobile_Number = Console.ReadLine();
                        Console.Write("Enter the Email Id : ");
                        string email_Id = Console.ReadLine();
                        Console.Write("Enter the Address : ");
                        string address = Console.ReadLine();
                        Console.Write("Enter the City : ");
                        string city = Console.ReadLine();
                        Console.Write("Enter the State : ");
                        string state = Console.ReadLine();
                        Console.Write("Enter the Zip : ");
                        string zip = Console.ReadLine();
                        Person person1 = new Person()
                        {
                            FirstName = first_Name,
                            LastName = last_Name,
                            MobileNumber = int.Parse(mobile_Number),
                            Email = email_Id,
                            Address = address,
                            City = city,
                            State = state,
                            zip = int.Parse(zip),
                        };
                        contactDetail.AddPersonDetails(person1);

                        break;
                    case 2:
                        contactDetail.DisplayContact();
                        break;
                    default:
                        Console.WriteLine("Exiting the loop .");
                        flag = false;
                        break;
                }
            }
        }
    }
}