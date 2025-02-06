using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
    Организация (название, адрес, телефон, факс, контактное лицо)
*/

namespace PhoneBook
{
    // Класс Organization
    class Organization : PhoneDirectory
    {
        public string Name { get; set; }
        public string Address { get; set; }
        public string PhoneNumber { get; set; }
        public string Fax { get; set; }
        public string Surname { get; set; }

        // Конструктор
        public Organization(string name, string address, string phoneNumber, string fax, string surname)
        {
            Name = name;
            Address = address;
            PhoneNumber = phoneNumber;
            Fax = fax;
            Surname = surname;
        }

        // Метод для вывода информации
        public override void DisplayInfo()
        {
            Console.WriteLine($"Организация: {Name}\t Адрес: {Address}\t Телефон: {PhoneNumber}\t Факс: {Fax}\t Контактное лицо: {Surname}");
        }

        // Метод для поиска по фамилии
        public override bool SearchSur(string search)
        {
            return Surname.IndexOf(search, StringComparison.OrdinalIgnoreCase) >= 0;
        }
    }
}