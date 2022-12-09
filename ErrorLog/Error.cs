using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ErrorLog
{
    public class Error
    {
        public static void errorlog(Exception ec, string path)
        {
            StreamReader sr = new StreamReader(path + "/errorlog.txt");
            string preverrors = sr.ReadToEnd();
            sr.Close();
            StreamWriter sw = new StreamWriter(path + "/errorlog.txt");
            sw.WriteLine(preverrors + "\n \n Date : " + DateTime.Now.ToString() + "\n Source : " + ec.Source.ToString() + "\n Message : " + ec.Message + "\n String : " + ec.ToString() + "\n");
            sw.Close();
        }
        
    }
}
