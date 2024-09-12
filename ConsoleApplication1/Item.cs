using System;

namespace ConsoleApplication1
{
    public class Item
    {
        public Item()
        {
            var random = new Random();
            Id = random.Next(0,10);
        }

        public Item(int id, string name)
        {
            this.Id = id;
            this.Name = name;
        }
        //get; set; - аксессоры, методы доступа
        public int Id { get; private set; }
        public string Name { get; set; }

        public virtual void SendNotification(string message) //виртуальные методы переопределяемы
        {
            Console.WriteLine(message);
        }
    }
}