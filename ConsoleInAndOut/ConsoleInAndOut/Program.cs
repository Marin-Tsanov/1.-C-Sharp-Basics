using System;

namespace ConsoleInAndOut
{
    class Program
    {
        static void Main()
        {
            string companyName = Console.ReadLine();
            string address = Console.ReadLine();
            string phoneNumber = Console.ReadLine();
            string s; 
            string faxNumber = String.IsNullOrEmpty(s = Console.ReadLine()) ? "(no fax)" : s;
            string webSite = Console.ReadLine();
            string managerFirstName = Console.ReadLine();
            string managerLastName = Console.ReadLine();
            string managerAge = Console.ReadLine();
            string managerPhone = Console.ReadLine();

            Console.WriteLine(companyName);
            Console.WriteLine("Address: "+address);
            Console.WriteLine("Tel. "+phoneNumber);
            Console.WriteLine("Fax: "+faxNumber);
            Console.WriteLine("Web site: "+webSite);
            Console.WriteLine("Manager: " + managerFirstName +" " + managerLastName +" "+ "(age: " + managerAge + ", " + "tel. " +managerPhone+ ")");
        }
    }
}
