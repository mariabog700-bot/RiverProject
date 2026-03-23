using System;

namespace RiverProject
{
    // === НАШ КЛАСС ===
    class Reka
    {
        // Атрибуты (поля)
        public string Nazvanie;
        public double PloshadBasseyna;
        public double Protyazhennost;

        // Конструктор с параметрами (то, что требует практика)
        public Reka(string nazvanie, double ploshad, double protyazh)
        {
            Nazvanie = nazvanie;
            PloshadBasseyna = ploshad;
            Protyazhennost = protyazh;
        }

        // Метод для красивого вывода
        public void VivestiInfo()
        {
            Console.WriteLine($"Река: {Nazvanie}");
            Console.WriteLine($"Площадь бассейна: {PloshadBasseyna} км²");
            Console.WriteLine($"Протяжённость: {Protyazhennost} км");
            Console.WriteLine("---------------------");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Создаём два объекта
            Reka volga = new Reka("Волга", 1360000, 3530);
            Reka amazonka = new Reka("Амазонка", 6915000, 6400);

            volga.VivestiInfo();
            amazonka.VivestiInfo();

            Console.ReadKey(); // чтобы окно не закрылось сразу
        }
    }
}

//"E:\Вижла очищай а\RiverProject"