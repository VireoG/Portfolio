using System;
using System.Collections.Generic;
using System.Text;
using BigProject.Adds;
using BigProject.Services;
using BigProject.Validator;
using BigProject.Save;
using System.IO;
using BigProject.Events;


namespace BigProject.Save
{
    public interface RepositoryCRUD<T> where T : class
    {
        public void Save(T model);

        public void Read();
    }
}
