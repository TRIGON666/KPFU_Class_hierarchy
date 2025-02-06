using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
    Друг (фамилия, адрес, номер телефона, дата рождения)
*/

namespace PhoneBook
{
    class Friend : PersonForPhone
    {
        public DateTime BirthDate { get; set; }

        // Конструктор
        public Friend(string surname, string address, string phoneNumber, DateTime birthDate)
            : base(surname, address, phoneNumber)
        {
            BirthDate = birthDate;
        }

        // Метод для вывода информации
        public override void DisplayInfo()
        {
            Console.WriteLine($"Друг: {Surname}\t Адрес: {Address}\t Телефон: {PhoneNumber}\t Дата рождения: {BirthDate.ToString("yyyy-MM-dd")}");
        }
    }
}