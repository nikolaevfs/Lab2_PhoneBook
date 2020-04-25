using System;

namespace Lab2PhoneBook
{
    /// <summary>
    /// Организация
    /// </summary>
    public class Organization : PhoneBook
    {
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
            this.name = name;
            this.address = address;
            this.phone = phone;
            this.fax = fax;
            this.contact = contact;
        }

        public override void printInfo()
        {
            Console.WriteLine($"Название: {name}\nАдрес: {address}\nТелефон: {phone}\nФакс: {fax}\nКонтактное лицо: {contact}\n");
        }
    }
}
