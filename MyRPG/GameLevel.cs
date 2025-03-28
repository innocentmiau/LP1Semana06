using System;
using System.Collections.Generic;
using Humanizer;

namespace MyRPG
{
    public class GameLevel
    {

        private Hardness difficulty;
        public Hardness GetHardness() => difficulty;

        private int numberOF;
        public int GetNumRooms() => numberOF;
        
        private List<Enemy> enemies;
        private int actualEnemies = 0;
        public int GetNumEnemies() => actualEnemies;
        
        public GameLevel(int numberOF, Hardness difficulty)
        {
            this.difficulty = difficulty;
            this.numberOF = numberOF;
            enemies = new List<Enemy>();
            for (int i = 0; i < numberOF; i++)
            {
                enemies.Add(null);
            }
        }

        public void SetEnemyInRoom(int numberOF, Enemy enemy)
        {
            if (enemies[numberOF] != null) return;
            enemies[numberOF] = enemy;
            actualEnemies++;
        }

        public void PrintEnemies()
        {
            foreach (Enemy enemy in enemies)
            {
                if (enemy == null) continue;
                int index = enemies.IndexOf(enemy);
                Console.WriteLine($"Room {index.ToRoman()}: {enemy.GetName()}");
            }
            // Room I: Worf
            // Room VII: Picard
            // Room XVI: Data
            // Room LIX: Troi
            // Room XCIV: Riker
        }
        
    }
}