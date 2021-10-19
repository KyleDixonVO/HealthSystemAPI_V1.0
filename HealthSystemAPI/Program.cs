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
        static bool gameOver;
        static string howBloodied;
        static void Main(string[] args)
        {
            while (gameOver == false)
            {
                ShowHUD();
                SetHPVariable();
                Heal(hp);
            }

























            Console.ReadKey(true);
        }

        static void ShowHUD()
        {
            Console.WriteLine("-------------------------------");
            Console.WriteLine("Lives: " + lives);
            Console.WriteLine("Shield: " + shield);
            Console.WriteLine("Health: " + health + "%");
            HowCloseToDead();
            Console.WriteLine(howBloodied);
            Console.WriteLine("-------------------------------");

        }

        static void TakeDamage(int damage)
        {
            Console.WriteLine("Player Is About To Take: " + damage + " damage");

            if (shield > 0)
            {
                shield = shield - damage;

            }
            else if (health > 0 && shield <= 0)
            {
                health = health + shield - damage;
                shield = 0;
            }
            else if (health <= 0)
            {
                lives--;
                if (lives > 0)
                {
                    Respawn();
                }
                else
                {
                    gameOver = true;
                }
            }
        }

        static void Respawn()
        {
            health = 100;
            shield = 100;
        }

        static void DamageRNG()
        {
            Random rd = new Random();
            damage = rd.Next(40, 60);
        }

        static void HealRNG()
        {
            int[] healingAmount = new int[3];
            healingAmount[0] = 25;
            healingAmount[1] = 50;
            healingAmount[2] = 100;

            Random rd2 = new Random();
            int whichHeal = rd2.Next(0, 2);
            healingAmount[whichHeal] = hp;
        }

        static void SetHPVariable()
        {
            Console.WriteLine("Enter the value of hp. (integer)");
            string input = Console.ReadLine();
            bool isInteger = int.TryParse(input, out int result);
            if (isInteger == true)
            {
                hp = result;
                Console.WriteLine("Set hp to: " + hp);
            }
            else
            {
                Console.WriteLine("****Invalid Input: input must be an integer!****");
                SetHPVariable();
            }
        }

        static void Heal(int hp)
        {
            if (hp >= 0)
            {
                Console.WriteLine("Player is about to be healed for: " + hp + " hitpoints.");
                health = health + hp;
            }
            else
            {
                Console.WriteLine("****The value of 'hp' must be zero, or a positive integer!****");
            }

            if(health > 100)
            {
                Console.WriteLine("Player cannot be further healed.");
                health = 100;
            }  

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
            shield = shield + hp;


        }

        static void Reset()
        {
            health = 100;
            shield = 100;
            lives = 3;
            Console.WriteLine("****Game Reset.****");
        }
    }
}
