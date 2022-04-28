using System;

namespace GameUnits
{
    class Unit
    {
        private int movement;
        public int health { get; set; }

        public Unit (int movement, int health)
        {
            this.movement = movement;
            this.health = health;
        }

        public virtual void Move ( Vector2 v )
        {

        }

    }
}
