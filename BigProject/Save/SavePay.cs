using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;
using BigProject.Adds;
using BigProject.Services;
using BigProject.Validator;
using BigProject.Save;
using System.IO;
using System.Linq;
using BigProject.Events;

namespace BigProject.Save
{
    public class SavePay : IShower, ILogger, RepositoryCRUD<Payinf>
    {
        public event IShower.Event News;
        public event ILogger.Log Newl;
<<<<<<< HEAD
=======
        public Payinf Save(Payinf payinf)
        {
            string DataPay = @"E:\ITAcademy\BigProject\BigProject\DataBaseOfPay.txt";
>>>>>>> 00ae65a44bbf19a240441059be75f2c69b6255d8

        XmlSerializer formatter;

        public SavePay()
        {
            formatter = new XmlSerializer(typeof(Payinf));
        }
        public void Read()
        {
            using (FileStream fs = new FileStream("DataBaseOfPay.xml", FileMode.OpenOrCreate))
            {
                Payinf newpay = (Payinf)formatter.Deserialize(fs);              
                Console.WriteLine($"ID плательщика: {newpay.idi};\nСпособ платежа: {newpay.sp};\nВалюта: {newpay.val};\nСумма платежа: {newpay.sofp}.");
            }

        }

        public void Save(Payinf payinf)
        {
            using (FileStream fs = new FileStream("DataBaseOfPay.xml", FileMode.OpenOrCreate))
            {
                formatter.Serialize(fs, payinf);
                News?.Invoke("Запись выполнена.\nПрограмма завершена.");
                Newl?.Invoke("Запись информации о платеже выполнена.\nПрограмма завершена.");
            }
        }
        //string DataPay = @"DataBaseOfPay.txt";

        //public void Read()
        //{
        //    string line;
        //    List<string> list = new List<string>();
        //    List<Payinf> payi = new List<Payinf>();
        //    using (StreamReader sr = new StreamReader(DataPay))
        //    {
        //        while ((line = sr.ReadLine()) == null)
        //        {
        //            list.Add(line);
        //        }
        //    }
        //    for (int i = 0; i < list.Count(); i = i + 4)
        //    {
        //        payi.Add(
        //            new Payinf
        //            {
        //                idi = list[i],
        //                sp = list[i + 1],
        //                val = list[i + 2],
        //                sofp = list[i + 3],
        //            }
        //            );
        //    }
        //    foreach (Payinf p in payi)
        //    {
        //        Console.WriteLine(p.idi);
        //        Console.WriteLine(p.sp);
        //        Console.WriteLine(p.val);
        //        Console.WriteLine(p.sofp);
        //    }
        //}
        //public void Save(Payinf payinf)
        //{
        //    using (StreamWriter swpay = new StreamWriter(DataPay))
        //    {
        //        swpay.WriteLine($"Платёж совершил клиент ID: {payinf.idi};");
        //        swpay.WriteLine($"Платёж совершён способом: {payinf.sp};");
        //        swpay.WriteLine($"Платёж совершён в валюте: {payinf.val};");
        //        swpay.WriteLine($"Сумма платежа: {payinf.sofp}.");              
        //    }

        //    News?.Invoke("Запись выполнена.\nПрограмма завершена.");
        //    Newl?.Invoke("Запись информации о платеже выполнена.\nПрограмма завершена.");
        //}
    }
}
