using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace HTTPServer
{
    class Logger
    {
        public static void LogException(Exception ex)
        {
            // TODO: Create log file named log.txt to log exception details in it
            FileStream fs = new FileStream("C:\\Template[2021-2022]\\HTTPServer\\bin\\Debug\\log.txt", FileMode.OpenOrCreate);

            StreamWriter SW = new StreamWriter(fs);
            //Datetime:
            //message:
            // for each exception write its details associated with datetime
            string[] Deatiles = { ex.Message, DateTime.Now.ToString() + "\r\n" };
            SW.WriteLine(Deatiles);
            fs.Close();
        }
    }
}