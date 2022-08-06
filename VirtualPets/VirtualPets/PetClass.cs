using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualPets
{
    internal class PetClass
    {
        private string name { get; set; }
        private int hunger { get; set; }
        private int boredom { get; set; }
        private int thirst { get; set; }
        private int Id { get; set; }

        public PetClass(string name, int hunger, int bordom, int thirst)
        {
            this.name = name;
            this.hunger = hunger;
            this.boredom = bordom;
            this.thirst = thirst;
        }

        public void sound()
        {
            Console.WriteLine("Sound! Sound! Sound!");
        }

        public void stats()
        {
            Console.Write($"{name}: \nHunger: {hunger} \nBordom: {boredom} \nThirst: {thirst}\n");
        }

        public void feedAll()
        {
            hunger += 3;
        }

        public void feedOne()
        {
            hunger += 10;
        }

        public void waterAll()
        {
            thirst += 3;
        }

        public void waterOne()
        {
            thirst += 10;
        }

        public void playAll()
        {
            boredom += 3;
        }
        
        public void playOne()
        {
            boredom += 10;
        }

        public void timeIncrement()
        {
            hunger--;
            thirst--;
            boredom--;
        }

        public void lifeCheck()
        {
            if (hunger <= 0 || thirst <= 0 || boredom <= 0)
            {
                
               
            }
        }
    }
}
