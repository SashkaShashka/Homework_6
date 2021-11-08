using System;
using System.Collections.Generic;
using System.Text;

namespace Task_3
{
    class Tank
    {
        static public Action<uint,uint> Action { get; set; }

        readonly uint maxVolume;
        public uint CurrentVolume { get; private set; }
        public void Add(uint liters)
        {
            if (liters <= maxVolume-CurrentVolume)
            {
                CurrentVolume += liters;
                Action?.Invoke(CurrentVolume, maxVolume);
            }
            else
                throw new TankOverflowException("В цистерне не хватает места",maxVolume-CurrentVolume);
        }
        public void Take(uint liters)
        {
            if (liters < 0)
                throw new ArgumentException("Значение не может быть отрицательным");
            if (liters <= CurrentVolume)
            {
                CurrentVolume -= liters;
                Action?.Invoke(CurrentVolume, maxVolume);
            }
            else
                throw new NotEnoughException("В цистерне недостаточно безнина", CurrentVolume);
        }
        public Tank(uint maxVolume)
        {
            this.maxVolume = maxVolume;
        }
    }
}
