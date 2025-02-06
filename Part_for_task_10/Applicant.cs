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
    Абитуриент (фамилия, дата рождения, факультет)
*/

namespace Person
{
    class Applicant : Person
    {
        string faculty;

        // Конструктор
        public Applicant()
        {
            Name = "Иван";
            Surname = "Иванов";
            DateOfBirth = new DateTime(2006, 4, 28);
            faculty = "ИВМИИТ";
        }

        // Ещё конструктор
        public Applicant(string name, string surname, DateTime dateOfBirth, string faculty)
        {
            Name = name;
            Surname = surname;
            DateOfBirth = dateOfBirth;
            this.faculty = faculty;
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

        // Метод для отображения информации об абитуриенте
        public override void DisplayInfo()
        {
            Console.WriteLine($"Абитуриент: {this.Name} {this.Surname}\t Возраст: {this.GetAge()}\t Институт: {faculty}");
        }
    }
}
