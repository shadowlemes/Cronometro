using System;
using System.Threading;


namespace Stopwhatch
{
    class Program()
    {
        static void Main()
        {
            Menu();
        }
        static void Menu()
        {
            Console.Clear();
            Console.WriteLine("S = Segundos => ex: 10s = 10segundos");
            Console.WriteLine("M = Minutos => ex: 1m = 1minuto");
            Console.WriteLine("0 = Sair");
            Console.WriteLine("\nQuanto tempo deseja contar? (ex: 10s ou 2m");

            string data = Console.ReadLine().ToLower();
            char type = char.Parse(data.Substring(data.Length - 1, 1));
            int time = int.Parse(data.Substring(0, data.Length - 1));
            int multiplier = 1;

            if (type == 'm')
                multiplier = 60;

            if (time == 0)
                Exit();
            

            PreStart(time * multiplier);
        }
        static void Exit()
        {
            Console.WriteLine("Aplicação feita por Gabriel Lemes de Oliveira");
            System.Environment.Exit(0);
        }
        static void PreStart(int time)
        {
            Console.Clear();
            Console.WriteLine("Ready...");
            Thread.Sleep(1000);
            Console.WriteLine("Set...");
            Thread.Sleep(1000);
            Console.WriteLine("Go!!!");

            Start(time);
        }
        static void Start(int time)
        {
            int currenteTime = 0;

            while (currenteTime != time)
            {
                Console.Clear();
                currenteTime++;
                Console.Write(currenteTime);
                Thread.Sleep(1000);
            }

            Console.Clear();
            Console.WriteLine("StopWhatch finalizado.");
            Thread.Sleep(2000);
            Menu();
        }
    }
}