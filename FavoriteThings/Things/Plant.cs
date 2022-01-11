using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FavoriteThings.Things
{
    public class Plant
    {
        public Plant(string type, int spacing, string season, int height)
        {
            Type = type;
            Spacing = spacing;
            Season = season;//added a comment
            Height = height;
        }


        public string Type { get; set; }

        public int Spacing { get; set; }

        public string Season { get; set; }
        public int Height { get; private set; }
        public void Water()
        {
            Console.WriteLine($"You have watered {Type}");
        }
        public void Grow()
        {
            Height += 1;
        }
        
    }
}
