using System;
using System.Threading;

namespace StopWatch
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu();
        }
        static void Menu()
        {
            Console.Clear();
            Console.WriteLine("--------------------");
            Console.WriteLine("Seja bem vindo(a)!\n");
            Console.WriteLine("S = Segundos => 10s = 10 segundos");
            Console.WriteLine("M = Minutos => 10m = 10 minutos");
            Console.WriteLine("0 = Sair => 0s ");
            Console.WriteLine("--------------------\n");
            Console.WriteLine("Até quanto deseja Contar?\n");

            string data = Console.ReadLine().ToLower();
            char type = char.Parse(data.Substring(data.Length - 1, 1));
            int time = int.Parse(data.Substring(0 , data.Length - 1));
            int multiplier = 1;
            switch(type)
            {
                case 's' : multiplier = 1; break;
                case 'n' : multiplier = 60; break;
                default : InvalidType(); break;
            }
            if(time == 0)
            {
                Console.WriteLine("Finalizando StopWatch...");
                Thread.Sleep(2000);
                System.Environment.Exit(0);
            }
            PreStart(time * multiplier);
        }
        static void Start(int time)
        {
            int currentTime = 0;

            while(currentTime != time)
            {
                Console.Clear();
                currentTime++;
                Console.WriteLine(currentTime);
                Thread.Sleep(1000);          
            }
            Console.Clear();
            Console.WriteLine("StopWatch finalizado.");
            Thread.Sleep(3000);
            Menu();
        }
        static void PreStart(int time)
        {
            Console.WriteLine("Ready...");
            Thread.Sleep(1000);
            Console.WriteLine("Set...");
            Thread.Sleep(1000);
            Console.WriteLine("Go!");
            Thread.Sleep(2000);

            Start(time);

        }
        static void InvalidType()
        {
            Console.WriteLine("Tipo inválido!\n");
            Console.WriteLine("Utilize S para segundos e M para minutos.");
            Console.WriteLine("Pressione Enter para voltar ao Menu.");
            Console.ReadKey();
            Menu();
        }
    }
}