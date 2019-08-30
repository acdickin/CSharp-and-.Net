using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Properties
{
    class Program
    {
        static void Main(string[] args)
        {
            Player player = new Player();
            for (int i=0 ; i<20; i++)
            {
                player.Hit();
                Console.WriteLine("Is Player Alive:" + player.IsAlive);
            }
            Console.ReadLine();
        }
    }
    class Player
    {
        public bool IsAlive
        {
            get { return Health > 0; }
        }
        // can only be set in this class
        public int Health { get; private set; } = 100;

        
        public void Hit()
        {
            Random r = new Random();
            Health -= r.Next(5, 50);
        }
        // replaced by property
        //public void CheckDeath()
        //{
        //    if (health <= 0) isAlive = false;
        //}
    }
}
