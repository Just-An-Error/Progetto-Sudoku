using System;
using System.Collections.Generic;
using System.Text;

namespace Progetto_Sudoku
{
    internal class GiocoSudoku

    {
        static void Main(string[] args)
        {
            int[,] matriceModificabile = Matrice.matrice;
            Console.WriteLine("Ciao, benvenuto nel sudoku, aggiungi numero, modifica numero, controlla numero, esci");
            Console.WriteLine("1. Aggiungi numero");
            Console.WriteLine("2. Modifica numero");
            Console.WriteLine("3. Controlla numero");
            Console.WriteLine("4. Esci");


            Console.WriteLine("Inserisci comando");
            int scelta;
            int.TryParse(Console.ReadLine(), out scelta);

            if (scelta == 1)
            {
                Console.WriteLine("Hai scelto aggiungi numero");


            }
            else if (scelta == 2)
            {
                Console.WriteLine("Hai scelto modifica numero");
            }

            else if (scelta == 3)
            {
                Console.WriteLine("Hai scelto controlla numemro");
            }
            else if (scelta == 4)
            {
                Console.WriteLine("Hai scelto esci");
            }
            Console.ReadKey();
    }
    }
}
