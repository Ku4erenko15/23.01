using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person("Иван", "Иванов", 30);
            person.PrintInfo();
            Console.ReadKey();
        }
        class Person
        {
            private string firstName;
            private string lastName;
            private int age;

       
            public Person(string firstName, string lastName, int age)
            {
                this.firstName = firstName;
                this.lastName = lastName;
                this.age = age;
            }

     
            public void PrintInfo()
            {
                Console.WriteLine($"Имя: {firstName}");
                Console.WriteLine($"Фамилия: {lastName}");
                Console.WriteLine($"Возраст: {age}");
            }
        }
    }
}

   




