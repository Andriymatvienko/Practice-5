using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    abstract class Person
    {
        protected int birthYear;
        protected string gender;
        protected string firstName;
        protected string lastName;

        public Person(int birthYear, string gender, string firstName, string lastName)
        {
            this.birthYear = birthYear;
            this.gender = gender;
            this.firstName = firstName;
            this.lastName = lastName;
        }

        public abstract void DisplayInfo();

        public virtual void CalculateAge()
        {
            int age = DateTime.Now.Year - birthYear;
            string status = age < 18 ? "несовершеннолетний" : "совершеннолетний";
            Console.WriteLine($"Возраст: {age}, статус: {status}");
        }
    }

    class Student : Person
    {
        private string specialty;
        private int course;

        public Student(int birthYear, string gender, string firstName, string lastName, string specialty, int course)
            : base(birthYear, gender, firstName, lastName)
        {
            this.specialty = specialty;
            this.course = course;
        }

        public override void DisplayInfo()
        {
            Console.WriteLine($"Студент: {firstName} {lastName}");
            Console.WriteLine($"Специальность: {specialty}, курс: {course}");
        }
    }

    class Schoolboy : Person
    {
        private int schoolNumber;
        private int schoolClass;

        public Schoolboy(int birthYear, string gender, string firstName, string lastName, int schoolNumber, int schoolClass)
            : base(birthYear, gender, firstName, lastName)
        {
            this.schoolNumber = schoolNumber;
            this.schoolClass = schoolClass;
        }

        public override void DisplayInfo()
        {
            Console.WriteLine($"Школьник: {firstName} {lastName}");
            Console.WriteLine($"Школа №{schoolNumber}, класс {schoolClass}");
        }
    }

    class Teacher : Person
    {
        private int experience;
        private string position;

        public Teacher(int birthYear, string gender, string firstName, string lastName, int experience, string position)
            : base(birthYear, gender, firstName, lastName)
        {
            this.experience = experience;
            this.position = position;
        }

        public override void DisplayInfo()
        {
            Console.WriteLine($"Преподаватель: {firstName} {lastName}");
            Console.WriteLine($"Стаж работы: {experience} лет, должность: {position}");
        }

        public override void CalculateAge()
        {
            int age = DateTime.Now.Year - birthYear;
            string status = age >= 60 ? "пенсионер" : "взрослый";
            Console.WriteLine($"Возраст: {age}, статус: {status}");
        }
    }
}

