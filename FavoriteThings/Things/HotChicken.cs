using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FavoriteThings.Things
{
    public class HotChicken
    {
        public string HeatLevel { get; set; }
        public int TendersCount { get; set; }
        public void CauseGlee()
        {
            Console.WriteLine("Your hot chicken is creating a sensation of glee.");
        }

        public void EatTender()
        {
            if (TendersCount > 0)
            {
                TendersCount -= 1;
                Console.WriteLine("You eat a delicious piece of hot chicken.");
            }
            else
            {
                Console.WriteLine("You have no more tenders to eat!");
            }
        }

    }
}
