using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace numbers2words
{
    class Program
    {

        static void Main(string[] args)
        {
            start: 
            int n;
            string[] x = { "Zero ", "One ", "Two ", "Three ", "Four ", "Five ", "Six ", "Seven ", "Eight ", "Nine " };
            string[] y = { "Ten ", "Eleven ", "Twelve ", "Thirteen ", "Fourteen ", "Fifteen ", "Sixteen ", "Seventeen ", "Eighteen ", "Nineteen " };
            string[] z = { "Twenty ", "Thirty ", "Fourty ", "Fifty ", "Sixty ", "Seventy ", "Eighty ", "Ninety " };
            Console.Write("Enter a number between [ 0 : 999 ]  :  ");
            n = int.Parse(Console.ReadLine());
            if (n>=0 && n <=9 )
            {
                Console.WriteLine(x[n]);
            }
            else if (n>9 && n<20)
            {
                Console.WriteLine(y[n % 10]);
            }
            else if (n>19 && n <100)
            {
                int d = n / 10;
                int r = n % 10;
                if (r == 0)
                {
                    Console.WriteLine(z[d - 2]);
                }
               else if (r>0)
                {
                    Console.WriteLine(z[d - 2] + x[r]);
                }    
            }
            else if (n > 99 && n < 1000 )
            {
                int dd = n / 100;
                int rr = n % 100;
                if (rr == 0 )
                { 
                    Console.WriteLine(x[dd] + " Hundreds" );
                }
                else if (rr > 0 && rr <10)
                {
                    Console.WriteLine(x[dd] + " Hundreds" + " and " + x[rr]);
                }
                else if (rr > 9 && rr < 20 )
                {
                    Console.WriteLine(x[dd] + " Hundreds" + " and " + y[n % 10]);
                }
                else if (rr > 19 && rr <100)
                {
                    if (rr % 10 == 0)
                    {
                        Console.WriteLine(x[dd] + " Hundreds" + " and " + z[(rr / 10) - 2]);
                    }
                    else if (rr % 10 > 0)
                    {
                        Console.WriteLine(x[dd] + " Hundreds" + " and " + z[(rr / 10) - 2] + x[rr % 10]);
                    } 
                }
            }

            else if (n>999)
            {
                Console.WriteLine("OUT OF THE RANGE , Try Again :) ");
                goto start; 

            }
            Console.ReadKey();






        }
    }
}
