using System;

namespace Lab2PhoneBook
{
    /// <summary>
    /// Персона, характеризуется именем, адресом и номером телефона
    /// </summary>
    public class Person : PhoneBook
    {
        /// <summary>
        /// Конструктор класса
        /// </summary>
        /// <param name="name">Имя</param>
        /// <param name="address">Адрес</param>
        /// <param name="phone">Телефон</param>
        public Person(string name, string address, string phone)
        {
            this.name = name;
            this.address = address;
            this.phone = phone;
        }
        /// <summary>
        /// Вывод записи
        /// </summary>
        public override void printInfo()
        {
            Console.WriteLine($"Имя: {name}\nАдрес: {address}\nТелефон: {phone}\n");
        }
    }
}

