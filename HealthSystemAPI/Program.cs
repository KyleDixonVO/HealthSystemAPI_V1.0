using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealthSystemAPI
{
    class Program
    {
        static int health = 100;
        static int shield = 100;
        static int lives = 3;
        static int damage;
        static int hp;
        
        static void Main(string[] args)
        {



























            Console.ReadKey(true);
        }

        static void ShowHUD()
        {


        }

        static void TakeDamage(int damage)
        {
            Console.WriteLine("Player Is About To Take: " + damage + " damage");

            if (shield > 0)
            {
                shield = shield - damage;

            }
            else if (health >0)
            {
                health = health + shield - damage;
                shield = 0;
            }
            else if (health <=0)
            {
                lives--;
                if (lives >0)
                {
                    health = 100;
                }
            }
        }

        static void RngMachine()
        {
            Random rd = new Random();
            damage = rd.Next(15, 75); 
        }

        static void Heal(int hp)
        {


        }

        static void HowCloseToDead()
        {
            if (health > 0 && health < 10)
            {
                howBloodied = "Death's Door";
            }
            else if (health >= 10 && health < 50)
            {
                howBloodied = "That's a Lot of Blood";
            }
            else if (health >= 50 && health < 75)
            {
                howBloodied = "Only a Flesh Wound";
            }
            else if (health >= 75 && health < 100)
            {
                howBloodied = "Tis But a Scratch";
            }
            else if (health >= 100)
            {
                health = 100;
                howBloodied = "Flawless Health";
            }
        }
        static void RegenerateShield(int hp)
        {


        }
    }
}
