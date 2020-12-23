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
    public interface ILogger
    {
        public delegate void Log(string writeinfo);
        public event Log Newl;
    }
}
