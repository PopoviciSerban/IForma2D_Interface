using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface_IForma2D
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }

    interface IForma2D
    {
        double Aria();
        double LungimeaFrontierei();
        string Denumire{ get; }
    }

    public class Cerc : IForma2D
    {
        private double r;

        public Cerc(double x) { r = x; }

        public double Aria() { return Math.PI * r * r; }

        public double LungimeaFrontierei() { return Math.PI * 2 * r; }

        public string Denumire => "Cerc";
    }

    public class Patrat : IForma2D
    {
        private double l;

        public Patrat(double x) { l = x; }

        public double Aria() { return l * l; }

        public double LungimeaFrontierei() { return 4 * l; }

        public string Denumire => "Patrat";
    }
}
