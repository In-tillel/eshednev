using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Ежедневник
{
    internal class pop
    {
        public string Name { get; set; }
        public string Wh { get; set; }
        public string time { get; set; }
        public string BirthDate { get; set; }
        public pop() { }
        public void WriteEmployee()
        {
            using (StreamWriter sw = File.AppendText("SimpleNotebook.txt"))
            {
                sw.WriteLine(this.Name);
                sw.WriteLine(this.Wh);
                sw.WriteLine(this.time);
                sw.WriteLine(this.BirthDate);
            }
        }
        public static void DisplayEmployee(string name)
        {
            using (StreamReader sr = File.OpenText("SimpleNotebook.txt"))
            {
                string temp = null;
                while ((temp = sr.ReadLine()) != name && temp != null) ;
                if (temp == name)
                {
                    Console.WriteLine("День недели: " + temp);
                    Console.WriteLine(String.Format("Что нужно сделать: " + sr.ReadLine()));
                    Console.WriteLine(String.Format("Время события: " + sr.ReadLine()));
                    Console.WriteLine(String.Format("Дата События: " + sr.ReadLine()));
                }
                else
                    Console.WriteLine("Такой день не найден . .");
            }
        }
    }
}
