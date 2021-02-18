﻿using System;

namespace Parrot
{
    public abstract class Parrot
    {
        protected readonly bool _isNailed;
        protected readonly int _numberOfCoconuts;
        protected readonly double _voltage;

        protected Parrot(int numberOfCoconuts, double voltage, bool isNailed)
        {
            _numberOfCoconuts = numberOfCoconuts;
            _voltage = voltage;
            _isNailed = isNailed;
        }

        public abstract double GetSpeed();


        protected double GetBaseSpeed(double voltage)
        {
            return Math.Min(24.0, voltage * GetBaseSpeed());
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

    public class AfricanParrot : Parrot
    {
        public AfricanParrot(int numberOfCoconuts, double voltage, bool isNailed) : base(numberOfCoconuts, voltage,
            isNailed)
        {
        }

        public override double GetSpeed()
        {
            return Math.Max(0, GetBaseSpeed() - GetLoadFactor() * _numberOfCoconuts);
        }
    }

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