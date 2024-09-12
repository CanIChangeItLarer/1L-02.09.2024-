using System;
//protected +наследоваться, -вызывать доступ к методу родительского класса, нотдальше по наследству нельзя переопределять
namespace ConsoleApplication1
{
    public class Student : Item
    {
        public Student(int id, string name) : base(id,name) //наследование
        {
        }
        public override void SendNotification(string message)
        {
            //base.SendNotification(message);
            Console.WriteLine("Message from student: " + message);
        }
    }
}
//абстрактные классы. в них есть абстрактные методы, они не имеют реализации
//класс потомок должен переопределить (реализовать) эти методы
//например, сохранение данных (нет универсального варианта)
//sealed - апрет наследования от класса