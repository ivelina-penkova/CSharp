namespace Ex2_Abstraction.Characters
{
    using Interfaces;

    abstract class Character:IAttack;
    {
        private int health;
        private int mana;
        private int damage;


        public abstract void Attack(Character target);
    }
}
