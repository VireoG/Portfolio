using System;
using System.Collections.Generic;
using System.Text;
using BigProject.Adds;
using BigProject.Services;
using BigProject.Validator;
using System.Text.RegularExpressions;
using BigProject.Save;
using BigProject.Events;

namespace BigProject
{
    public interface IValidator<T> where T : class
    {
        public bool Check(T Model);
    }
}
