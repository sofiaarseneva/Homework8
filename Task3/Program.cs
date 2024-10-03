using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Вручную подготовьте текстовый файл с фрагментом текста.Напишите программу,
            //которая выводит статистику по файлу -количество символов, строк и слов в тексте.
            string path = "text_for_task3.txt";
            string oneLine = "";
            int countLines = 0;
            int countWords = 0;
            int countChars = 0;
            string[] words;

            using (StreamReader sr = new StreamReader(path))
            {
                while (!sr.EndOfStream)
                {
                    oneLine = sr.ReadLine();
                    countLines++;
                    words = oneLine.Split();
                    countWords += words.Length;
                    countChars += oneLine.Length;
                }
            }
         
            Console.WriteLine("Количество символов равно {0}, количество строк равно {1}, количество слов равно {2}", countChars, countLines, countWords);
            Console.ReadKey();
        }
    }
}
