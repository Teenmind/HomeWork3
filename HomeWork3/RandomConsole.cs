using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork3
{
    class RandomConsole
    {
        public static void RandomNumber()
        {
            Random rnd = new Random();
            Console.WriteLine(rnd.Next() + " ");
            Console.ReadKey();
        }

        public static void TenRandomNumbers()
        {
            Random rnd = new Random();
            for (int i = 0; i < 10; i++)
            {
                Console.Write(rnd.Next() + " ");
            }
            Console.WriteLine();
            Console.ReadKey();
        }

        private static void TenRandomNumbersFromXtoY(int x, int y)
        {
            Random rnd = new Random();
            for (int i = 0; i < 10; i++)
            {
                Console.Write(rnd.Next(x, y) + " ");
            }
            Console.WriteLine();
            Console.ReadKey();
        }

        public static void TenRandomNumbersFrom0to10()
        {
            TenRandomNumbersFromXtoY(0, 10);
            //Random rnd = new Random();
            //for (int i = 0; i < 10; i++)
            //{
            //    Console.Write(rnd.Next(0,10) + " ");
            //}
            //Console.WriteLine();
            //Console.ReadKey();
        }

        public static void TenRandomNumbersFrom20to50()
        {
            TenRandomNumbersFromXtoY(20, 50);
            //Random rnd = new Random();
            //for (int i = 0; i < 10; i++)
            //{
            //    Console.Write(rnd.Next(20, 50) + " ");
            //}
            //Console.WriteLine();
            //Console.ReadKey();
        }

        public static void TenRandomNumbersFromM10to10()
        {
            TenRandomNumbersFromXtoY(-10, 10);
            //Random rnd = new Random();
            //for (int i = 0; i < 10; i++)
            //{
            //    Console.Write(rnd.Next(-10, 10) + " ");
            //}
            //Console.WriteLine();
            //Console.ReadKey();
        }

        public static void From3to15RandomNumbersFromM10to35()
        {
            Random rnd = new Random();
            for (int i = 0; i < rnd.Next(3,15); i++)
            {
                Console.Write(rnd.Next(-10, 35) + " ");
            }
            Console.WriteLine();
            Console.ReadKey();
        }
    }
}
