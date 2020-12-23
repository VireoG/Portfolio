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
    public class InfoAdditorForPay : IShower, ILogger
    {
        public readonly IValidator<Payinf> validator;

        public readonly RepositoryCRUD<Payinf> save;

        public event IShower.Event News;
        public event ILogger.Log Newl;
        public InfoAdditorForPay(IValidator<Payinf> _validator, RepositoryCRUD<Payinf> _save)
        {
            validator = _validator;
            save = _save;
        }

        public void AddPay(Payinf payinf)
        {           
            if (!validator.Check(payinf))
            {              
                News?.Invoke("Валидация не была пройдена.");
                Newl?.Invoke("Валидация платежа не была пройдена.");
                return;
            }
            else 
            { 
                News?.Invoke("Валидация прошла успешно.Файл будет записан.");
                Newl?.Invoke("Информация о платеже прошла валидацию. Передана на запись.");
                save.Save(payinf);
            } 
        }       
    }
}
