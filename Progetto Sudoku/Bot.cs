using System;
using System.Collections.Generic;
using System.Text;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Progetto_Sudoku {
    internal class Bot {

        public static void Main(string[] args) {

            int[,] matriceModificabile = Matrice.matrice;
            
        }

        // Marco
        public void Avvio(int n, int riga, int col) 
        {
            int[,] matriceModificabile = Matrice.matrice;
            for (int i = 0; i < 9; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    for (int numero = 1; numero < 9; numero++) 
                    {
                        if (Controllo && matriceModificabile[riga, col] == Matrice.matrice[riga,col] && matriceModificabile[riga,col] == 0)
                        {
                            matriceModificabile[riga, col] = n;
                        }
                        Console.Write(matriceModificabile?[i, j] + " ");
                    }
                }
                Console.WriteLine();
            }
        }

        // Shehan
        public void ControlloRighe() { }
        public void ControlloColonne() { }

        // Alessio
        public void ControlloBlocchi() { }
    }
}
