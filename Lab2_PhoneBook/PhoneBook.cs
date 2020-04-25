using System;
using System.Diagnostics;
using System.Xml.Serialization;

namespace Lab2PhoneBook
{
    [XmlInclude(typeof(Person)), XmlInclude(typeof(Friend)), XmlInclude(typeof(Organization))]
    [Serializable]
    /// <summary>
    /// абстрактный класс, обозначающий запись в телефонном справочнике
    /// </summary>
    public abstract class PhoneBook
    {
        /// <summary>
        /// Поле имени
        /// </summary>
        public string name;
        /// <summary>
        /// Поле адреса
        /// </summary>
        public string address;
        /// <summary>
        /// Телефонный номер
        /// </summary>
        public string phone;

        /// <summary>
        /// Конструктор без параметров
        /// </summary>
        public PhoneBook() { }
        /// <summary>
        /// Метод, выводящий на экран информацию о записи
        /// </summary>
        public abstract void printInfo();

        /// <summary>
        /// Проверка записи на соответствие введенному значению
        /// </summary>
        /// <param name="searching">Значение фамилии или названия организации, с которым происходит сравнение
        /// </param>
        public void Search(string searching)
        {
            Trace.WriteLine("PhoneBook.Search");
            if (name.Contains(searching)) printInfo();
        }
    }
}

