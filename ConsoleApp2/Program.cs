using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Address address = new Address("123456", "Россия", "Москва", "Тверская", 10, 25);
            address.Input();
            Console.ReadKey();
        }
      
class Address
    {
        private string index;
        private string country;
        private string city;
        private string street;
        private int house;
        private int apartment;
        public Address(string index, string country, string city, string street, int house, int apartment)
        {
            this.index = index;
            this.country = country;
            this.city = city;
            this.street = street;
            this.house = house;
            this.apartment = apartment;
        }
        public void Input()
        {
            Console.WriteLine("Почтовый адрес:");
            Console.WriteLine($"Индекс: {index}");
            Console.WriteLine($"Страна: {country}");
            Console.WriteLine($"Город: {city}");
            Console.WriteLine($"Улица: {street}");
            Console.WriteLine($"Дом: {house}");
            Console.WriteLine($"Квартира: {apartment}");
        }
    }

   
        }
    }



