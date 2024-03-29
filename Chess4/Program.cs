﻿/*
*   Chess pieces 3 ver 3
*   With classes, factory and enum
*   DKY 25.04.2021 
*/

using System;

namespace Chess4
{
    class Program
    {
        static void Main(string[] args)
        {
            {
                string chess = Console.ReadLine();
                int x1 = Convert.ToInt32(Console.ReadLine());
                int y1 = Convert.ToInt32(Console.ReadLine());
                int x2 = Convert.ToInt32(Console.ReadLine());
                int y2 = Convert.ToInt32(Console.ReadLine());

                try
                {
                    Piece f = PieceMaker.Make(chess, x1, y1);
                    Console.WriteLine(f.Move(x2, y2) ? "YES" : "NO");
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }
    }
}
