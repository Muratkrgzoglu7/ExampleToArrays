using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            //string[] students = new string[3];
            //students[0] = "engin";
            //students[1] = "Ahmet";
            //students[2] = "murat";

            //                   //new[] 
            //string[] students2 =     { "engin", "ahmet", "murat" };
            //foreach (var student in students2)

            {
                //Console.WriteLine(student);
            }
              string[,] regions = new string[5, 3]
            {
                {"istanbul","izmir","yalova" },
                {"rize","trabzon","samsun" },
                {"adana","antalya","mersin" },
                {"izmit","muğla","manisa" },
                {"ankara","konya","kırıkkale" },
            };
            for (int i = 0; i <= regions.GetUpperBound(0); i++)
            {
                for (int j = 0; j <= regions.GetUpperBound(1); j++)
                {
                    Console.WriteLine(regions[i, j]);                                
                }
                Console.WriteLine("*******");
            }
            Console.WriteLine();
            Console.ReadLine();
        }
        
    }
}
