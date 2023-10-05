using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW4
{
    internal class Person
    {
        private string name;
        private DateTime birthYear; 

        
        public string Name
        {
            get { return name; }
        }

        public DateTime BirthYear
        {
            get { return birthYear; }
        }

        
        public Person()
        {
            name = "";
            birthYear = DateTime.MinValue;
        }

        
        public Person(string name, DateTime birthYear)
        {
            this.name = name;
            this.birthYear = birthYear;
        }

        
        public int Age()
        {
            DateTime currentDate = DateTime.Now;
            int age = currentDate.Year - birthYear.Year;

            
            if (currentDate < birthYear.AddYears(age))
            {
                age--;
            }

            return age;
        }

        
        public void Input()
        {
            Console.Write("Введіть ім'я: ");
            name = Console.ReadLine();

            Console.Write("Введіть рік народження (yyyy): ");
            if (DateTime.TryParseExact(Console.ReadLine(), "yyyy", null, System.Globalization.DateTimeStyles.None, out DateTime parsedYear))
            {
                birthYear = parsedYear;
            }
            else
            {
                Console.WriteLine("Невірний формат введення року народження.");
            }
        }

        
        public void ChangeName(string newName)
        {
            name = newName;
        }

        
        public override string ToString()
        {
            return $"Ім'я: {name}, Рік народження: {birthYear:yyyy}, Вік: {Age()}";
        }

        
        public void Output()
        {
            Console.WriteLine(ToString());
        }

       
        public static bool operator ==(Person person1, Person person2)
        {
            if (ReferenceEquals(person1, person2))
                return true;

            if (person1 is null || person2 is null)
                return false;

            return person1.name == person2.name;
        }

        public static bool operator !=(Person person1, Person person2)
        {
            return !(person1 == person2);
        }

        
    }
}
