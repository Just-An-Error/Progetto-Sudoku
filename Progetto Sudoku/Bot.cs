using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Progetto_Sudoku {
    internal class Bot {

        public static void Main(string[] args) {

            int[,] matriceModifiiabile = Matrice.matrice;
        }

        // Marco
        public void Avvio() { }

        // Shehan
        
        public bool ControlloRighe(int n, int riga, int[,] matrice) 
        {
            if (n >= 1 && n <= 9)
            {
                for (int i = 0; i <= 8; i++)
                {
                    if (matrice[riga, i] == n)
                    {
                        return false;
                    }
                }
                return true;
            }
            else
            {
                return false; 
            }
        }

        public bool ControlloColonne(int n, int col, int[,] matrice) 
        {
            if (n >= 1 && n <= 9)
            {
                for (int i = 0; i <= 8; i++)
                {
                    if (matrice[i, col] == n)
                    {
                        return false;
                    }
                }
                return true;
            }
            else
            {
                return false; 
            }
        }

        // Alessio
        public void ControlloBlocchi() { }
    }
}
