using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UPLab1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Factory> FactoryList = new List<Factory>();
            while (true)
            {
                Console.WriteLine("1. добавить новый");
                Console.WriteLine("2. Вывести всё");
                ConsoleKeyInfo PressedKey = Console.ReadKey();
                if(PressedKey.KeyChar == '1')
                {
                    Console.WriteLine("Введите имя: ");
                    string Name = Console.ReadLine();
                    Console.WriteLine("Введите Адресс: ");
                    string Adress = Console.ReadLine();
                    Console.WriteLine("Введите год основания: ");
                    int Year = Convert.ToInt32(Console.ReadLine());
                    FactoryList.Add(new Factory(Name, Adress, Year));
                    Console.Clear();
                }
                if(PressedKey.KeyChar == '2')
                {
                    for(int i = 0; i < FactoryList.Count; i++)
                    {
                        Console.WriteLine("Имя: " + FactoryList[i].Name + " Адресс: " + FactoryList[i].Adress + " Год основания: " + FactoryList[i].Year);
                    }
                }
            }
        }
    }
}
