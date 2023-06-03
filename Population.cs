using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiApplication
{
    internal class Population
    {
        private double numOrganisms;
        private double averageIncrease;
        private int daysMultiply;

        public Population(double numOrganisms, double averageIncrease, int daysMultiply)
        {
            this.numOrganisms = numOrganisms;
            this.averageIncrease = averageIncrease;
            this.daysMultiply = daysMultiply;
        }

        public string displayPopulation()
        {
            double temp = numOrganisms;
            string result = string.Empty;
            for (int i = 0; i < daysMultiply; i++)
            {
                result += "Day: " + (i + 1) + " Population: " + temp + Environment.NewLine;
                temp = temp + (temp * (averageIncrease / 100));
            }
            return result;
        }
    }
}
