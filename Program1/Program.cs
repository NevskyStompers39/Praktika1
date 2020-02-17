using System;
namespace Program1
{
    class Program
    {// Здесь программа начинает работу
        static void Main(string[] args)
        {
            // Приглашение пользователю ввести свое имя
            Console.WriteLine("Введите ваше имя:");
            // Чтение введенного имени
            string name = Console.ReadLine();
            // Приветствие пользователя по имени
            Console.WriteLine("Привет, " + name);
            // Ожидание реакции пользователя
            Console.WriteLine("Нажмите <Enter> для входа...");
            Console.Read();
        }
    }
}
