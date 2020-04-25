using System;
using System.Diagnostics;

namespace Lab2PhoneBook
{
    [Serializable]
    /// <summary>
    /// Организация
    /// </summary>
    public class Organization : PhoneBook
    {
        /// <summary>
        /// Конструктор без параметров
        /// </summary>
        public Organization() { }
        /// <summary>
        /// Факс
        /// </summary>
        public string fax;
        /// <summary>
        /// Контактное лицо
        /// </summary>
        public string contact;

        /// <summary>
        /// Конструктор класса
        /// </summary>
        /// <param name="name">Имя/Название</param>
        /// <param name="address">Адрес</param>
        /// <param name="phone">Номер телефона</param>
        /// <param name="fax">Факс</param>
        /// <param name="contact">Контактное лицо</param>
        public Organization(string name, string address, string phone, string fax, string contact)
        {
            Trace.WriteLine("Organization.Organization");
            this.name = name;
            this.address = address;
            this.phone = phone;
            this.fax = fax;
            this.contact = contact;
        }

        public override void printInfo()
        {
            Trace.WriteLine("Organization.PrintInfo");
            Console.WriteLine($"Название: {name}\nАдрес: {address}\nТелефон: {phone}\nФакс: {fax}\nКонтактное лицо: {contact}\n");
        }
    }
}
