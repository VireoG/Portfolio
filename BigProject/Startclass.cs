using System;
using System.Collections.Generic;
using BigProject.Adds;
using BigProject.Services;
using BigProject.Validator;
using BigProject.Save;
using BigProject.Events;

namespace BigProject
{
    public class Startclass
    {
        static readonly Container container;    
        static Startclass()
        {
            container = new Container();
        }
        public static void Main()
        {                       
            do
            {
                Console.WindowWidth = 100;
                Console.WriteLine("\n<Приложение для добавления информации о клиентах и их операциях>\n");

                Console.WriteLine("-Ввести платёж клиента -> введите 1;\n-Добавить в базу нового клиента -> 2;\n" +
                    "-Просмотреть клиентов -> введите 3;\n-Просмотреть платежи -> введите 4;\n-Закрыть программу -> Любой другой символ.");
                string od = Console.ReadLine();

                switch (od)
                {
                    case "1":                        
                        var payinf = new Payinf();
                        var pay = container.PayReader.Add(payinf);
                        container.Iafp.AddPay(pay);                   
                        break;
                    case "2": 
                        var person = new Person();
                        var pers = container.UserReader.Add(person);
                        container.Iafu.AddPerson(pers);
                        break;
                    case "3":
                        SaveUser shareu = new SaveUser();
                        shareu.Read();
                        break;
                    case "4":
                        SavePay sharep = new SavePay();
                        sharep.Read();
                        break;
                    default:
                        Console.WriteLine("Программа завершена.");
                        break;
                }
            } while (true);
        }
    }
}
