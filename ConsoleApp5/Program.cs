using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    class Program
    {

        static void Main(string[] args)
        {
            Class1 studetn = new Class1 (20, 185, "Александр", "Обучается");
            Console.WriteLine($"Возраст студента {studetn.ReturnVozrast()} ");
            Console.WriteLine($"Рост студента {studetn.ReturnRost()} ");
            Console.WriteLine($"Имя студента {studetn.ReturnName()} ");
            Console.WriteLine($"Статус Студента {studetn.ReturnStatus()} ");
                Console.WriteLine("Введите новое имя студента _");
            studetn.SetName(Console.ReadLine());
            Console.WriteLine($"Новое имя студента {studetn.ReturnName()}");
            Console.ReadLine();
        }
    }
}
