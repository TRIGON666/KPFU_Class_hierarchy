using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


/*
 
            Так как я не смог показать на практике и объяснить код программы,
            то прикрепляю короткие коментарии на код.    

*/

/* 
    Абстрактный класс Persona с методами, позволяющим вывести на экран информацию о персоне,
    а также определить ее возраст (на момент текущей даты).

*/

namespace Person
{
    // Сам абстрактный класс
    abstract class Person
    {
        
        string name;
        string surname;
        DateTime dateOfBirth;

        // Конструктор
        public Person()
        {
            name = "Иван";
            surname = "Иванов";
            dateOfBirth = new DateTime(2006, 4, 28);
        }

        // Ещё конструктор
        public Person(string name, string surname, DateTime dateOfBirth)
        {
            this.name = name;
            this.surname = surname;
            this.dateOfBirth = dateOfBirth;
        }

        // Свойство для доступа к дате рождения
        public DateTime DateOfBirth
        {
            get 
            {
                return dateOfBirth; 
            }
            set
            {
                this.dateOfBirth = value;
            }
        }

        // Свойство для доступа к имени
        public string Name
        {
            get 
            {
                return name; 
            }
            set
            {
                this.name = value;
            }
        }

        // Свойство для доступа к фамилии
        public string Surname
        {
            get 
            {
                return surname; 
            }
            set
            {
                this.surname = value;
            }
        }

        // Метод для вычисления возраста на текущую дату
        public int GetAge()
        {
            var today = DateTime.Now;

            int age = today.Year - dateOfBirth.Year;

            // Проверка, был ли уже день рождения в текущем году, иначе мне уже 20 по коду
            if (today < new DateTime(today.Year, dateOfBirth.Month, dateOfBirth.Day))
            {
                age--;
            }

            return age;
        }

        // Абстрактный метод для вывода информации
        abstract public void DisplayInfo();
    }
}
