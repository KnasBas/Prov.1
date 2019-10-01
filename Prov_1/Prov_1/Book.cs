using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prov_1
{
    class Book
    {
        public int price = 0;                   // Public
        private string name;                    // Private parameterar
        private int rarity = 0;                 // 
        private string category = "";           //
        private int actualValue = 0;            //
        private bool cursed = false;            //

        public Book()
        {
            Random generator = new Random();

            actualValue = generator.Next(1, 11);       //Här skapar jag en random generator för konstruktorn för att få olika värden för de olika parameterarna

            rarity = generator.Next(1, 11); //Generatorn slumpar mella 1 - 10

            int i = generator.Next(10); //tillfällig parameter (0 - 9)

            if(i <= 5) //Detta gör att det är en 50/50 chans att cursed blir true eftersom generatorn slumpar mellan 0 - 9 så är 5 på mitten
            {
                cursed = true;
            }

            List<string> ListName = new List<string> { "Döden", "Mysterium", "Slottet" }; //två listor
            List<string> ListCategory = new List<string> { "Roman", "Skräck", "Komedi" };

            i = generator.Next(3); //en ny generator som slumpar bland 3 tal = 3 positioner i en lista

            name = ListName[i]; //Här hamnar listans plats från int:en i in i name

            i = generator.Next(3);

            category = ListCategory[i]; //Här hamnar listans plats från int:en i in i category

        }

        public void PrintInfo() //Print info använder enbart console.writlines eftersom den ska skriva ut de nämnda parameterarna till spelaren
        {
            Console.WriteLine("Namn: " + name);
            Console.WriteLine("Kategori: " + category);
            Console.WriteLine("Rarity; " + rarity);
            Console.WriteLine("Pris: " + price);
        }

         public int Evaluate()
         {
            int actualPrice = price * rarity; //Här multipliceras price och rarity för "rätt pris"

            Random generator = new Random(); //en ny generator för procentsatserna

            int RandomProcent = generator.Next(5, 15); //genratorn är mellan 5 - 15 eftersom den inte kan hantera decimaler

            RandomProcent = RandomProcent / 10; //här blir RandomProcent till ett decimal tal

            actualPrice = actualPrice * RandomProcent; //Här multipliceras acutalprice med randomprocent
            //Detta funkar dock inte eftersom Metoden och parameternarna inte är floats vilket gör att int:en tar närmsta heltal istället.

            return actualPrice; //returnernar värdet
         }

        public string GetCategory()
        {
            Console.WriteLine(category); //Skriver kategorin
            return category;
        }

        public string GetName()
        {
            Console.WriteLine(name); //skriver namnet
            return name;
        }

        public bool IsCursed()
        {
            Random generator = new Random();

            int RandomCurse = generator.Next(1, 11); //En generator mellan 1 - 10

            if (RandomCurse == 1 || RandomCurse == 2) //Här en if-sats som beror på ifall randomcurse är 1 eller 2 helt enkelt 20%
            {
                if(cursed == true) // Detta gör att ifall cursed är true så blir den false
                {
                    cursed = false;
                }
                else //detta gör ifall den kommer in false så blir den true;
                {
                    cursed = true;
                }
            }

            Console.WriteLine(cursed); //För att se vilken curse det finns för nuvarndet

            return cursed;
        }

    }
}
