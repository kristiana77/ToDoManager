using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace упражнение
{
    internal class Program
    {
        //static string filePath = "Zadachi.txt";
        static List<Class> zadacha = new List<Class>();
        static void Main(string[] args)
        {

            //();
            while (true)
            {
                Console.WriteLine("MENU");
                Console.WriteLine("za da dobavish nova zadacha-1");
                Console.WriteLine("da vidish vsichki zadachi-2");
                Console.WriteLine("markirai zadacha kato reshena-3");
                Console.WriteLine("iztrii zadacha-4");
                Console.WriteLine("izhod-5");
                Console.WriteLine("izberete ot 1 do 5");

                string izbor = Console.ReadLine();

                if (izbor == "1") dobaviZadacha();
                else if (izbor == "2") vijVsichki();
                else if (izbor == "3") Mark();
                else if (izbor == "4") Iztrii();
                else if (izbor == "5")
                {
                    Console.WriteLine("Krai"); break;
                }
                else Console.WriteLine("Nevaliden izbor.Try again.");
            }
        }

        private static void Iztrii()
        {
            throw new NotImplementedException();
        }

        private static void Mark()
        {
            throw new NotImplementedException();
        }

        private static void vijVsichki()
        {
            throw new NotImplementedException();
        }

       

        static void dobaviZadacha()
        {
            Console.Write("vuvedete zaglavie:");
            string zaglavie= Console.ReadLine();
            Console.Write("vuvedete opisanie:");
            string opisanie= Console.ReadLine();
            Console.Write("vuvedete kraen srok:");
            int kraenSrok = int.Parse(Console.ReadLine());
            Console.Write("vuvedete dali e izpulnena:");
            bool mark=bool.Parse(Console.ReadLine());

           // Class newZadacha = new Class(zaglavie, opisanie, kraenSrok, mark);
           // zadacha.Add(newZadacha);

            
        }


    }
}
