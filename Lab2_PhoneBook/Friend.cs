using System;
using System.Diagnostics;

namespace Lab2PhoneBook
{
    [Serializable]
    /// <summary>
    /// Друг
    /// </summary>
    public class Friend : PhoneBook
    {
        /// <summary>
        /// Конструктор без параметров
        /// </summary>
        public Friend() { }
        /// <summary>
        /// Дата рождения
        /// </summary>
        public string birthDate;

        /// <summary>
        /// Конструктор класса
        /// </summary>
        /// <param name="name">Имя</param>
        /// <param name="address">Адрес</param>
        /// <param name="phone">Номер телефона</param>
        /// <param name="birthDate">Дата рождения</param>
        public Friend(string name, string address, string phone, string birthDate)
        {
            Trace.WriteLine("Friend.Friend");
            this.name = name;
            this.address = address;
            this.phone = phone;
            this.birthDate = birthDate;
        }

        public override void printInfo()
        {
            Trace.WriteLine("Friend.PrintInfo");
            Console.WriteLine($"Имя: {name}\nАдрес: {address}\nТелефон: {phone}\nДата рождения: {birthDate}\n");
        }
    }
}
