namespace HW4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Person[] people = new Person[6];

            for (int i = 0; i < 6; i++)
            {
                Console.WriteLine($"Введіть інформацію для особи {i + 1}:");
                string name = Console.ReadLine();
                Console.Write("Введіть рік народження (yyyy): ");
                if (DateTime.TryParseExact(Console.ReadLine(), "yyyy", null, System.Globalization.DateTimeStyles.None, out DateTime birthYear))
                {
                    people[i] = new Person(name, birthYear);
                }
                else
                {
                    Console.WriteLine("Невірний формат введення року народження. Особа не створена.");
                }
            }

            
            Console.WriteLine("\nІнформація про створених осіб:");
            foreach (Person person in people)
            {
                if (person != null)
                {
                    person.Output();
                }
            }
            
            Console.WriteLine("\nРозрахунок і виведення імен та віку кожної особи:");
            foreach (Person person in people)
            {
                if (person != null)
                {
                    Console.WriteLine($"Ім'я: {person.Name}, Вік: {person.Age()}");
                }
            }

           
            for (int i = 0; i < people.Length; i++)
            {
                if (people[i] != null && people[i].Age() < 16)
                {
                    people[i].ChangeName("Very Young");
                }
            }

            
            Console.WriteLine("\nІнформація про осіб після зміни імен:");
            foreach (Person person in people)
            {
                if (person != null)
                {
                    person.Output();
                }
            }
            
            Console.WriteLine("\nІнформація про всіх осіб:");
            foreach (Person person in people)
            {
                if (person != null)
                {
                    person.Output();
                }
            }


            Console.WriteLine("\nОсоби з однаковими іменами:");

            for (int i = 0; i < people.Length; i++)
            {
                for (int j = i + 1; j < people.Length; j++)
                {
                    if (people[i] != null && people[j] != null && people[i] == people[j])
                    {
                        Console.WriteLine($"Особа {i + 1} та особа {j + 1} мають однакове ім'я: {people[i].Name}");
                    }
                }
            }

            
    
        }
    }
}