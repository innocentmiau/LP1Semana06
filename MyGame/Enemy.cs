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