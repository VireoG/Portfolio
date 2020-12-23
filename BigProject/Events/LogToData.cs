using System;
using System.Collections.Generic;
using System.Text;
using BigProject.Adds;
using BigProject.Services;
using BigProject.Validator;
using System.IO;
using BigProject.Save;
using BigProject.Events;

namespace BigProject.Events
{
    public class LogToData : ILTD 
    {
        public void LogData(string writeinfo)
        {
            string Data = @"E:\ITAcademy\BigProject\BigProject\ILogger.txt";

                using (StreamWriter sw = new StreamWriter(Data, true, Encoding.Default))
                {
                    sw.WriteLine(writeinfo);  
                }
        }
    }
}
