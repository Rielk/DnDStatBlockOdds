using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DnDStatBlockOdds
{
    public class Dice
    {
        public DiceValue[] Values { get; }

        public Dice(params int[] values)
        {
            var odds = 1 / values.Length;
            Values = values.Select(x => new DiceValue(x, odds)).ToArray();
        }

        public Dice(params DiceValue[] values)
        {
            Values = values;

            double TotalWeight = 0;
            foreach (var value in values)
                TotalWeight += value.Odds;

            for(int i = 0; i < Values.Length; i++)
                Values[i].Odds /= TotalWeight;
        }
    }

    public struct DiceValue
    {
        public DiceValue(int value, double odds)
        {
            Value = value;
            Odds = odds;
        }

        public int Value { get; set; }
        public double Odds { get; set; }
    }
}
