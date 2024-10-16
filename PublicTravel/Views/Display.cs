using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PublicTransport.Views
{
    public class Display
    {
        public int Distance { get; set; }
        public string TimeOfDay { get; set; }
        public double Price { get; set; }

        public void Input()
        {
            Console.WriteLine("rasstoqnie");
            Distance = int.Parse(Console.ReadLine());
            Console.WriteLine("vreme na denq");
            TimeOfDay = Console.ReadLine();
        }

        public void Output()
        {
            Console.WriteLine($"cena {Price:f2}");
        }
    }
}
