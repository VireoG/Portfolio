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
    [Serializable]
    public class Payinf
    {
        public string sp { get; set; }
        public string idi { get; set; }       
        public string val { get; set; }
        public string sofp { get; set; }     

        
    }
    public class AddPay : AddIterface<Payinf>
    {
        public event ILogger.Log Newl;       
        public Payinf Add(Payinf p) 
        {
            Console.WriteLine("Ввод данных платежа.");
            Newl?.Invoke("Ввод данных платежа.");

            Console.Write("Введите ID клиента:");
            p.idi = Console.ReadLine();
            Newl?.Invoke("ID клиента введён.");

            Console.WriteLine("Выберети каким спобом был совершён платёж:\n1)Безналичный рассчёт;\n2)Наличными; ");
            p.sp = Console.ReadLine();
            string sposob = p.sp switch
            {             
                "1" => "Безналичный рассчёт",
                "2" => "Наличными",
                _ => "Другой"
            };
            Newl?.Invoke("Способ платежа установлен.");

            Console.WriteLine("Укажите валюту платежа $, RYB , BYR:");
            p.val = Console.ReadLine();
            Newl?.Invoke("Валюта выбрана.");

            Console.Write("Введите сумму платежа:");
            p.sofp = Console.ReadLine();
            Newl?.Invoke("Указана сумма платежа.");

            Newl?.Invoke("Данные о платеже получены.");

            return p;
        }
    }
}
