namespace MyGame
{
    public class Enemy
    {

        
        private string name;
        public string GetName() => name;
        private float health;
        public float GetHealth() => health;
        private float shield;
        public float GetShield() => shield;

        private static int powerUpCount;
        public static int GetPowerUpCount() => powerUpCount;
        
        static Enemy()
        {
            powerUpCount = 0;
        }
        
        
        /// <summary>
        /// Set the name for your enemy.
        /// </summary>
        /// <param name="newName">The new name to be used. If bigger than 8 characters, then only the first 8 will be used.</param>
        public void SetName(string newName)
        {
            if (newName.Length > 8) newName = newName.Substring(0, 8);
            name = newName;
        }
        
        public Enemy(string name)
        {
            SetName(name);
            health = 100;
            shield = 0;
        }

        public void PickPowerUp(Program.PowerUp powerUp, float value)
        {
            powerUpCount++;
            if (powerUp == Program.PowerUp.SHIELD)
            {
                shield += value;
                return;
            }
            health += value;
        }

        public void TakeDamage(float damage)
        {
            shield -= damage;
            if (shield < 0)
            {
                float damageLeft = -shield;
                shield = 0;
                health -= damageLeft;
                if (health < 0) health = 0;
            }
        }
        
    }
}