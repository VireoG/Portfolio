using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using BigProject.Adds;
using BigProject.Services;
using BigProject.Validator;
using BigProject.Save;
using BigProject.Events;

namespace BigProject.Validator
{
    public class UserValidator : IShower, IValidator<Person>
    {
        private const string NameTemplate = @"[a-zA-Zа-яА-я\w]";
        private const string AddressTemplate = @"(\w*)";
        private readonly Regex NameRegex;
        private readonly Regex Address;

        public event IShower.Event News;
        public UserValidator()
        {
            NameRegex = new Regex(NameTemplate, RegexOptions.Compiled | RegexOptions.IgnoreCase);
            Address = new Regex(AddressTemplate, RegexOptions.Compiled | RegexOptions.IgnoreCase);
        }    
        public bool Check(Person person)
        {                  
            bool valid = true;

            if (person == null)
            {
                News?.Invoke("Вы не ввели данные.");
                valid = false;
            }

            if (!int.TryParse(person.id, out int di) || person.id.Length > 6)
            {
                News?.Invoke("Введён неверный ID пользователя.");
                valid = false;
            }

            if (person.Name.Length < 2 || person.Name.Length > 32 || !NameRegex.IsMatch(person.Name))
            {
                News?.Invoke("Вы ввели недопустимое имя.");
                valid = false;
            }

            if (DateTime.TryParse(person.dateB, out DateTime date))
            {
                var age = DateTime.Now.Year - date.Year;
                if (age < 1 || age > 100)
                {
                    News?.Invoke("Год рождения недопустимое значение.");
                    valid = false;
                }
            }

            int Month = person.month switch
            {
                "Январь" => 31,
                "Февраль" => 28,
                "Март" => 31,
                "Апрель" => 30,
                "Май" => 31,
                "Июнь" => 30,
                "Июль" => 31,
                "Август" => 31,
                "Сентябрь" => 30,
                "Октябрь" => 31,
                "Ноябрь" => 30,
                "Декабрь" => 31,

                _ => 0
            };

            if (Month == 0)
            {
                News?.Invoke("Вы ввели неверный месяц.");
                valid = false;
            }
            
            if (!int.TryParse(person.digit, out int dig) || dig > Month || dig < 1)
            {
                News?.Invoke("Вы ввели неправильное число");
                valid = false;
            }

            if (!Address.IsMatch(person.adres))
            {             
                News?.Invoke("В вашем адресе присутствуют недопустимые символы.");
                valid = false;
            }

            return valid;
        }
    }
}
