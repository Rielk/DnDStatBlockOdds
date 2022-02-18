using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DnDStatBlockOdds
{
    public class DiceCombiner
    {
        public Dice[] Dices { get; set; }

        public DiceCombiner(params Dice[] dices)
        {
            Dices = dices;
        }

        public Dictionary<List<int>, double> Combinations()
        {
            Dictionary<List<int>, double> ret = null;
            foreach (var d in Dices)
                ret = Combinations(d, ret);
            return ret;
        }

        public Dictionary<int, double> SumHighest(int number = 0)
        {
            if (number == 0) number = Dices.Length;

            var ret = new Dictionary<int, double>();

            var result = new int[Dices.Length];
            for (int i = 0; i < result.Length; i++)
            {
                throw new NotImplementedException();
            }

            return ret;
        }
        
        private static Dictionary<List<int>, double> Combinations(Dice x)
        {
            var ret = new Dictionary<List<int>, double>();
            foreach (var v in x.Values)
                ret[new List<int>() { v.Value }] = v.Odds;
            return ret;
        }

        private static Dictionary<List<int>, double> Combinations(Dice x, Dictionary<List<int>, double> y)
        {
            if (y == null)
                return Combinations(x);

            var ret = new Dictionary<List<int>, double>();
            for (int i = 0; i < x.Values.Length; i++)
                foreach (var key in y.Keys)
                {
                    var prob = x.Values[i].Odds * y[key];
                    key.Add(x.Values[i].Value);
                    if (ret.ContainsKey(key))
                        ret[key] += prob;
                    else
                        ret[key] = prob;
                }
            return ret;
        }
    }
}
