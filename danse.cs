using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Danse_namespace
{
    public class danse
    {
        public string danser_navn;
        public int danser_points ;
        
        public void danse_method()
        {
            danse d3 = new danse();
            danse d1 = new danse();
           danse d2 = new danse();
            

            d3.danser_navn = d1.danser_navn + "&" + d2.danser_navn;

            d3.danser_points = d1.danser_points + d2.danser_points;
           // return d3;
            Console.WriteLine("\t\t\tDANSE KONKURRENCE");

            //danse d1 = new danse();
            Console.Write("Enter danser 1 navn:  ");
            d1.danser_navn = Console.ReadLine();
            Console.Write("Enter danser 1 points:  ");
            d1.danser_points = Convert.ToInt32(Console.ReadLine());

            //danse d2 = new danse();
            Console.Write("Enter danser 2 navn:  ");
            d2.danser_navn = Console.ReadLine();
            Console.Write("Enter danser 2  points:  ");
            d2.danser_points = Convert.ToInt32(Console.ReadLine());
            d3.danser_navn = d1.danser_navn + "&" + d2.danser_navn;

            d3.danser_points = d1.danser_points + d2.danser_points;

            //danse d3 = new danse();
            //d3 = d1 + d2;
            Console.Write(d3.danser_navn);
            Console.Write("\t");
            Console.Write(d3.danser_points);
            Console.ReadKey();
        }
            
        
    }
}
