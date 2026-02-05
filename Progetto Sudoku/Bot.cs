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
        
        public static bool ControlloRighe(int n, int riga, int[,] matrice) 
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

        public static bool ControlloColonne(int n, int col, int[,] matrice) 
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
        public static bool ControlloBlocchi(int valoreBot, int riga, int col, int[,] matrice) {

            int[] coordinateCol = new int[3];
            int[] coordinateRiga = new int[3];

            // Controllo se le coordinate siano sbagliate
            if (riga < 0 || riga > 8 || riga < 0 || riga > 8) 
                return false;

            // Controllo per individuare in quale blocco è la cordinata riga
            if (riga < 3) { 
            
                // La riga è nel primo blocco
                coordinateRiga[0] = 0;
                coordinateRiga[1] = 1;
                coordinateRiga[2] = 2;
            } else if (riga >= 3 && riga < 6) {

                // La riga è nel secondo blocco
                coordinateRiga[0] = 3;
                coordinateRiga[1] = 4;
                coordinateRiga[2] = 5;
            } else if (riga >=6) {

                // La riga è nel terzo blocco
                coordinateRiga[0] = 6;
                coordinateRiga[1] = 7;
                coordinateRiga[2] = 8;
            }

            // Controll per individuare in quale blocco è la cordinata col
            if (col < 3) {
                
                // La colonna è nel primo blocco
                coordinateCol[0] = 0;
                coordinateCol[1] = 1;
                coordinateCol[2] = 2;
            } else if (col >= 3 && col < 6) {

                // La colonna è nel secondo blocco
                coordinateCol[3] = 3;
                coordinateCol[4] = 4;
                coordinateCol[5] = 5;
            } else if (col >= 6) {

                // La colonna è nel terzo blocco
                coordinateCol[6] = 6;
                coordinateCol[7] = 7;
                coordinateCol[8] = 8;
            }

            int[,] bloccoTemporaneo =
            {
                // Creazione riga 1
                {
                    matrice[coordinateRiga[0], coordinateCol[0]],
                    matrice[coordinateRiga[0], coordinateCol[1]],
                    matrice[coordinateRiga[0], coordinateCol[2]]
                },
                // Creazione Riga 2
                {
                    matrice[coordinateRiga[1], coordinateCol[0]],
                    matrice[coordinateRiga[1], coordinateCol[1]],
                    matrice[coordinateRiga[1], coordinateCol[2]]
                },
                // Creazione Riga 3
                {
                    matrice[coordinateRiga[2], coordinateCol[0]],
                    matrice[coordinateRiga[2], coordinateCol[1]],
                    matrice[coordinateRiga[2], coordinateCol[2]]
                }
            };

            // Controllo vero e proprio
            for (int y = 0; y < 3; y += 1) {

                for (int x = 0; x < 3; x += 1) {

                    // se vengono trovati due numeri uguali OLTRE al numero nella stessa posizione, vuoldire che ci sono due duplicati, restituirà false
                    if (bloccoTemporaneo[y, x] == valoreBot /*&& y != riga && x != col*/)
                        return false;
                }
            }

            // Nel caso non entra nella condizione del false, restituirà che nel blocco è giusto
            return true;
        }

        public static bool Controllo(int valoreBot, int riga, int col, int[,] matrice) {

            return ControlloRighe(valoreBot, riga, matrice) && ControlloColonne(valoreBot, col, matrice) && ControlloBlocchi(valoreBot, riga, col, matrice); 
        }
    }
}
