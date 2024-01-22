using System;
using System.ComponentModel.Design;
using System.Drawing;
using System.Threading;

namespace Cronometro
{
    class Program
    {
        static int limite;
        static short input;

        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            DateTime horaAtual = DateTime.Now;
            Console.WriteLine("Hora Atual: " + horaAtual.ToString("HH:mm:ss\n"));
            Console.ResetColor();

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("PROJETO CRONÔMETRO");
            Console.ResetColor();

            Menu();
        }

        static void Menu()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("1 - Cronômetro progressivo em segundos\n2 - Cronômetro regressivo em segundos\n3 - Cronômetro regressivo em minutos\n4 - Cronômetro regressivo em horas\n0 - Sair\n");
            Console.Write("Escolha uma opção: ");
            input = short.Parse(Console.ReadLine());
            OpcaoMenu();
        }

        static void OpcaoMenu()
        {
            switch (input)
            {
                case 0:
                    Exit();
                    break;
                case 1:
                    Console.Clear();
                    Repeticao();
                    break;
                case 2:
                    Console.Clear();
                    TempoEmSegundos();
                    break;
                case 3:
                    Console.Clear();
                    TempoEmMinutos();
                    break;
                case 4:
                    Console.Clear();
                    TempoEmHoras();
                    break;
                default:
                    Console.WriteLine("\nInsira uma opção válida");
                    Thread.Sleep(1000);
                    Console.Clear();
                    Menu();
                    break;
            }
        }

        static void Repeticao()
        {
            int tempo = 0;
            Console.Write("Insira o tempo limite em segundos: ");
            limite = int.Parse(Console.ReadLine());
            Console.Clear();

            while (tempo <= limite)
            {
                var tempoRestante = TimeSpan.FromSeconds(tempo);
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("Tempo restante: " + tempoRestante.ToString("hh\\:mm\\:ss"));
                Console.ResetColor();
                tempo++;
                Thread.Sleep(1000);
                Console.Clear();
            }

            Saida();
        }

        static void Saida()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Fim do tempo");
            Thread.Sleep(2000);
            Console.ResetColor();
            Console.Clear();
            Menu();
        }

        static void Exit()
        {
            Console.WriteLine("Aplicação criada por Gabriel Lemes de Oliveira");
            Console.WriteLine("\nObrigado!");
            Thread.Sleep(3000);
            System.Environment.Exit(0);
        }

        static void TempoEmSegundos()
        {
            Console.Write("Informe o tempo em segundos");
            int segundos = int.Parse(Console.ReadLine());
            Console.Clear();

            while (segundos > 0)
            {
                TimeSpan tempoRestante = TimeSpan.FromSeconds(segundos);
                Console.WriteLine("Tempo Restante: " + tempoRestante.ToString("hh\\:mm\\:ss"));
                segundos--;
                Thread.Sleep(1000);
                Console.Clear();
            }
            Saida();
        }

        static void TempoEmMinutos()
        {
            Console.Write("Informe o tempo em minutos: ");
            int minutos = int.Parse(Console.ReadLine());
            Console.Clear();

            int minutoConvertido = minutos * 60;

            while (minutoConvertido > 0)
            {
                TimeSpan tempoRestante = TimeSpan.FromSeconds(minutoConvertido);
                Console.WriteLine("Tempo restante: " + tempoRestante.ToString("hh\\:mm\\:ss"));
                minutoConvertido--;
                Thread.Sleep(1000);
                Console.Clear();
            }
            Saida();
        }
        static void TempoEmHoras()
        {
            Console.Write("Informe o tempo em horas: ");
            int horas = int.Parse(Console.ReadLine());
            var horasConvertido = (horas * 60) * 60;
            Console.Clear();

            while (horasConvertido > 0)
            {
                TimeSpan tempoRestante = TimeSpan.FromSeconds(horasConvertido);
                Console.WriteLine("Tempo restante: " + tempoRestante.ToString("hh\\:mm\\:ss"));
                horasConvertido--;
                Thread.Sleep(1000);
                Console.Clear();
            }
            Saida();
        }
    }
}