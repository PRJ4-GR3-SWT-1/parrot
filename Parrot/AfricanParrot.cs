using System;

namespace Parrot
{
    public class AfricanParrot : Parrot
    {

        private readonly int _numberOfCoconuts;
        public AfricanParrot(int numberOfCoconuts)
        {
            _numberOfCoconuts = numberOfCoconuts;
        }

        public override double GetSpeed()
        {
            return Math.Max(0, GetBaseSpeed() - GetLoadFactor() * _numberOfCoconuts);
        }
    }
}