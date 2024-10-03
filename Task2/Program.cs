using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Программно создайте текстовый файл и запишите в него 10 случайных чисел. Затем программно откройте созданный файл,
            //рассчитайте сумму чисел в нем, ответ выведите на консоль.
            string path = "Numbers.txt";
            int sum = 0;
            Random random = new Random();

            using (StreamWriter sw = new StreamWriter(path, false))
            {
                for (int i = 0; i < 10; i++)
                {
                    sw.WriteLine(random.Next(-10, 10));
                }
            }

            using (StreamReader sr = new StreamReader(path))
            {
                for (int i = 0; i < 10; i++)
                {
                    sum += Convert.ToInt32(sr.ReadLine());
                }
            }

            Console.WriteLine("Сумма чисел в файле Numbers.txt равна {0}", sum);
            Console.ReadKey();
        }
    }
}
