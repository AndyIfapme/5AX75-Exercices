using System.ComponentModel.Design;
using Theory_Heritage.Mocks;

namespace Theory_Heritage
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Ex 1
            //var student = new Student
            //{
            //    Firstname = "Alain",
            //    Lastname = "Delon",
            //    Birth = new DateTime(1960,03,27)
            //};

            //var teacher = new Teacher
            //{
            //    Firstname = "Andy",
            //    Lastname = "Bianco",
            //    Birth = new DateTime(1990,03,03)
            //};

            //ReadPerson(student);
            //ReadPerson(teacher);

            //Ex 2 
            //Console.Write("Veuillez introduire le chemin du fichier : ");
            //var path = Console.ReadLine()!;
            //ReadDataFromFile(path, new FileService());

            //Ex 3 
            var student = new Student
            {
                Firstname = "Alain",
                Lastname = "Delon",
                Birth = new DateTime(1960, 03, 27)
            };

            var teacher = new Teacher
            {
                Firstname = "Andy",
                Lastname = "Bianco",
                Birth = new DateTime(1990, 03, 03)
            };

            var persons = new List<Person>
            {
                student,
                teacher
            };

            DeletePerson(persons, student);
            ReadPerson(persons);
        }

        private static void ReadPerson(Person person)
        {
           Console.WriteLine(person.Firstname);
           Console.WriteLine(person.Lastname);
           Console.WriteLine(person.Birth);
        }

        private static void ReadPerson(List<Person> persons)
        {
            var filters = persons.Where(x => x is not IDelete d || !d.DeletedAt.HasValue).ToList();
            foreach (var person in filters)
            {
                ReadPerson(person);
            }
        }

        private static void ReadDataFromFile(string path, IFileService fileService)
        {
            var list = fileService.ReadFromFile(path);
            foreach (var data in list)
            {
                Console.WriteLine(data);
            }
        }

        private static void DeletePerson(List<Person> persons, Person person)
        {
            if (person is IDelete delete)
            {
                delete.Delete();
            }
            else
            {
                persons.Remove(person);
            }
        }

    }
}