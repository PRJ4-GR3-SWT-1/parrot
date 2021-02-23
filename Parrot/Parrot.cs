using System;

namespace Parrot
{
    public abstract class Parrot
    {

        public virtual double GetSpeed()
        {
            throw new NotImplementedException();
        }


        

        protected double GetLoadFactor()
        {
            return 9.0;
        }

        protected double GetBaseSpeed()
        {
            return 12.0;
        }
    }
}