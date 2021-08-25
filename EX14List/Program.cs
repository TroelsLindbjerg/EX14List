using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX14List
{
    class Program
    {
        static void Main(string[] args)
        {
            //opg14

            //14.1
            //Liste med alder :int
            List<int> ages = new List<int>();
            ages.Add(5);
            ages.Add(17);
            ages.Add(20);
            ages.Add(40);
            ages.Add(51);
            //Liste med navne :string
            List<string> names = new List<string>();
            names.Add("Jens");
            names.Add("Karl");
            names.Add("Johannes");
            names.Add("Anton");
            names.Add("Nicklas");

            //14.2
            //Liste med procenter :double
            List<double> percentages = new List<double>() { 0.75, 0.23, 0.86, 0.17 };
            //Liste med giftede :bool
            List<bool> areMarried = new List<bool>() { true, false, false, true, true };

            //14.3
            //Alder
            for (int i = 0; i < ages.Count; i++)
            {
                Console.WriteLine(ages[i]);
            }
            Console.WriteLine("");
            //Navne
            for (int i = 0; i < names.Count; i++)
            {
                Console.WriteLine(names[i]);
            }
            Console.WriteLine("");
            //Procenter
            foreach (var item in percentages)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("");
            //Giftede
            foreach (bool item in areMarried)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("");

            //14.4
            List<string> name = new List<string>();
            name.Add("Hans");
            name.Add("Kristian");
            name.Add("Jens");
            name.Add("Karsten");
            name.Add("Ib");
            //Insert kan bruges til at tilføje  til listen.
            name.Insert(3, "Anders");
            name.Insert(2, "Lars");

            foreach (string item in name)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("");

            //14.5
            List<int> tal = new List<int>() { 13, 14, 13, 15, 13, 14, 14, 15 };
            //Remove kan bruges til at fjerne værdier fra listen.
            tal.Remove(13);
            tal.Remove(15);
            //RemoveAt kan bruges til at fjerne værdier på en bestem plads
            tal.RemoveAt(3);
            foreach (int item in tal)
            {
                Console.WriteLine(item);
            }
        }
    }
}
