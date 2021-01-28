using System;
using System.Collections.Generic;

namespace Koleksiyonlar
{
    class Program
    {
        static void Main(string[] args)
        {
            //string[] isimler = new string[] { "Ozlem", "Gokhan" };
            //Console.WriteLine(isimler[0]);
            //Console.WriteLine(isimler[1]);


            List<string> isimler2 = new List<string>() {"Ozlem","Gokhan" };
            Console.WriteLine(isimler2[0]);
            Console.WriteLine(isimler2[1]);

            isimler2.Add("Atik");
            Console.WriteLine(isimler2[2]);
            Console.WriteLine(isimler2[0]);
        }
    }
}
