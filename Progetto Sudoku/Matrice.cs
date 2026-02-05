using System;
using System.Collections.Generic;
using System.Text;

namespace Progetto_Sudoku
{
    internal static class Matrice
    {
        public static int[,] matrice =
        {
            {5 , 3, 0, 0, 7, 0, 0, 0, 0 },
            {6, 0, 0, 1, 9, 5, 0, 0, 0 },
            {0, 9, 8, 0, 0, 0, 0, 6, 0 },
            {8, 0, 0, 0, 6, 0, 0, 0, 3 },
            {4, 0, 0, 8, 0, 3, 0, 0, 1 },
            {7, 0, 0, 0, 2, 0, 0, 0, 6 },
            {0, 6, 0, 0, 0, 0, 2, 8, 0 },
            {0, 0, 0, 4, 1, 9, 0, 0, 5 },
            {0, 0, 0, 0, 8, 0, 0, 7, 9 },
        };

        public static int[,] matriceModificabile = (int[,])matrice.Clone();
        public static void StampaMatrice()
        {
            for (int i = 0; i < 9; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    Console.Write(matriceModificabile[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
        
    }
}
