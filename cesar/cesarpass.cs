using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cesar
{
    public class cesarpass
    {
       

        public static string cesar(string giris)
        {
            string cikis = "";
            char[] karakter = giris.ToCharArray();
            foreach(char eleman in karakter)
            {
                cikis += Convert.ToChar(eleman + 3).ToString();
            }
            return cikis;
        }
        public static string cesardec (string giris2)
        {
            string cikis = "";
            char[] karakter2 = giris2.ToCharArray();
            foreach(char eleman2 in karakter2)
            {
                cikis += Convert.ToChar(eleman2 - 3).ToString();
            }
            return cikis;
        }

    }
}
