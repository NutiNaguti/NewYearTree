using System;
using System.Threading;

namespace Tree
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.CursorVisible = false;
            MakeTree();
            Lights();
        }

        public static void MakeTree()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("               *         \r\n             _/ \\_      \r\n            \\     /      \r\n            /_' '_\\             A New Year is like a blank book, and the pen is in your hands. \r\n             /   \\              It is your chance to write a beautiful story for yourself.\r\n            /     \\             Happy New Year.4\r\n           /       \\     \r\n          /         \\    \r\n         /           \\   \r\n        * ----------- *  ");
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.Write("            [_____]\r\n             \\___/");
            Console.SetCursorPosition(8, 13);
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Happy New Year!\n             2020");
        }

        public static void Lights()
        {
            int[][] array = new int[6][]
            {
                new int[] {10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22},
                new int[] {11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21},
                new int[] {12, 13, 14, 15, 16, 17, 18, 19, 20},
                new int[] {13, 14, 15, 16, 17, 18, 19},
                new int[] {14, 15, 16, 17, 18},
                new int[] {15, 16, 17}
            };
            var X = 14;
            var Y = 4;
            var rand = new Random();
            char[] chars = new char[] { '.', '-', '+', '^', '°', '*' };
            for (int i = 0; ; i++)
            {
                switch (rand.Next(4, 9))
                {
                    case 4:
                        Console.SetCursorPosition(array[4][rand.Next(0, 3)], 4);
                        break;
                    case 5:
                        Console.SetCursorPosition(array[3][rand.Next(0, 5)], 5);
                        break;
                    case 6:
                        Console.SetCursorPosition(array[2][rand.Next(0, 7)], 6);
                        break;
                    case 7:
                        Console.SetCursorPosition(array[1][rand.Next(0, 9)], 7);
                        break;
                    case 8:
                        Console.SetCursorPosition(array[0][rand.Next(0, 11)], 8);
                        break;
                }

                switch (rand.Next(0, 7))
                {
                    case 0:
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        break;
                    case 1:
                        Console.ForegroundColor = ConsoleColor.DarkMagenta;
                        break;
                    case 2:
                        Console.ForegroundColor = ConsoleColor.Red;
                        break;
                    case 3:
                        Console.ForegroundColor = ConsoleColor.DarkYellow;
                        break;
                    case 4:
                        Console.ForegroundColor = ConsoleColor.Blue;
                        break;
                    case 5:
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        break;
                    case 6:
                        Console.ForegroundColor = ConsoleColor.Green;
                        break;
                }
                Console.Write(chars[i % 6]);
                Thread.Sleep(100);

                if (i != 0)
                {
                    // Delete the previous char by setting it to a space
                    switch (rand.Next(4, 9))
                    {
                        case 4:
                            Console.SetCursorPosition(array[4][rand.Next(0, 3)], 4);
                            break;
                        case 5:
                            Console.SetCursorPosition(array[3][rand.Next(0, 5)], 5);
                            break;
                        case 6:
                            Console.SetCursorPosition(array[2][rand.Next(0, 7)], 6);
                            break;
                        case 7:
                            Console.SetCursorPosition(array[1][rand.Next(0, 9)], 7);
                            break;
                        case 8:
                            Console.SetCursorPosition(array[0][rand.Next(0, 11)], 8);
                            break;
                    }
                    Console.Write(" ");
                }
            }
        }
    }
}
