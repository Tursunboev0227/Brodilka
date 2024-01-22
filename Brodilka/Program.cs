using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Brodilka
{
    internal class Program
    {
        static void Main(string[] args)
        {

            char[,] map =
            {
                {'#','#','#','#','#','#','#','#','#','#','#','#','#','#'},
                {'#',' ','#',' ',' ',' ',' ',' ',' ',' ',' ',' ','$','#'},
                {'#',' ','#',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ','#'},
                {'#',' ','#',' ',' ',' ',' ',' ',' ','$',' ',' ',' ','#'},
                {'#',' ','#',' ','$',' ',' ',' ',' ',' ',' ',' ',' ','#'},
                {'#',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ','$','#'},
                {'#',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ','#'},
                {'#',' ',' ',' ',' ',' ',' ','#','#','#',' ',' ',' ','#'},
                {'#',' ','#',' ',' ',' ',' ','#',' ','#',' ',' ',' ','#'},
                {'#',' ','#',' ','$',' ',' ','#','$','#',' ',' ',' ','#'},
                {'#',' ','#',' ',' ',' ',' ','#',' ','#',' ',' ',' ','#'},
                {'#',' ','#',' ',' ',' ',' ','#',' ','#',' ',' ',' ','#'},
                {'#',' ','#','#','#','#',' ',' ',' ',' ',' ',' ',' ','#'},
                {'#','$',' ',' ',' ','#',' ',' ',' ','$',' ',' ',' ','#'},
                {'#',' ',' ',' ',' ','#',' ',' ',' ',' ',' ',' ',' ','#'},
                {'#',' ',' ',' ',' ','#',' ',' ',' ',' ',' ',' ',' ','#'},
                {'#','#','#','#','#','#','#','#','#','#','#','#','#','#'},
            };

            int userx = 6, usery = 6;

            char[] bag = new char[1];

            while (true)
            {
                Console.SetCursorPosition(0, 20);
                Console.Write("Bucket:  ");

                for(int i = 0; i < bag.Length; i++)
                {
                    Console.Write(bag[i] + " ");
                }

                Console.SetCursorPosition(0, 0);
                Console.CursorVisible = false;

                for (int i = 0; i < map.GetLength(0); i++)
                {
                    for (int j = 0; j < map.GetLength(1); j++)
                    {
                        Console.Write(map[i, j]);
                    }
                    Console.WriteLine();

                }
                Console.SetCursorPosition(usery, userx);
                Console.WriteLine("@");

                ConsoleKeyInfo charKey = Console.ReadKey();
                switch (charKey.Key)
                {
                    case ConsoleKey.UpArrow:
                        if (map[userx - 1, usery] != '#')
                        {
                            userx--;
                        }
                        
                        break;
                    case ConsoleKey.DownArrow:
                        if (map[userx + 1, usery] != '#')
                        {
                            userx++;
                        }
                        break;
                    case ConsoleKey.LeftArrow:
                        if (map[userx, usery - 1] != '#')
                        {
                            usery--;
                        }
                        break;
                    case ConsoleKey.RightArrow:
                        if (map[userx, usery + 1] != '#')
                        {
                            usery++;
                        }
                        break;
                }
                if(bag.Length == 9)
                {
                    Console.SetCursorPosition(0, 23);
                    Console.WriteLine("You won");
                    Console.ReadKey();
                    return;
                }
                if (map[userx,usery] == '$')
                {
                    map[userx, usery] = 'o';
                    char[] tempchar = new char[bag.Length + 1 ];
                    for(int i = 0; i < bag.Length; i++)
                    {
                        tempchar[i] = bag[i]; 
                    }
                    tempchar[tempchar.Length -1 ] = '$';
                    bag = tempchar;
                }
                Console.Clear();

            }

        }
    }
}
