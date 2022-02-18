using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DnDStatBlockOdds
{
    public class StatBlock
    {
        public uint[] Stats { get; set; } = new uint[6];

        public StatBlock(uint q, uint w, uint e, uint r, uint t, uint y)
        {
            Stats = new uint[] { q, w, e, r, t, y };
        }

        public static bool operator <(StatBlock l, StatBlock r)
        {
            bool equal = true;
            Array.Sort(l.Stats); Array.Sort(r.Stats);
            for (int i = 0; i < 6; i++)
            {
                if (l.Stats[i] > r.Stats[i]) return false;
                if (l.Stats[i] != r.Stats[i]) equal = false;
            }
            return !equal;
        }

        public static bool operator >(StatBlock l, StatBlock r)
        {
            bool equal = true;
            Array.Sort(l.Stats); Array.Sort(r.Stats);
            for (int i = 0; i < 6; i++)
            {
                if (l.Stats[i] < r.Stats[i]) return false;
                if (l.Stats[i] != r.Stats[i]) equal = false;
            }
            return !equal;
        }
    }
}
