using PublicTransport.Models;
using PublicTransport.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PublicTransport.Controllers
{
    public class TransportController
    {
        Transport transport;
        Display display;

        public TransportController()
        {
            display = new Display();

            display.Input();


            transport = new Transport(display.Distance, display.TimeOfDay);
            display.Price = transport.CalculatePrice();

            display.Output();
        }
    }
}
