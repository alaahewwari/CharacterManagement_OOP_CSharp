using UnityEngine;
namespace Assignment16
{
    public class Character
    {
        public string name;
        private int health;
        protected Position position;
        public int Health
        {
            get { return this.health; }
            set
            {
                if (value < 0)
                {
                    health = 0;
                }
                else if (value > 100)
                {
                    health = 100;
                }
                else
                {
                    health = value;
                }
            }
        }
        public Character() : this("No name", 100, new Position(0, 0, 0))
        {
        }
        public Character(string name, int health, Position position)
        {
            this.name = name;
            this.health = health;
            this.position = position;
        }
        public virtual void DisplayInfo()
        {
            Debug.Log("Name: " + name);
            Debug.Log("Health: " + health);
            position.PrintPosition();
        }
        public void Attack(int dammage, Character target)
        {
            target.Health -= dammage;
        }
        public void Attack(int dammage, Character target, string attackType)
        {
            Attack(dammage, target);
            Debug.Log("Attack type: " + attackType);
        }
    }
}