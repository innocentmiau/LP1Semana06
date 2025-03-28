namespace MyGame
{
    public class Enemy
    {

        private string name;
        public string GetName() => name;
        private float health;
        private float shield;
        
        public Enemy(string name)
        {
            this.name = name;
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