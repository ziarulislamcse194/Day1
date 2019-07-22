using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Services;
using System.Text;
using System.Threading.Tasks;

namespace MyApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please Enter Your Name");
            string name = Console.ReadLine();
            

            Console.WriteLine("Please Enter a Address");
            string address = Console.ReadLine();
            

            Console.WriteLine("Please Enter Contact Number");
            int number = Convert.ToInt32(Console.ReadLine());
            

            Console.WriteLine("Please Enter a Age");
            int age = Convert.ToInt32(Console.ReadLine());
            

            Console.WriteLine("Please Enter Date of Birth");
            string dateOfBitrth = Console.ReadLine();

            Console.WriteLine("---------------------------------------------------");
            Console.WriteLine("---------------------------------------------------");

            Console.WriteLine("Name is: [" + name + " ]");
            Console.WriteLine("Address is: [" + address + "]");
            Console.WriteLine("Contact is: [" + number + "]");
            Console.WriteLine("Age is: [" + age + "]");
            Console.WriteLine("Date of Birth is: [" + dateOfBitrth + "]");
            Console.ReadKey();
        }
    }
}
