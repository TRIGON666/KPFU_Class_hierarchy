using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


/*
    Персона (фамилия, адрес, номер телефона)
*/

namespace PhoneBook
{
    // Класс Person
    class PersonForPhone : PhoneDirectory
    {
        public string Surname { get; set; }
        public string Address { get; set; }
        public string PhoneNumber { get; set; }

        // Конструктор
        public PersonForPhone(string surname, string address, string phoneNumber)
        {
            Surname = surname;
            Address = address;
            PhoneNumber = phoneNumber;
        }

        // Метод для вывода информации
        public override void DisplayInfo()
        {
            Console.WriteLine($"Персона: {Surname}\t Адрес: {Address}\t Телефон: {PhoneNumber}");
        }

        // Метод для поиска по фамилии
        public override bool SearchSur(string search)
        {
            return Surname.IndexOf(search, StringComparison.OrdinalIgnoreCase) >= 0;
            // Метод SearchSur проверяет, содержит ли фамилия искомую строку.
            // Используется метод IndexOf с параметром StringComparison.OrdinalIgnoreCase для игнорирования регистра.
            // Если искомая строка найдена в фамилии, метод возвращает true, иначе - false.
        }
    }
}