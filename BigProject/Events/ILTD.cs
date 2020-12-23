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
    public interface ILTD
    {
        public void LogData(string writeinfo);
    }
}
