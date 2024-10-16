using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PublicTransport.Models
{
    public class Transport
    {
        private int distance;
        private string timeOfDay;

        private double taxiStartFee = 0.70;
        private double taxiDayRate = 0.79;
        private double taxiNightRate = 0.90;
        private double busRate = 0.09;
        private double trainRate = 0.06;

        public int Distance
        {
            get { return this.distance; }
            set { this.distance = value; }
        }

        public string TimeOfDay
        {
            get { return this.timeOfDay; }
            set { this.timeOfDay = value; }
        }

        // konstruktor
        public Transport()
        {

        }
        public Transport(int distance, string timeOfDay)
        {
            this.Distance = distance;
            this.TimeOfDay = timeOfDay;
        }



        // smqta cenite
        public double CalculatePrice()
        {
            double lowestPrice = double.MaxValue;

            // taksi tarifa
            if (this.timeOfDay == "day")
            {
                lowestPrice = this.taxiStartFee + this.distance * this.taxiDayRate;
            }
            else if (this.timeOfDay == "night")
            {
                lowestPrice = this.taxiStartFee + this.distance * this.taxiNightRate;
            }

            // reis
            if (this.distance >= 20)
            {
                double busPrice = this.distance * this.busRate;
                if (busPrice < lowestPrice)
                {
                    lowestPrice = busPrice;
                }
            }

            // vlak
            if (this.distance >= 100)
            {
                double trainPrice = this.distance * this.trainRate;
                if (trainPrice < lowestPrice)
                {
                    lowestPrice = trainPrice;
                }
            }

            return lowestPrice;
        }


    }
}
