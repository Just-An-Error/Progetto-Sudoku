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

        
        public static void StampaMatrice(int[,] matriceMod)
        {
            for (int i = 0; i < 9; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    Console.Write(matriceMod[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
        public static bool AggiungiNumero(int numero, int riga, int colonna, int[,] matriceMod)
        {
            if (matriceMod[riga, colonna] != 0)
            {
                Console.WriteLine("Esiste già un numero in questa posizione");
                return false; 
            }
            matriceMod[riga, colonna] = numero;
            Console.SetCursorPosition(colonna * 2, riga);
            Console.Write(numero + " ");
            Console.SetCursorPosition(0, 11);
            Console.WriteLine("Numero Inserito!");
            return true;
        }

        public static bool ModificaNumero(int numero, int riga, int colonna, int[,] matriceMod)
        {
            if (matrice[riga, colonna] != 0)
            {
                Console.WriteLine("Questo Numero fa parte della tabella base non puoi modificarlo");
                return false;
            }
            if (matriceMod[riga, colonna] == 0)
            {
                Console.WriteLine("Il numero è 0, non si puo modificare");
                return false;
            }
            matriceMod[riga, colonna] = numero;
            Console.SetCursorPosition(colonna * 2, riga);
            Console.Write(numero + " ");
            Console.SetCursorPosition(0, 11);
            Console.WriteLine("Numero Modificato con successo!");
            return true;
        }
    }
}
