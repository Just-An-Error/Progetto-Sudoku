using System;
using System.Collections.Generic;
using System.Text;

namespace Progetto_Sudoku
{
    public class GiocoSudoku

    {
        public static void Main(string[] args)
        {
            bool avvio = true;
            while (avvio)
            {
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
                    Console.WriteLine("Scegli la riga");
                    int riga; 
                    int.TryParse(Console.ReadLine(), out riga);
                    Console.WriteLine("Scegli la colonna");
                    int colonna;
                    int.TryParse(Console.ReadLine(), out colonna);
                    Console.WriteLine("Scegli il numero tra 1 e 9");
                    int numero;
                    int.TryParse(Console.ReadLine(), out numero);

                }
                else if (scelta == 2)
                {
                    Console.WriteLine("Hai scelto modifica numero");
                    Console.WriteLine("Scegli la riga");
                    int riga;
                    int.TryParse(Console.ReadLine(), out riga);
                    Console.WriteLine("Scegli la colonna");
                    int colonna;
                    int.TryParse(Console.ReadLine(), out colonna);
                    Console.WriteLine("Scegli il numero tra 1 e 9");
                    int numero;
                    int.TryParse(Console.ReadLine(), out numero);

                }

                else if (scelta == 3)
                {
                    Console.WriteLine("Hai scelto controlla numemro");
                    Console.WriteLine("Scegli la riga");
                    int riga;
                    int.TryParse(Console.ReadLine(), out riga);
                    Console.WriteLine("Scegli la colonna");
                    int colonna;
                    int.TryParse(Console.ReadLine(), out colonna);
                    Console.WriteLine("Scegli il numero tra 1 e 9");
                    


                }
                else if (scelta == 4)
                {
                   avvio = false;
                }

                else
                {
                    Console.WriteLine("Valore non corretto");
                }
                Console.ReadKey();
            }
        }
    }
    }
