using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BitirmeProjesi
{
    class Controls
    {
        // girilen değerlerin sayı olup olmadığını kontrol ettirir
        public bool IsNumeric(string s)
        {
            float output;
            return float.TryParse(s, out output);
        }
        // girilen değerlerin içerisinde sayı olup olmadığını kontrol etirir.
        public bool IsHaveNumeric(string s)
        {
            bool rslt = false;
            for (int i = 0; i < s.Length; i++)
            {
                if (rslt == false)
                {
                    rslt = char.IsNumber(s, i);
                }
                else
                {
                    return rslt;
                }
            }
            return rslt;
        }
    }
}
