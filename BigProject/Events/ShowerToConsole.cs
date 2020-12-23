using System;
using System.Collections.Generic;
using System.Text;
using BigProject.Adds;
using BigProject.Services;
using BigProject.Validator;
using System.Text.RegularExpressions;
using BigProject.Save;
using BigProject.Events;

namespace BigProject.Events
{
    public class ShowerToConsole : ISTC
    {    
        public void Message(string showinf)
        {
            Console.WriteLine(showinf);
        }      
    }
}
