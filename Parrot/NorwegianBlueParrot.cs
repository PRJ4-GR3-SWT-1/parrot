namespace Parrot
{
    public class NorwegianBlueParrot : Parrot
    {
        public NorwegianBlueParrot(int numberOfCoconuts, double voltage, bool isNailed) : base(numberOfCoconuts,
            voltage, isNailed)
        {
        }

        public override double GetSpeed()
        {
            return _isNailed ? 0 : GetBaseSpeed(_voltage);
        }
    }
    
}