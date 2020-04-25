using System;
using System.Text;
using System.IO;
using System.Xml.Serialization;


namespace Lab2PhoneBook
{
    class Program
    {
        static void Main(string[] args)
        {
            XmlSerializer formatter = new XmlSerializer(typeof(PhoneBook[]));
            PhoneBook[] phoneBase;
            try
            {
                phoneBase = readFromFile("input.txt");
            }
            catch (FileNotFoundException e)
            {
                Console.WriteLine("Не найден исходный файл:");
                Console.WriteLine(e.FileName);
                return;
            }

            Console.WriteLine("Телефонный справочник: \n");
            foreach (PhoneBook record in phoneBase)
            {
                record.printInfo();
            }

            Console.Write("Поиск в базе по фамилии/названию: ");
            string searching = Console.ReadLine();
            foreach (PhoneBook record in phoneBase)
            {
                record.Search(searching);
            }

            using (FileStream fs = new FileStream("base.xml", FileMode.OpenOrCreate))
            {
                formatter.Serialize(fs, phoneBase);
            }

            Console.ReadKey();
        }

        /// <summary>
        /// Построковое чтение из файла
        /// </summary>
        /// <param name="fileName">Название файла для чтения</param>
        /// <returns></returns>
        static PhoneBook[] readFromFile(string fileName)
        {
            StreamReader file = new StreamReader("input.txt", Encoding.Default);
            int n = Convert.ToInt32(file.ReadLine());
            PhoneBook[] phoneBookDB = new PhoneBook[n];
            for (int i = 0; i < n; i++)
            {
                phoneBookDB[i] = parseRec(file.ReadLine());
            }
            return phoneBookDB;
        }

        /// <summary>
        /// Преобразование строки из файла в экземпляр класса
        /// </summary>
        /// <param name="line">Преобразуемая строка</param>
        /// <returns></returns>
        static PhoneBook parseRec(string line)
        {
            string[] element = line.Split(';');
            switch (element[0])
            {
                case "person":
                    return new Person(element[1], element[2], element[3]);
                case "organization":
                    return new Organization(element[1], element[2], element[3], element[4], element[5]);
                case "friend":
                    return new Friend(element[1], element[2], element[3], element[4]);
                default: return new Person(" ", " ", " ");
            }
        }
    }
}