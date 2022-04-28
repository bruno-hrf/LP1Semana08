namespace GameUnits
{
    class MilitaryUnit : Unit
    {
        public int AttackPower  { get; }
        public int XP {get;set; }

        public MilitaryUnit(int movement, int health) : base(movement, health)
        {

        }

        public  void Attack (Unit u );
    }
}