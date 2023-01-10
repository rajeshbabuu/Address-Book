using System.IO.Pipes;

namespace AddressBook
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Address Book");
            Person person = new Person();

            person.FirstName = "Rajesh";
            person.LastName = "Kumar";
            person.MobileNumber = 455555;
            person.Email = "rajesh007@gmail.com";
            person.Address = " Moti Zheel Etawah";
            person.City = "Etawah";
            person.zip = 123456;
            person.State = "UP";
        }
    }
}