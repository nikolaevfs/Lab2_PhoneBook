using System;
using System.Diagnostics;

namespace Lab2PhoneBook
{
    [Serializable]
    /// <summary>
    /// Персона, характеризуется именем, адресом и номером телефона
    /// </summary>
    public class Person : PhoneBook
    {
        /// <summary>
        /// Конструктор без параметров
        /// </summary>
        public Person() { }
        /// <summary>
        /// Конструктор класса
        /// </summary>
        /// <param name="name">Имя</param>
        /// <param name="address">Адрес</param>
        /// <param name="phone">Телефон</param>
        public Person(string name, string address, string phone)
        {
            Trace.WriteLine("Person.Person");
            this.name = name;
            this.address = address;
            this.phone = phone;
        }
        /// <summary>
        /// Вывод записи
        /// </summary>
        public override void printInfo()
        {
            Trace.WriteLine("Person.PrintInfo");
            Console.WriteLine($"Имя: {name}\nАдрес: {address}\nТелефон: {phone}\n");
        }
    }
}

