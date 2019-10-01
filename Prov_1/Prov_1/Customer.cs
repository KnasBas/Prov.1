using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prov_1
{
    class Customer //Denna klassen blev knappt klar på grund av tidsbegränsning
    {
        private string CustomerPreference = "";
        private int CustomerMoney = 0;

        public Customer()
        {
            List<string> ListCategory = new List<string> { "Roman", "Skräck", "Komedi" }; //Samma lista som i book 

            Random generator = new Random();

            int i = generator.Next(3); //en ny generator som slumpar bland 3 tal = 3 positioner i en lista          

            i = generator.Next(3);

            CustomerPreference = ListCategory[i]; //Här hamnar listans plats från int:en i in i category

            CustomerMoney = generator.Next(10, 21);
        }

    }
}
