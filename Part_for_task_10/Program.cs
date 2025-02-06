using System;
using System.Collections.Generic;
using System.IO;
using Person;
using PhoneBook;
/*
 
            Так как я не смог показать на практике и объяснить код программы,
            то прикрепляю короткие коментарии на код.    

*/

/* 
    
    Сама программа для тестирования классов Person, Teach, Student, Applicant.
    К сожалению не смог найти методов для руссификации под полями, поэтому оставил все на английском(((

*/

namespace PartForTask10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                // Массив хранения данных до 100 человек(да, я отказался от списка, массив удобнее и не вызвает проблем)  
                Person.Person[] personArray = new Person.Person[100];
                int personCount = 0;

                // Читаю данные из файла(БДшка на 3 персон)  
                // Сам файл FileRead располагается в папке с проектом ../bin/Debug/FileRead.txt  
                // (так как удобнее при скачивании проекта сразу запустить его и не париться)  
                using (StreamReader fileIn = new StreamReader("FileRead.txt"))
                {
                    string text;
                    while ((text = fileIn.ReadLine()) != null)
                    {
                        // Пропускаю пустые строки и строки, начинающиеся с типа  
                        if (string.IsNullOrWhiteSpace(text) || text.StartsWith("Type"))
                        {
                            continue;
                        }

                        // Разделяю строку на части  
                        string[] splittedInfo = text.Split('|');

                        try
                        {
                            // Извлекаю данные из разделенных частей  
                            string name = splittedInfo[1];
                            string surname = splittedInfo[2];
                            DateTime dateOfBirth = DateTime.Parse(splittedInfo[3]);

                            // Создаю объекты соответствующих классов в зависимости от типа  
                            switch (splittedInfo[0])
                            {
                                case "Applicant":
                                    string faculty = splittedInfo[4];
                                    personArray[personCount++] = new Applicant(name, surname, dateOfBirth, faculty);
                                    break;

                                case "Student":
                                    faculty = splittedInfo[4];
                                    int course = int.Parse(splittedInfo[5]);
                                    personArray[personCount++] = new Student(name, surname, dateOfBirth, faculty, course);
                                    break;

                                case "Teach":
                                    faculty = splittedInfo[4];
                                    string position = splittedInfo[6];
                                    int seniority = int.Parse(splittedInfo[7]);
                                    personArray[personCount++] = new Teach(name, surname, dateOfBirth, faculty, position, seniority);
                                    break;

                                default:
                                    Console.WriteLine("Ошибка!");
                                    continue;
                            }
                        }
                        catch (Exception ex)// Exception - тип данных для исключения  
                        { 
                            Console.WriteLine(ex.ToString());
                        }
                    }
                }

                // Вывод всех строк
                Console.WriteLine("Список КФУ:");
                for (int i = 0; i < personCount; i++)
                {
                    personArray[i].DisplayInfo();
                }

                // Запрашиваем минимальный и максимальный возраст(название переменных говорит само за себя)  
                Console.Write("Введите минимальный возраст: ");
                int lower = int.Parse(Console.ReadLine());

                Console.Write("Введите максимальный возраст: ");
                int upper = int.Parse(Console.ReadLine());

                // Фильтрую массив по возрасту, извлекая данные с помощью FindAll, который удолетворяют условиям  
                var filteredPeople = Array.FindAll(personArray, p => p != null && p.GetAge() >= lower && p.GetAge() <= upper);
                /*  
                    Что я сделал данным выражением? Я обработал данные из массива personArray  
                    PersonArray я обозначил как "p" и сделал проверку на null, чтобы не было ошибок  
                    Проверил возраст на соответствие условиям и вывел данные, которые удовлетворяют условию [lower, upper], то есть  
                    от минимального возраста до максимального возраста.  
                 */

                // Вывод информации о людях в заданном возрастном диапазоне  
                if (filteredPeople.Length == 0)
                    Console.WriteLine("Нет людей в данном возрастном диапазоне.");
                else
                    Array.ForEach(filteredPeople, p => p.DisplayInfo());
                // ForEach - метод, который применяет указанный метод к каждому элементу массива  
            }
            catch (Exception ex)
            {
                // Обрабатываю исключения общего характера  
                Console.WriteLine($"Ошибка: {ex.Message}");
            }


            Console.WriteLine("\n \n \n \n \n \n ");



            ////////////////////////////////////////////////////////////////////////////////////////////////////


            /*  
                Телефонный справочник  
                Для тестирования классов PhoneDirectory, PersonForPhone, Organization, Friend 
                Здесь такой же принцип как и в 1 задаче только сделал по другому абстрактные методы

                "Создать базу (массив) из n товаров, вывести полную информацию из базы на экран, а также организовать поиск в базе по фамилии. "
                А что за товары? Опечатка?
            */




            // Также массив
            PhoneDirectory[] records = new PhoneDirectory[100];
            int recordCount = 0;

            // Чтение данных из файла
            string fileIn2 = "phone.txt";
            if (File.Exists(fileIn2))
            {
                string[] lines = File.ReadAllLines(fileIn2);
                foreach (var line in lines)
                {
                    string[] data = line.Split('|');
                    string type = data[0].Trim();

                    switch (type)
                    {
                        case "Person":
                            records[recordCount++] = new PersonForPhone(data[1], data[2], data[3]);
                            break;
                        case "Organization":
                            records[recordCount++] = new Organization(data[1], data[2], data[3], data[4], data[5]);
                            break;
                        case "Friend":
                            records[recordCount++] = new Friend(data[1], data[2], data[3], DateTime.Parse(data[4]));
                            break;
                    }
                }
            }

            // Вывожу полную информацию из базы на экран
            Console.WriteLine("Телефонный справочник:");
            for (int i = 0; i < recordCount; i++)
            {
                records[i].DisplayInfo();
            }

            // Поиск по справочнику
            Console.Write("Введите фамилию для поиска: ");
            string searchQuery = Console.ReadLine().Trim();

            Console.WriteLine("Результаты поиска:");
            bool found = false;
            for (int i = 0; i < recordCount; i++)
            {
                if (records[i].SearchSur(searchQuery)) // Проверка на совпадение
                {
                    records[i].DisplayInfo();
                    found = true;
                }
            }

            if (!found)
            {
                Console.WriteLine("Записи не найдены.");
            }

        }
    }
}
