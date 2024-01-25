using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace _25._01._2024._
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Kolko danni shte vivejdash");
            int n=int.Parse(Console.ReadLine());
            string[] name =new string[n];
            string[] predmet = new string[n];
            int[] ocenki = new int[n];


            for(int i=0; i<n; i++) 
            {
            Console.Write("Vivedi ime");
            name[i] =Console.ReadLine();
            Console.Write("Kakiv predmet imash");
            predmet[i]=Console.ReadLine();
            Console.Write("Kolko broq ocenki imash");
            ocenki[i] =int.Parse(Console.ReadLine());
            }
        }
    }
}
