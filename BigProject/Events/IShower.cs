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
    public interface IShower
    {
        public delegate void Event(string showinf);
        public event Event News;             
    }   
}
