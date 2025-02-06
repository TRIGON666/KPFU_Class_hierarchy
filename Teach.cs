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
    Преподаватель (Имя, Фамилия, дата рождения, факультет, должность, стаж)
*/

namespace Person
{
    // Класс Teach, наследующий класс Person

    class Teach : Person
    {
        string faculty;
        string position;
        int seniority;

        // Конструктор 
        public Teach()
        {
            Name = "Ольга";
            Surname = "Шорина";
            DateOfBirth = new DateTime(2000, 1, 1);
            faculty = "ИВМИИТ";
            position = "Предподователь по программированию";
            seniority = 2;
        }

        // Ещё конструктор
        public Teach(string name, string surname, DateTime dateOfBirth, string faculty, string position, int seniority)
        {
            Name = name;
            Surname = surname;
            DateOfBirth = dateOfBirth;
            this.faculty = faculty;
            this.position = position;
            this.seniority = seniority;
        }

        // Свойство для Института(Факультета)
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

        // Свойство для должности
        public string Position
        {
            get 
            {
                return position;
            }
            set 
            {
                position = value; 
            }
        }

        // Свойство для стажа
        public int Seniority
        {
            get 
            {
                return seniority; 
            }
            set
            {
                if (value < 0) throw new ArgumentException("Ошибка");
                this.seniority = value;
            }
        }

        // Метод для отображения информации
        public override void DisplayInfo()
        {
            Console.WriteLine($"Преподаватель: {this.Name} {this.Surname}\t Возраст: {this.GetAge()}\t Институт: {faculty}\t Должность: {position}\t Опыт: {seniority}");
        }
    }
}
