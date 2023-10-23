namespace UnitsDrafts
{
    internal class Footman : Unit
    {
        private int _damage;

        public Footman(int damage) : base("Footman", 60, 60, 9)
        {
            _damage = damage;
        }

        public int Damage
        {
            get { return _damage; }
            set { _damage = value; }
        }


        public void InflictDamage(Unit unit)
        {
            unit.Health -= _damage;
        }

    }
}
