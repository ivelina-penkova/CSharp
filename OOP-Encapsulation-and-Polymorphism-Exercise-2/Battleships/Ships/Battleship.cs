using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Battleships.Ships
{
    public abstract class Battleship:Ship, IAttack
    {
        public Battleship(string name, double lengthInMeters, double volume) : base(name, lengthInMeters, volume)
        {
        }

        abstract protected Ship DestroyTarget(Ship target);
        
    }

}