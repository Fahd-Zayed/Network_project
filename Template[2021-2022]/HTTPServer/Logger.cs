﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace HTTPServer
{
    class Logger
    {
        static StreamWriter stream = new StreamWriter("log.txt");
        public static void LogException(Exception ex)
        {
            // TODO: Create log file named log.txt to log exception details in it
            //Datetime:
            //message:
            // for each exception write its details associated with datetime 
            stream.WriteLine(" Date Time : " + DateTime.Now + "\n");
            stream.WriteLine(" Message : " + ex.Message + "\n\n");
                
        }
    }
}
