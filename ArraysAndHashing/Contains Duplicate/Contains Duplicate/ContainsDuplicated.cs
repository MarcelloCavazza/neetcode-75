using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Contains_Duplicate
{
    internal class ContainsDuplicated
    {
        public static Boolean ContainsDuplicate(int[] numberList)
        {
            List<int> result = new List<int>();
            int actualNumber = 0;
            for (int i = 0; i < numberList.Length; i++)
            {
                actualNumber = numberList[i];
                result = numberList.Where(x => x == 1).ToList();
               if(result.Count() > 1) return true;
            }
            return false;
        }
    }
}

