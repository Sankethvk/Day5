using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirst
{
    class handson4
    {
        public static int Sumoflst()
        {
            List<int> lst = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            int s = 0;
            for (int i =0;i<lst.Count;i++)
            {
                if(lst[i]%2==0)
                {
                    s = s + lst[i];
                }
            }
            return s;
        }
    }
}
