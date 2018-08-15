using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public class _657JudgeRouteCircle
    {
        public bool JudgeCircle(string moves)
        {
            var result = false;
            var l = 0;
            var r = 0;
            var u = 0;
            var d = 0;
            for (int i = 0; i < moves.Length; i++)
            {
                if (moves[i] == 'L' || moves[i] == 'l')
                {
                    l++;
                }
                if (moves[i] == 'r' || moves[i] == 'R')
                {
                    r++;
                }
                if (moves[i] == 'u' || moves[i] == 'U')
                {
                    u++;
                }
                if (moves[i] == 'd' || moves[i] == 'D')
                {
                    d++;
                }
            }
            if (l == r && u == d) { result = true; }
            else { result = false; }

            return result;
        }
    }

}
