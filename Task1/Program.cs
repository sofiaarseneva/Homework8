using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Выберите любую папку на своем компьютере, имеющую вложенные директории. Выведите на консоль ее содержимое и содержимое всех подкаталогов.
            string path = "Folder1";
            DirectoryInfo directory = new DirectoryInfo(path);
            if (directory.Exists)
            {
                //выводим файлы в главном каталоге
                FileInfo[] filesUp = directory.GetFiles();
                if (filesUp.Length != 0)
                {
                    foreach (FileInfo fileUp in filesUp)
                    {
                        Console.WriteLine(" - {0}", fileUp.Name);
                    }
                }
                //выводим подкаталоги и файлы в них
                DirectoryInfo[] direct = directory.GetDirectories();
                foreach (DirectoryInfo dir in direct)
                {
                    Console.WriteLine(dir);
                    FileInfo[] files = dir.GetFiles();
                    foreach (FileInfo file in files)
                    {
                        Console.WriteLine(" - {0}",file.Name);
                    }
                }
            }
            else
            {
                Console.WriteLine("Директории не существует!");
            }
            Console.ReadKey();
        }
    }
}
