using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


/*
    Абстрактный класс PhoneDirectory с методами, позволяющими вывести на экран информацию о записях
    в телефонном справочнике, а также определить соответствие записи критерию поиска.
*/

namespace PhoneBook
{
    // Абстрактный класс PhoneDirectory
    abstract class PhoneDirectory
    {
        // Абстрактный метод для вывода информации
        public abstract void DisplayInfo();

        // Абстрактный метод для проверки соответствия критерию поиска
        public abstract bool SearchSur(string search);
    }
}