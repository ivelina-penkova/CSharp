namespace Battleships.Ships
{
    using System;

    public class Warship : Battleship, IAttack
    {
        private string name;
        private double lengthInMeters;
        private double volume;

        public Warship(string name, double lengthInMeters, double volume):base(name, lengthInMeters, volume)
        {
        }

        public override string Attack(Ship target)
        {
            this.DestroyTarget(target);
            return "We bombed them from the sky!";
        }
    }
}
