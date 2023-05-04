using ConsoleApp1;
using System;
class Program
{
    static void Main(string[] args)
    {
        Person[] people = new Person[3];
        people[0] = new Student(2000, "мужской", "Иван", "Иванов", "Программирование", 2);
        people[1] = new Schoolboy(2008, "мужской", "Петр", "Петров", 1, 7);
        people[2] = new Teacher(1975, "женский", "Анна", "Сидорова", 20, "Доцент");

        foreach (Person person in people)
        {
            person.DisplayInfo();
            person.CalculateAge();
            Console.WriteLine();
        }
    }
}