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
    Студент (фамилия, дата рождения, факультет, курс)
*/

namespace Person
{
    // Класс Student, наследующий класс Person
    class Student : Person
    {
        
        int course;
        string faculty;

        // Конструктор
        public Student()
        {
            // Инициализация полей
            Name = "Иван";
            Surname = "Иванов";
            DateOfBirth = new DateTime(2006, 4, 28);
            faculty = "ИВМИИТ";
            course = 2;
        }

        // Ещё конструктор
        public Student(string name, string surname, DateTime dateOfBirth, string faculty, int course)
        {
            Name = name;
            Surname = surname;
            DateOfBirth = dateOfBirth;
            this.faculty = faculty;
            this.course = course;
        }

        // Свойство для доступа к полю Институт(Факультет)
        public string Faculty
        {
            get 
            {
                return faculty; 
            }
            set 
            {
                faculty = value; 
            }
        }

        // Свойство для доступа к полю Курс
        public int Course
        {
            get 
            {
                return course; 
            }
            set
            {
                // Проверка на корректность значения курса, если значение меньше или равно 0, то выбрасывается исключение
                // так как курс не может быть меньше или равен 0
                if (value <= 0) throw new ArgumentException("Ошибка!");
                course = value;
            }
        }

        // Метод для отображения информации о студенте
        public override void DisplayInfo()
        {
            Console.WriteLine($"Студент:  {this.Name} {this.Surname}\t Возраст: {this.GetAge()}\t Институт: {faculty}\t Курс: {course}");
        }
    }
}
