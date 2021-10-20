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
        static int damage = 50;
        static int hp = 25;
        static int remainder;
        static bool gameOver;
        static string howBloodied;
        static string freeTestInput;
        static void Main(string[] args)
        {


            Console.ReadKey(true);
            Console.WriteLine("Showcase of TakeDamage() modifying shield.");
            Console.WriteLine("");
            Reset();
            ShowHUD();
            TakeDamage(damage);
            ShowHUD();
            Console.ReadKey(true);
            Console.WriteLine("Showcase of TakeDamage() modifying shield and health.");
            Console.WriteLine("");
            Reset();
            ShowHUD();
            TakeDamage(damage * 3);
            ShowHUD();
            Console.ReadKey(true);
            Console.WriteLine("Showcase of TakeDamage() modifying shield, health, and lives.");
            Console.WriteLine("");
            Reset();
            ShowHUD();
            TakeDamage(damage * 4);
            ShowHUD();
            Console.ReadKey(true);
            Console.WriteLine("Showcase of TakeDamage() error checks.");
            Console.WriteLine("");
            Reset();
            ShowHUD();
            TakeDamage(-damage);
            ShowHUD();
            Console.ReadKey(true);
            Console.WriteLine("Showcase of Heal() modifying health from full.");
            Console.WriteLine("");
            Reset();
            ShowHUD();
            Heal(25);
            ShowHUD();
            Console.ReadKey(true);
            Console.WriteLine("Showcase of Heal() modifying health from half full.");
            Console.WriteLine("");
            Reset();
            ShowHUD();
            TakeDamage(damage * 3);
            ShowHUD();
            Heal(hp);
            ShowHUD();
            Console.ReadKey(true);
            Console.WriteLine("Showcase of Heal() error checks.");
            Console.WriteLine("");
            Reset();
            ShowHUD();
            Heal(-hp);
            ShowHUD();
            Console.ReadKey(true);
            Console.WriteLine("Showcase of RegenerateShield() modifying shield from full.");
            Console.WriteLine("");
            Reset();
            ShowHUD();
            RegenerateShield(hp);
            ShowHUD();
            Console.ReadKey(true);
            Console.WriteLine("Showcase of RegenerateShield() modifying shield from half.");
            Console.WriteLine("");
            Reset();
            ShowHUD();
            TakeDamage(damage);
            RegenerateShield(hp);
            ShowHUD();
            Console.ReadKey(true);
            Console.WriteLine("Showcase of RegenerateShield() error checks.");
            Console.WriteLine("");
            Reset();
            ShowHUD();
            RegenerateShield(-hp);
            ShowHUD();
            Console.ReadKey(true);
            Console.WriteLine("Showcase of range checking lives.");
            Reset();
            ShowHUD();
            TakeDamage(200);
            ShowHUD();
            TakeDamage(200);
            ShowHUD();
            TakeDamage(200);
            ShowHUD();
            Console.ReadKey(true);


            Console.WriteLine("");
            Console.WriteLine("This is the end of the hard coded showcase, to continue to test freely press '~'");
            Console.WriteLine("Hit any other key to exit");
            Console.ReadKey(true);
            if (Console.ReadKey(true).Key == ConsoleKey.Oem3)
            {
                Console.WriteLine("");
                Console.WriteLine("Type 'Escape' to exit this program");
                Console.WriteLine("Type 'Help' for list of functions");
                testingLoop(); 
            }

        }

            static void testingLoop()
            {
 
                Console.WriteLine("");
                Console.WriteLine("Take what action?");
                freeTestInput = Console.ReadLine();

                if (freeTestInput == "Help")
                {
                    //Console.WriteLine(" DamageRNG - Generates a random damage value between 1 and 100.");
                    Console.WriteLine(" Heal - Restores health equal to the 'hp' value. Range checks health and hp.");
                    Console.WriteLine(" HealRNG - Randomly assigns one of three values to hp: 25, 50, 100.");
                    Console.WriteLine(" RegenerateShield - Restores shield equal to the 'hp' value. Range checks shields and hp.");
                    Console.WriteLine(" Reset - Sets health, shields, and lives back to their inital values: 100, 100, 3.");
                    Console.WriteLine(" Respawn - Sets healh and shields to 100, range checks lives.");
                    Console.WriteLine(" SetDamageVariable - Opens prompt to set damage value. Value must be an integer.");
                    Console.WriteLine(" SetHealthVariable - Opens prompt to set health value. Value must be an integer.");
                    Console.WriteLine(" SetHpVariable - Opens prompt to set hp value. Value must be an integer.");
                    Console.WriteLine(" SetLivesVariable - Opens prompt to set lives value. Value must be an integer");
                    Console.WriteLine(" SetShieldVariable - Opens prompt to set shield value. Value must be an integer");
                    Console.WriteLine(" ShowHUD - Shows HUD.");
                    Console.WriteLine(" TakeDamage - Deals damage to the player, starting with shields and spilling over to health.");
                    testingLoop();
                }
                else if (freeTestInput == "DamageRNG")
                {
                    DamageRNG();
                    testingLoop();
                }
                else if (freeTestInput == "Heal")
                {
                    Heal(hp);
                    testingLoop();
                }
                else if (freeTestInput == "HealRNG")
                {
                    HealRNG();
                    testingLoop();
                }
                else if (freeTestInput == "RegenerateShield")
                {
                    RegenerateShield(hp);
                    testingLoop();
                }
                else if (freeTestInput == "Reset")
                {
                    Reset();
                    testingLoop();
                }
                else if (freeTestInput == "Respawn")
                {
                    Respawn();
                    testingLoop();
                }
                else if (freeTestInput == "SetDamageVariable")
                {
                    SetDamageVariable();
                    testingLoop();
                }
                else if (freeTestInput == "SetHealthVariable")
                {
                    SetHealthVariable();
                    testingLoop();
                }
                else if (freeTestInput == "SetHpVariable")
                {
                    SetHpVariable();
                    testingLoop();
                }
                else if (freeTestInput == "SetLivesVariable")
                {
                    SetLivesVariable();
                    testingLoop();
                }
                else if (freeTestInput == "SetShieldVariable")
                {
                    SetShieldVariable();
                    testingLoop();
                }
                else if (freeTestInput == "ShowHUD")
                {
                    ShowHUD();
                    testingLoop();
                }
                else if (freeTestInput == "TakeDamage")
                {
                    TakeDamage(damage);
                    testingLoop();
                }
                else if (freeTestInput == "Escape")
                {

                }
                else
                {
                    Console.WriteLine("**Command Not Recognized**");
                    testingLoop();
                }

            }

       
        
        static void ShowHUD()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("");
            Console.WriteLine("-------------------------------");
            Console.WriteLine("Lives: " + lives);
            Console.WriteLine("Shield: " + shield);
            Console.WriteLine("Health: " + health + "%");
            HowCloseToDead();
            Console.WriteLine(howBloodied);
            Console.WriteLine("-------------------------------");
            Console.WriteLine("");
            Console.ResetColor();
        }

        static void TakeDamage(int damage)
        {
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("Debug: Player Is About To Take: " + damage + " damage.");
            if (damage >= 0)
            {
                Console.WriteLine("Debug: Player Took: " + damage + " damage.");
                if (shield > 0)
                {
                    shield = shield - damage;
                    remainder = shield;

                }

                if (health > 0 && shield <= 0)
                {
                    health = health + remainder;
                    shield = 0;
                }

                if (health <= 0)
                {
                    Console.WriteLine("Player Lost A Life.");
                    lives--;
                    if (lives > 0)
                    {
                        Respawn();
                    }
                    else
                    {
                        Console.WriteLine("Out Of Lives!");
                        gameOver = true;
                    }
                }
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.White;
                Console.BackgroundColor = ConsoleColor.Red;
                Console.WriteLine("****The value of damage must be '0' or a positive integer!****");
            }
            Console.ResetColor();
        }

        static void Respawn()
        {
            health = 100;
            shield = 100;
            Console.WriteLine("Debug: Player Respawned.");
            if (lives > 99)
            {
                lives = 99;
            }

            if (lives < 0)
            {
                lives = 0;
            }
        }

        static void DamageRNG()
        {
            Random rd = new Random();
            damage = rd.Next(1, 100);
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

        static void SetHpVariable()
        {
            Console.WriteLine("Debug: Enter the value of hp. (integer)");
            string input = Console.ReadLine();
            bool isHPInteger = int.TryParse(input, out int resultHP);
            if (isHPInteger == true)
            {
                hp = resultHP;
                Console.WriteLine("Debug: Set hp to: " + hp);
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.White;
                Console.BackgroundColor = ConsoleColor.Red;
                Console.WriteLine("****Invalid Input: input must be an integer!****");
                SetHpVariable();
            }
            Console.ResetColor();
        }


        static void SetDamageVariable()
        {
            Console.WriteLine("Debug: Enter the value of damage. (integer)");
            string input = Console.ReadLine();
            bool isDamageInteger = int.TryParse(input, out int resultDamage);
            if (isDamageInteger == true)
            {
                damage = resultDamage;
                Console.WriteLine("Debug: Set damage to: " + damage);
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.White;
                Console.BackgroundColor = ConsoleColor.Red;
                Console.WriteLine("****Invalid Input: input must be an integer!****");
                SetDamageVariable();
            }
            Console.ResetColor();
        }

        static void SetHealthVariable()
        {
            Console.WriteLine("Debug: Enter the value of health. (integer)");
            string input = Console.ReadLine();
            bool isHealthInteger = int.TryParse(input, out int resultHealth);
            if (isHealthInteger == true)
            {
                health = resultHealth;
                Console.WriteLine("Debug: Set health to: " + health);
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.White;
                Console.BackgroundColor = ConsoleColor.Red;
                Console.WriteLine("****Invalid Input: input must be an integer!****");
                SetHealthVariable();
            }
            Console.ResetColor();
        }


        static void SetShieldVariable()
        {
            Console.WriteLine("Debug: Enter the value of shield. (integer)");
            string input = Console.ReadLine();
            bool isShieldInteger = int.TryParse(input, out int resultShield);
            if (isShieldInteger == true)
            {
                shield = resultShield;
                Console.WriteLine("Debug: Set shield to: " + shield);
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.White;
                Console.BackgroundColor = ConsoleColor.Red;
                Console.WriteLine("****Invalid Input: input must be an integer!****");
                SetHealthVariable();
            }
            Console.ResetColor();
        }
        static void SetLivesVariable()
        {
            Console.WriteLine("Debug: Enter the value of lives. (integer)");
            string input = Console.ReadLine();
            bool isLivesInteger = int.TryParse(input, out int resultLives);
            if (isLivesInteger == true)
            {
                lives = resultLives;
                Console.WriteLine("Debug: Set lives to: " + lives);
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.White;
                Console.BackgroundColor = ConsoleColor.Red;
                Console.WriteLine("****Invalid Input: input must be an integer!****");
                SetHealthVariable();
            }
            Console.ResetColor();
        }

        static void Heal(int hp)
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Debug: Player is about to be healed for: " + hp + " hitpoints.");
            if (hp >= 0)
            {
                int healthBefore = health;
                health = health + hp;

                if (health > 100)
                {
                    health = 100;
                }
                int healthAfter = health;
                Console.WriteLine("Debug: Healed for: " + (healthAfter - healthBefore) + " hitpoints.");

                if (health == 100)
                {
                    Console.WriteLine("Debug: Player cannot be further healed.");
                }
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.White;
                Console.BackgroundColor = ConsoleColor.Red;
                Console.WriteLine("****The value of 'hp' must be zero, or a positive integer!****");
            }
            Console.ResetColor();
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
            {
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.WriteLine("Debug: Shield is about to be restored by: " + hp + " hitpoints.");
                if (hp >= 0)
                {
                    int shieldBefore = shield;
                    shield = shield + hp;

                    if (shield > 100)
                    {
                        shield = 100;
                    }
                    int shieldAfter = shield;
                    Console.WriteLine("Debug: Restored by: " + (shieldAfter - shieldBefore) + " hitpoints.");

                    if (shield == 100)
                    {
                        Console.WriteLine("Debug: Shield cannot be further restored.");
                    }

                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.WriteLine("****The value of 'hp' must be zero, or a positive integer!****");
                }
                Console.ResetColor();
            }

        }

        static void Reset()
        {
            health = 100;
            shield = 100;
            lives = 3;
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.BackgroundColor = ConsoleColor.Cyan;
            Console.WriteLine("****Game Reset.****");
            Console.ResetColor();
        }

    }

}
