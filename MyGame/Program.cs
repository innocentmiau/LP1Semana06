using System;
using System.Collections.Generic;

namespace MyGame
{
    public class Program
    {
        private static void Main(string[] args)
        {
            /*
            Enemy enemy = new Enemy("ababababa");
            Console.WriteLine(enemy.GetName());

            Enemy enemy2 = new Enemy("abc");
            Console.WriteLine(enemy2.GetName());
            */

            /*
            Enemy loki = new Enemy("Loki");
            loki.SetName(" Grindalokki ");
            
            Console.WriteLine($"Name is {loki.GetName()} and HP is {loki.GetHealth()}");
            */
            List<Enemy> enemies = new List<Enemy>();
            for (int i = 0; i < int.Parse(args[0]); i++)
            {
                Console.Write($"Nome do inimigo {i+1}: ");
                string input = Console.ReadLine();
                enemies.Add(new Enemy(input));
            }
            
            foreach (Enemy enemy in enemies)
            {
                Console.WriteLine($"{enemy.GetName()} {enemy.GetHealth()} {enemy.GetShield()}");
            }
            
            enemies[0].TakeDamage(50);
            
            foreach (Enemy enemy in enemies)
            {
                Console.WriteLine($"{enemy.GetName()} {enemy.GetHealth()} {enemy.GetShield()}");
            }
            
            enemies[1].PickPowerUp(PowerUp.HEALTH, 50);
            enemies[0].PickPowerUp(PowerUp.SHIELD, 9.5f);
            
            foreach (Enemy enemy in enemies)
            {
                Console.WriteLine($"{enemy.GetName()} {enemy.GetHealth()} {enemy.GetShield()}");
            }
            
            
            Console.WriteLine($"Número de powerups usados: {Enemy.GetPowerUpCount()}");
            
        }
        
        public enum PowerUp {
            HEALTH, SHIELD
        }
    }
}
