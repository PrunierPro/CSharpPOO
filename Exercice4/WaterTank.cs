using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercice4
{
    internal class WaterTank
    {
        private static int TankAmount { get; set; } = 0;
        public int ID { get; private set; }
        public int BaseWeight { get; private set; }
        public int MaxVolume { get; private set; }
        public int FillLevel { get; private set; }
        public static int TotalVolume { get; private set; }

        public WaterTank(int baseWeight = 10, int maxVolume = 10, int initialFillLevel = 0)
        {
            TankAmount++;
            ID = TankAmount;
            BaseWeight = baseWeight;
            MaxVolume = maxVolume;
            FillLevel = initialFillLevel;
        }

        public void ShowWeight()
        {
            Console.WriteLine($"Total weight of water tank {ID} : {BaseWeight + FillLevel}");
        }

        public void ShowFillLevel()
        {
            Console.WriteLine($"Water amount in water tank {ID} : {FillLevel}");
        }

        public static void ShowTotalVolume()
        {
            Console.WriteLine($"Water amount in all water tanks : {TotalVolume}");
        }

        public void Fill(int waterLevel)
        {
            int newAmount = FillLevel + waterLevel;
            int overflow;
            if(newAmount <= MaxVolume)
            {
                FillLevel = newAmount;
                overflow = 0;
            } else
            {
                FillLevel = MaxVolume;
                overflow = newAmount - MaxVolume;
            }
            Console.WriteLine($"Amount of water in water tank {ID} after adding {waterLevel} litres : {FillLevel}/{MaxVolume}");
            if(overflow > 0) Console.WriteLine($"Excess water retrieved : {overflow}");
        }

        public void Empty(int amount)
        {
            int retrieved;
            if(amount <= FillLevel)
            {
                FillLevel -= amount;
                retrieved = amount;
            } else
            {
                retrieved = FillLevel;
                FillLevel = 0;
            }
            Console.WriteLine($"Amount of water in water tank {ID} after attempting to retrieve {amount} litres :  {FillLevel}/{MaxVolume}");
            Console.WriteLine($"Amount retrieved : {retrieved}");
        }

        public static void ResetTankAmount()
        {
            TankAmount = 0;
        }
    }
}
