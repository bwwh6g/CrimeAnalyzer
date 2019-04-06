using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrimeAnalyzer
{
    class Program
    {
        static void Main(string[] args)
        {
            var crimeData = new List<CrimeData>
            {
              using (StreamReader sr = new StreamReader("CrimeData.csv"))
            {
                string currentLine;
                while ((currentLine = sr.ReadLine()) != null)
                {
                    string[] values = currentLine.Split(',');
                    CrimeData crimeValues = new CrimeData();
                    crimeValues.Year = int.Parse(values[0]);
                    crimeValues.Population = int.Parse(values[1]);
                    crimeValues.ViolentCrime = int.Parse(values[2]);
                    crimeValues.Murder = int.Parse(values[3]);
                    crimeValues.Rape = int.Parse(values[4]);
                    crimeValues.Robbery = int.Parse(values[5]);
                    crimeValues.AggravatedAssault = int.Parse(values[6]);
                    crimeValues.PropertyCrime = int.Parse(values[7]);
                    crimeValues.Burglary = int.Parse(values[8]);
                    crimeValues.Theft = int.Parse(values[9]);
                    crimeValues.MotorVehicleTheft = int.Parse(values[10]);
                }
            }
        }
    };


    public class CrimeData
    {
        public int Year { get; set; }
        public int Population { get; set; }
        public int ViolentCrime { get; set; }
        public int Murder { get; set; }
        public int Rape { get; set; }
        public int Robbery { get; set; }
        public int AggravatedAssault { get; set; }
        public int PropertyCrime { get; set; }
        public int Burglary { get; set; }
        public int Theft { get; set; }
        public int MotorVehicleTheft { get; set; }

    }
}
