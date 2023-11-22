using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConAppAssignment18
{
    public class Program
    {
        static void Main(string[] args)
        {
            Smartphone phone = new Smartphone("One Plus 7");
            phone.Connect();
            phone.Charge(20);
            Console.WriteLine(phone.Display());
            Laptop Laptop = new Laptop("Samsung");
            Laptop.Connect();
            Laptop.Charge(30);
            Console.WriteLine(Laptop.Display());




            Console.ReadKey();
        }
    }
}