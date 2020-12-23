using System;
using System.Collections.Generic;
using System.Text;
using BigProject.Adds;
using BigProject.Services;
using BigProject.Validator;
using System.Text.RegularExpressions;
using BigProject.Save;
using BigProject.Events;

namespace BigProject.Validator
{
    public class PayValidator : IShower, IValidator<Payinf>
    {
        public event IShower.Event News;
        
        public bool Check(Payinf payinf)
        {           
            bool valid = true;          

            if (payinf == null)
            {                               
                News?.Invoke("Вы не ввели данные.");
                valid = false;
            }

            if (!int.TryParse(payinf.idi, out int di) || payinf.idi.Length > 6)
            {               
                News?.Invoke("Введён неверный ID пользователя.");
                valid = false;
            }

            if (!double.TryParse(payinf.sofp, out double sofp1))
            {
                News?.Invoke("Введена недопустимая сумма платежа");
                valid = false;
            }
              
            if(int.TryParse(payinf.val, out int vall))
            {
                News?.Invoke("Вы ввели неверную валюту");
                valid = false;
            } 
                       
            return valid;
        }
    }
}
