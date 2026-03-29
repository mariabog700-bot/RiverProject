using System;
namespace RiverProject
{
    class Reka
    {
        public string Nazvanie;
        public double PloshadBasseyna;
        public double Protyazhennost;

        public Reka(string nazvanie, double ploshad, double protyazh)
        {
            Nazvanie = nazvanie;
            PloshadBasseyna = ploshad;
            Protyazhennost = protyazh;
        }

        public void VivestiInfo()
        {
            Console.WriteLine($"Река: {Nazvanie}");
            Console.WriteLine($"Площадь бассейна: {PloshadBasseyna} км2");
            Console.WriteLine($"Протяжённость: {Protyazhennost} км");
            Console.WriteLine("---------------------");
        }

    }

    class Program
    {
        static void Main(string[] args)
        {
            Reka volga = new Reka("Волга", 1360000, 3530);
            Reka amazonka = new Reka("Амазонка", 6915000, 6400);

            volga.VivestiInfo();
            amazonka.VivestiInfo();

            Console.WriteLine("Тестирование завершено — коммит №2");
            Console.WriteLine("Тестирование завершено — коммит №3"); //апапа
            Console.ReadKey();
        }
    }
}