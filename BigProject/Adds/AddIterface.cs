using System;
using System.Collections.Generic;
using System.Text;
using BigProject.Adds;
using BigProject.Services;
using BigProject.Validator;
using BigProject.Save;
using BigProject.Events;

namespace BigProject.Adds
{
    public interface AddIterface<T>
    {
        public T Add(T model);
    }
}
