using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fodbold_namespace

{
    public class Fodbold
    {
        public int num;
        public string mål;
       
        public void foldbold_method()
        {
           
            Console.WriteLine("\t FODBOLD GAME ");
            Console.WriteLine();
            Console.Write("Enter the number of passes : ");
            num = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the 'mål':");
            mål = Console.ReadLine();
            mål = mål.ToLower();
               if (num == 10 || num > 10)                      // if passes equal to 10  or greate than 10
                {
                    Console.Write("High Five  -- Jubel !!!");
                    Console.ReadKey();
                }
                else if (num < 1 && (mål.ToLower() == "mål"))        // if zero passes and goal
                {

                    Console.Write("Ole Ole Ole... ");
                    Console.ReadKey();
                }
                else if (num < 1 && (mål.ToLower() != "mål" || mål.Length == 0))    //  if zero passes and NO goal
                {
                    Console.Write("Shh... ");
                    Console.ReadKey();
                }
                else if (num > 2 && num < 10 && (mål.ToLower() == "mål"))// if passes between 1 and 10, goal
                {
                    Console.Write("Ole Ole Ole... ");
                    Console.ReadKey();
                }
                else if (num > 2 && num < 10 && (mål.ToLower() != "mål" || mål.Length == 0))// if passes between 1 and 10, NO goal
                {
                    for (int i = 0; i < num; i++)
                    {
                        
                        Console.Write("Huh! ");
                    }
                    Console.ReadKey();
                }
        
        }// close for method
 
    }
}
