using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiApplication
{
    internal class DistanceTraveled
    {
        private double speed;
        private double travelTime;

        public DistanceTraveled(double speed, double travelTime)
        {
            this.speed = speed;
            this.travelTime = travelTime;
        }

        public double _Speed
        {
            get { return speed; }
            set { speed = value; }
        }

        public double _TravelTime
        {
            get { return travelTime; }
            set { travelTime = value; }
        }

        public double getDistance()
        {
            return speed * travelTime;
        }
    }
}
