using System;
using System.Net.NetworkInformation;
using System.Security.Cryptography;

namespace TEST
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Koosta neli funktsiooni, millest igaüks arvutab ja 
            //väljastab ühe geomeetrilise kujundi(ruut, 
            //ring või teemant, ristkylik, kolmnurk) 
            //kujundi "*" sümbolina(vastavalt võimalusele 
            //arvutab ja väljastab viimaks ka ümbermõõdu, 
            //pindala jne).Loo programm, mis küsib kasutajalt 
            //kujundi tüüpi sõna valikuna, kujundi andmeid
            //(vastavalt vajadusele külje pikkust, raadiust vms).
            //NB! Teemanti puhul arvutage ringi ümbermõõt ja pindala.
            //NB! Teemanti puhul arvutage ringi ümbermõõt ja pindala.
            Console.WriteLine("Sisesta kujundi number mida soovid valida: ");
            Console.WriteLine("1. Ruut");
            Console.WriteLine("2. Teemant");
            Console.WriteLine("3. Ristkülik");
            Console.WriteLine("4. Kolmnurk");

            try
            {
                string tehe = Console.ReadLine();
                switch (tehe)
            {
                case "1":
                    Square();
                    break;
                default:
                    break;
                }
            switch (tehe)
            {
                case "2":
                    Diamond();
                    break;
                default:
                    break;

            }
            switch (tehe)
            {
                case "3":
                    Rectangle();
                    break;
                default:
                        break;

                }
            switch (tehe)
            {
                case "4":
                    Kolmnurk();
                    break;
                default:
                    break;
            }

            }
            catch (FormatException)
            {
                Console.WriteLine("Vale numbri formaat.");

            }
            catch (OverflowException)
            {
                Console.WriteLine("ERROR. Sisestatud number on liiga suur.");
            }
        }


        private static void Square()
        {
            Console.WriteLine("Sisesta ruudu suurus");

            int size = Convert.ToInt32(Console.ReadLine());

            for (int row = 1; row <= size; row++)
            {
                for (int column = 1; column <= size; column++)
                {
                    string mark;
                    if (row == column || row + column <= size + 1)
                    {
                        mark = "*";
                    }
                    else
                    {
                        mark = "*";
                    }
                    Console.Write(mark);
                }
                Console.WriteLine();
            }
            Console.WriteLine("Ruudu ümbermõõt on " + size * 4 + " ja ruuduu pindala on " + size * size);
        }
        private static void Diamond()
        {
            Console.WriteLine("Sisesta Teemanti suurus");

            int row = Convert.ToInt32(Console.ReadLine());
            int j;

            for (int i = 0; i <= row; i++)
            {
                for (j = 1; j <= row - i; j++)
                {
                    Console.Write(" ");
                }
                for (j = 1; j <= 2 * i - 1; j++)
                {
                    Console.Write("*");
                }
                Console.Write("\n");
            }

            for (int i = row - 1; i >= 1; i--)
            {
                for (j = 1; j <= row - i; j++)
                {
                    Console.Write(" ");
                }
                for (j = 1; j <= 2 * i - 1; j++)
                {
                    Console.Write("*");
                }
                Console.Write("\n");
            }
            Console.WriteLine("teemanti ümbermõõt on " + row * 4 + " ja teemanti pindala on " + row * (((row * Math.Sqrt(3)) * 2) / 2) / 2);
        }
        private static void Rectangle()
        {
            Console.WriteLine("Sisesta ristküliku suurus");

            int size = Convert.ToInt32(Console.ReadLine());

            for (int row = 1; row <= size + 1; row++)
            {
                for (int column = 1; column <= size; column++)
                {
                    string mark;
                    if (row == column || row + column <= size + 1)
                    {
                        mark = "*";
                    }
                    else
                    {
                        mark = "*";
                    }
                    Console.Write(mark);
                }
                Console.WriteLine();
            }
            Console.WriteLine("ristküliku ümbermõõt on " + (size + (size + 1)) * 2 + " ja ristküliku pindala on " + size * (size + 1));
        }
        private static void Kolmnurk()

        {
            Console.WriteLine("Sisesta Kolmnurga suurus");

            int rows = Convert.ToInt32(Console.ReadLine());
            int spc = rows + 4 - 1;

            for (int i = 1; i <= rows; i++)
            {
                Console.Write("\n");
                for (int k = spc; k >= 1; k--)
                {
                    Console.Write(" ");
                }
                for (int j = 1; j <= i; j++)
                {
                    Console.Write("* ");
                }
                spc--;
            }

            Console.WriteLine();
            Console.WriteLine("Kolmnurga ümbermõõt on " + rows * 3 + " ja kolmnurga pindala on " + rows * (rows * Math.Sqrt(3) / 2) / 2);
        }
    }
}
