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
    public class Person
    {
        public string id { get; set; }
        public string Name { get; set; }
        public string dateB { get; set; }
        public string month { get; set; }
        public string digit { get; set; }
        public string adres { get; set; }

        
    }
    public class ProPers : AddIterface<Person>
    {     
        public event ILogger.Log Newl;
        public Person Add(Person pers)
        {
               
            Console.WriteLine("Добавление нового клиента в базу.");
            Newl?.Invoke("Добавление нового клиента в базу.");

            Console.Write("Введите ID клиента:");
            pers.id = Console.ReadLine();          
            Newl?.Invoke("ID был введён.");

            Console.Write("\nВведите ФИО:");
            pers.Name = Console.ReadLine();           
            Newl?.Invoke("ФИО получено.");

            Console.Write("\nВведите дату рождения:".PadLeft(10));
            Console.Write("\nВведите Год:");
            pers.dateB = Console.ReadLine();
           
            Console.Write("\nВведите Месяц:");
            pers.month = Console.ReadLine();

            Console.Write("\nВведите Число:");
            pers.digit = Console.ReadLine();
            Newl?.Invoke("Дата рождения получена.");

            Console.Write("\nВведите адрес:");
            pers.adres = Console.ReadLine();
            Newl?.Invoke("Адрес прописки введён.");

            Newl?.Invoke("Данные о клиенте получены.");

            return pers;
        }
    }
}

