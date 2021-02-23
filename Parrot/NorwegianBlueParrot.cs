using System;

namespace Parrot
{
    public class NorwegianBlueParrot : Parrot
    {
        private readonly bool _isNailed;
        private readonly double _voltage;

        public NorwegianBlueParrot(double voltage, bool isNailed)
        {
            _isNailed = isNailed;
            _voltage = voltage;
        }

        public override double GetSpeed()
        {
            return _isNailed ? 0 : GetBaseSpeed(_voltage);
        }
        protected double GetBaseSpeed(double voltage)
        {
            return Math.Min(24.0, voltage * GetBaseSpeed());
        }
    }
    
}