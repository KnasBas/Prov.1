using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prov_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Book b1 = new Book();
            Customer c1 = new Customer();

            while (1 > 0)
            {
                Console.WriteLine("1. Info");
                Console.WriteLine("2. GetName");
                Console.WriteLine("3. Getcategory");
                Console.WriteLine("4. Evaluate");
                Console.WriteLine("5. IsCursed");
                Console.Write("vänligen välj ett alternativ: ");

                string answer = Console.ReadLine();

                int i = 0;      // En try parse för att se till att spelaren väljer rätt alternativ

                bool result = int.TryParse(answer, out i);

                while (result == false && i > 5 && i <= 0) //En felsöknings metod
                {
                    Console.WriteLine("försök igen!");
                    answer = Console.ReadLine();
                    result = int.TryParse(answer, out i);
                }

                switch(i) //En switch med de alla olika alternativen
                {
                    case 1: b1.PrintInfo();
                        break;
                    case 2: b1.GetName();
                        break;
                    case 3: b1.GetCategory();
                        break;
                    case 4: b1.Evaluate();
                        break;
                    case 5: b1.IsCursed();
                        break;
                }
                Console.ReadLine(); //Console readline och clear för estetiska skäl
                Console.Clear();
            }

        }
    }
}
