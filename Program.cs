using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3_ev_tapsirigi_method
{
    class Program
    {
        static void Main(string[] args)
        {

            string[] arry = { "Salam","baki","Pervin","Metin" };
            
            char symbol = ',';
            Console.WriteLine(Mymethod(arry, symbol)); ;
            
        }

          static string Mymethod(string[] arry, char symbol)
        {
            string arry1 = "";
            for (int i = 0; i < arry.Length; i++)
            { if (i == 0)
                {
                    arry1 = arry1  + arry[i];
                }
                else {
                    arry1 = arry1 + symbol + arry[i];

                }
                
                
                
            }
            return arry1;
        }
       
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    }
}
