using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication11
{
    class Program
    {
        static void Main(string[] args)
        {
            //экземпляр класса
            File file1 = new File
            {
                name = "Файл 1",
                date = "20.04.18",
                length = 3562
            };
            Console.WriteLine("Имя файла: " + file1.N);
            Console.WriteLine("Дата создания: " + file1.D);
            Console.WriteLine("Длина файла: " + file1.L);
            Console.WriteLine();

            //Третий файл
            Console.WriteLine("Введите имя файла");
            string name = Convert.ToString(Console.ReadLine());
            Console.WriteLine("Введите дату создания");
            string date = Convert.ToString(Console.ReadLine());
            Console.WriteLine("Введите длину файла");
            int length = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Имя файла: " + name);
            Console.WriteLine("Дата создания: " + date);
            Console.WriteLine("Длина файла: " + length);

            Console.ReadLine();
        }
    }

    class File
    { //поля класса
        public string name;
        public string date;
        public int length;

        #region Свойства класса
        public string N
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }
        public string D
        {
            get
            {
                return date;
            }
            set
            {
                date = value;
            }
        }
        public int L
        {
            get
            {
                return length;
            }
            set
            {
                length = value;
            }
        }
        #endregion
        public File()
        { }
    }
}