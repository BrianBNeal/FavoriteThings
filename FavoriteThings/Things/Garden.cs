using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FavoriteThings.Things
{
    public class Garden
    {
        public int SquareFootage { get; set; } = 24;
        public List<Plant> Plants { get; set; } = new List<Plant>();
        public void AddPlant(string plant)
        {
            if (Plants == null)
            {
                Plants = new List<Plant>();
            }
            var plantToAdd = new Plant(plant, 12, "late spring", 8);
            
            Plants.Add(plantToAdd);
            Console.WriteLine($"You planted {plant} in your garden.");
        }

        public void Weed()
        {
            Console.WriteLine("You pull all the weeds from your garden.");
        }
    }
}
