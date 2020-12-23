using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Xml.Serialization;
using BigProject.Adds;
using BigProject.Services;
using BigProject.Validator;
using BigProject.Save;
using System.IO;
using BigProject.Events;

namespace BigProject.Save
{
    public class SaveUser : IShower, ILogger, RepositoryCRUD<Person>
    {
        public event IShower.Event News;
        public event ILogger.Log Newl;

        XmlSerializer formatter;

        public SaveUser()
        {
            formatter = new XmlSerializer(typeof(Person));
        }
        public void Read()
        {
<<<<<<< HEAD
            using (FileStream fs = new FileStream("DataBaseOfUsers.xml", FileMode.OpenOrCreate))
            {
                Person newuser = (Person)formatter.Deserialize(fs);
                Console.WriteLine($"Данные клиента ID: {newuser.id};\nФИО: {newuser.Name};\nДата рождения: {newuser.digit} {newuser.month} {newuser.dateB}г.;\nАдрес: {newuser.adres}.");
            }
        }
=======
            string Data = @"E:\ITAcademy\BigProject\BigProject\DataBaseOfUsers.txt";
>>>>>>> 00ae65a44bbf19a240441059be75f2c69b6255d8

        public void Save(Person person)
        {
            using (FileStream fs = new FileStream("DataBaseOfUsers.xml", FileMode.OpenOrCreate))
            {
                formatter.Serialize(fs, person);
                News?.Invoke("Запись выполнена.\nПрограмма завершена.");
                Newl?.Invoke("Запись выполнена информации о клиенте выполнена.\nПрограмма завершена.");
            }
        }
        //string Data = @"DataBaseOfUsers.txt";
        //public void Read()
        //{
        //    string line;
        //    List<string> list = new List<string>();
        //    List<Person> per = new List<Person>();
        //    using (StreamReader sr = new StreamReader(Data))
        //    {
        //        while ((line = sr.ReadLine()) == null)
        //        {
        //            list.Add(line);
        //        }
        //    }
        //    for (int i = 0; i < list.Count(); i = i + 4)
        //    {
        //        per.Add(
        //            new Person
        //            {
        //                id = list[i],
        //                Name = list[i + 1],
        //                dateB = list[i + 2],
        //                adres = list[i + 3],
        //            }
        //            );
        //    }
        //    foreach(Person p in per)
        //    {
        //        Console.WriteLine(p.id);
        //        Console.WriteLine(p.Name);
        //        Console.WriteLine(p.dateB);
        //        Console.WriteLine(p.adres);
        //    }

        //}
        //public void Save(Person person)
        //{
        //    using (StreamWriter sw = new StreamWriter(Data))
        //    {
        //        sw.WriteLine($"Данные клиента ID: {person.id};");
        //        sw.WriteLine($"$ФИО: {person.Name};");
        //        sw.Write($"Дата рождения: {person.digit} {person.month} {person.dateB}г.;");
        //        sw.WriteLine($"\nАдрес: {person.adres}.");
        //    }

        //    News?.Invoke("Запись выполнена.\nПрограмма завершена.");
        //    Newl?.Invoke("Запись выполнена информации о клиенте выполнена.\nПрограмма завершена.");
        //}
    }
}