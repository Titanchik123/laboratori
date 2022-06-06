using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kursovaia
{
    internal class участник
    {
        public string Name;
        public int[]  results;
        public double srresult;
        public void CalcSr()
        {
            for (int i = 0; i < results.Length; i++)
                srresult += results[i];    
            srresult /= results.Length;
        }
    }
}
