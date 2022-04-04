using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EVA_IPO
{
    class Program
    {
        static void Main(string[] args)
        {
            //Nr.1
            int a = 0, b = 0, c = 0; //Input
            Console.WriteLine("Addition zweier Ganzzahlen");
            Console.WriteLine("");

            //Input
            Console.WriteLine("Bitte geben Sie einen Wert für a ein:");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Bitte geben Sie einen Wert für b ein:");
            b = Convert.ToInt32(Console.ReadLine());
            //Process
            c = a + b;
            //Output
            Console.WriteLine("Ergebnis: " + c);



            //Nr.2
            double m = 0, x = 0, b2 = 0, y = 0;
            string strIn = "";

            Console.WriteLine("");
            Console.WriteLine("Addition zweier Ganzzahlen");
            Console.WriteLine("y: m*x + b");
            Console.WriteLine("");
            Console.WriteLine("Bitte geben Sie einen Wert für m ein:");
            strIn = Console.ReadLine();//Input
            m = Convert.ToDouble(strIn);
            Console.WriteLine("Bitte geben Sie einen Wert für x ein:");
            strIn = Console.ReadLine();//Input
            x = Convert.ToDouble(strIn);
            Console.WriteLine("Bitte geben Sie einen Wert für b ein:");
            strIn = Console.ReadLine();
            b2 = Convert.ToDouble(strIn);
            y = m * x + b2;//Process
            Console.WriteLine("Ergebnis: " + y);//Output
        }
    }
}
