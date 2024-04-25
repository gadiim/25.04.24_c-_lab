using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Тема: Вступ у Generics
//Модуль 10. Part 2

namespace _25._04._24_c__lab
{

    //Task_1

    class ABC : IEnumerable
    {
        private List<char> letters;

        public ABC()
        {
            letters = new List<char>();
            letters.Add('a');
            letters.Add('b');
            letters.Add('c');
            letters.Add('d');
            letters.Add('e');
            letters.Add('f');
            letters.Add('g');
            letters.Add('h');
            letters.Add('i');
            letters.Add('g');
            letters.Add('k');
            letters.Add('l');
            letters.Add('m');
            letters.Add('n');
            letters.Add('o');
            letters.Add('p');
            letters.Add('q');
            letters.Add('r');
            letters.Add('s');
            letters.Add('t');
            letters.Add('u');
            letters.Add('v');
            letters.Add('w');
            letters.Add('x');
            letters.Add('y');
            letters.Add('z');
        }
        public IEnumerator GetEnumerator()
        {
            return letters.GetEnumerator();
        }

    }

    //class Flat : IEnumerable
    //{
    //    List<User> users { get; set; } = new List<User>();

    //    public IEnumerator GetEnumerator()
    //    {
    //        return users.GetEnumerator();
    //    }
    //}

    //class User
    //{
    //    public string Name { get; set; }
    //}

    //Task_2

    class Apartment
    {
        public string Number { get; set; }
        public List<string> Residents { get; set; }

        public Apartment(string number)
        {
            Number = number;
            Residents = new List<string>();
        }
        public void ShowResidents()
        {
            Console.WriteLine($"apartment {Number}:\t\t");
            foreach (string r in Residents)
            {
                Console.WriteLine($"\t{r}");
            }
            Console.WriteLine();
        }
    }

    class House : IEnumerable
    {
        private SortedList<string, Apartment> apartments;

        public House()
        {
            apartments = new SortedList<string, Apartment>();
        }
        public void AddApartment(Apartment apartment)
        {
            apartments.Add(apartment.Number, apartment);
        }
        public IEnumerator GetEnumerator()
        {
            return apartments.Values.GetEnumerator();
        }
    }

    //Task_3
    class Car
    {
        public string Brand { get; set; }
        public string License { get; set; }

        public Car(string brand, string license)
        {
            Brand = brand;
            License = license;
        }
        public override string ToString()
        {
            return $"car {Brand}: license plate {License}";
        }
    }
    class Garage : IEnumerable
    {
        private List<Car> cars;

        public Garage()
        {
            cars = new List<Car>();
        }
        public void AddCar(Car car)
        {
            cars.Add(car);
        }
        public IEnumerator GetEnumerator()
        {
            return cars.GetEnumerator();
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            //Завдання 1
            //Створіть клас «Алфавіт», в якому мають міститися
            //літери англійського алфавіту.
            //Реалізуйте підтримку ітератора.
            //Протестуйте можливість використання foreach
            //для класу «Алфавіт».

            Console.WriteLine($"Task 1\n");

            ABC abc = new ABC();

                foreach (char l in abc)
                {
                    Console.Write($"{l}, ");
                }
                Console.WriteLine();
 
            Console.WriteLine("\nPress any key to continue . . .");
            Console.ReadKey();
            Console.WriteLine();

            //Завдання 2
            //Створіть клас «Будинок», в якому має міститися інформація
            //про квартири в цьому будинку. Створіть клас
            //«Квартира» з інформацією про мешканців квартир.
            //Реалізуйте підтримку ітератора для класів «Будинок»
            //і «Квартира». Протестуйте можливість використання foreach
            //для класів «Будинок» і «Квартира».

            Console.WriteLine($"Task 2\n");

            Apartment apartment_2 = new Apartment("2");
            Apartment apartment_3 = new Apartment("3");
            Apartment apartment_1 = new Apartment("1");
            Apartment apartment_4 = new Apartment("4");
            House house = new House();

            apartment_2.Residents.Add("male from 2");
            apartment_2.Residents.Add("female from 2");
            apartment_2.Residents.Add("child from 2");
            apartment_1.Residents.Add("female from 1");
            apartment_1.Residents.Add("child from 1");
            apartment_3.Residents.Add("male from 3");
            apartment_3.Residents.Add("female from 3");
            apartment_3.Residents.Add("child from 3");
            apartment_3.Residents.Add("child from 3");
            apartment_4.Residents.Add("male from 4");

            house.AddApartment(apartment_1);
            house.AddApartment(apartment_2);
            house.AddApartment(apartment_3);
            house.AddApartment(apartment_4);

            foreach (Apartment apartment in house)
            {
                apartment.ShowResidents();
            }

            Console.WriteLine("\nPress any key to continue . . .");
            Console.ReadKey();
            Console.WriteLine();

            //Завдання 3
            //Створіть клас «Гараж». Клас має містити інформацію
            //про машини, які знаходяться в гаражаx. Створіть клас
            //«Автомобіль», в якому, відповідно, міститься інформація
            //про автомобіль. Реалізуйте підтримку ітератора для класу
            //«Гараж». Протестуйте можливість використання foreach
            //для класу «Гараж».

            Console.WriteLine($"Task 3\n");

            Garage garage = new Garage();

            garage.AddCar(new Car("vehicle 1", "AA 1122-3"));
            garage.AddCar(new Car("vehicle 2", "BB 4455-6"));
            garage.AddCar(new Car("vehicle 3", "CC 7788-9"));

            foreach (Car c in garage)
            {
                Console.WriteLine(c);
            }

            Console.WriteLine();

        }
    }
}
