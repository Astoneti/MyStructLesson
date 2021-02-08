using System;

namespace MyStructLesson
{
    class Program
    {
        // Структуры это типы значений и храняться в Стеке а Классы ссылочные типы и храняться в Куче.
        // Модификатор доступа у класса также может быть private, по умолчанию он public как и все в классе!!!

        struct Employee // Структуры не поддерживают Наследования!
                        //поскольку структуры в отличие от классов не поддерживают наследование, 
                        //то их члены нельзя указывать как abstract, virtual  или  protected.
        {
            // Все поля по умолчанию public!
            public string name;  //= "Ivan"; нельзя инициализировать поля структуры напрямую при их объявлении!
            public string lastName;
            public int age;
            public string organization;
            public string position;

            //Нельзя использовать конструктор по умолчанию!
            public Employee(string Name, string LastName): this()
            {
                name = Name;
                lastName = LastName;
            }
            public Employee(int Age, string Organization, string Position) :this()
            {
                age = Age;
                organization = Organization;
                position = Position;
            }
            public Employee(string Name, string LastName, int Age, string Organization, string Position) 
            {
                name = Name;
                lastName = LastName;
                age = Age;
                organization = Organization;
                position = Position;
            }
            public  void GetFullName()
            {
                Console.WriteLine($"{name} {lastName} - Сработал первый метод!");
            }
            
            public void DisplayInfo() 
            {
                Console.WriteLine($"Name : {name},\nLast name : {lastName},\nAge : {age},\nOrganization : {organization},\nPosition : {position},\nСработал второй метод!");
            }
           
        }
        static void Main(string[] args)
        {
            Employee employee1;
            employee1.name = "Ivan";  // Можем еще так инициализировать объект без создания конструктора класса!!!
            employee1.lastName = "Petrov";
            employee1.age = 38;
            employee1.organization = "Godel Technologies Europe";
            employee1.position = "developer";
            employee1.DisplayInfo();
            employee1.GetFullName();

            Employee employee2 = new Employee("Ina", "Petrova", 40, "Godel Technologies Europe", "hr");
            employee2.DisplayInfo();
            employee2.GetFullName();

            // Отличие структур от классов – в передаче по значению
            employee1 = employee2;  // пересылка
            employee2.name = "Egor";
            employee2.lastName = "Egorov";
            employee2.age = 25;
            employee2.organization = "Godel Technologies Europe";
            employee2.position = "driver";
            //employee1.DisplayInfo();
            //employee1.GetFullName();
            employee2.DisplayInfo();
            employee2.GetFullName();
            Console.ReadKey();
        }
    }
}
