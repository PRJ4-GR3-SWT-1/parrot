namespace Parrot
{
    public class EuropeanParrot : Parrot
    {
        public EuropeanParrot(int numberOfCoconuts, double voltage, bool isNailed) : base(numberOfCoconuts, voltage,
            isNailed)
        {
        }

        public override double GetSpeed()
        {
            return GetBaseSpeed();
        }
    }
}