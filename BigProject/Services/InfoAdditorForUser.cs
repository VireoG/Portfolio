using System;
using System.Collections.Generic;
using System.Text;
using BigProject.Adds;
using BigProject.Services;
using BigProject.Validator;
using System.IO;
using BigProject.Save;
using BigProject.Events;

namespace BigProject.Services
{
    public class InfoAdditorForUser : IShower, ILogger
    {
        public readonly IValidator<Person> validator;

        public readonly RepositoryCRUD<Person> save;

        public event IShower.Event News;
        public event ILogger.Log Newl;
        public InfoAdditorForUser(IValidator<Person> _validator, RepositoryCRUD<Person> _save)
        {
            validator = _validator;
            save = _save;
        }
        public void AddPerson(Person person)
        {          
            if (!validator.Check(person))
            {
                News?.Invoke("Валидация не была пройдена.");
                Newl?.Invoke("Валидация добавления клиента не была пройдена.");
                return;
            }
            else
            {
                News?.Invoke("Валидация прошла успешно.Файл будет записан.");
                Newl?.Invoke("Информация о клиенте прошла валидацию. Передана на запись.");
                save.Save(person);
            }
        }
    }
}
