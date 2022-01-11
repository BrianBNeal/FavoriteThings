using FavoriteThings.Things;
using System;
using System.Collections.Generic;

namespace FavoriteThings
{
    class Program
    {
        static void Main(string[] args)
        {
            Garden myGarden = new Garden();
           
            myGarden.AddPlant("peppers");
            
            
            
            Console.ReadLine();
        }
    }
}
