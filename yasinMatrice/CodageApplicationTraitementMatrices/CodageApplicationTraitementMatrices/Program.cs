using System;
using System.Collections.Generic;
using System.Text;

namespace CodageApplicationTraitementMatrices
{
    class Program
    {
        static void Main(string[] args)
        {
            outils mesOutils = new outils();
            int choix;
            int ligne = 0;
            int colonne = 0;
            int[,] grille;
            string stringTab;
            int nbligne;
            int nbcolonne;
            int[,] t1;
            int[,] t2;
            int[,] t3;
            bool addition;
            int[,] matriceMulti;
            bool test;
            do
            {
                mesOutils.LireReel("quel matrices choississez-vous ? \n   1 = generation_tableau\n   2 = Addition_Matrices \n   3 = multiplication \n", out choix);

                if (choix == 1)
                {
                    mesOutils.LireReel("nombre de ligne : ", out nbligne);
                    mesOutils.LireReel("nombre de colonne : ", out nbcolonne);
                    mesOutils.Generation_Tableau(out grille, nbligne, nbcolonne );
                    mesOutils.String_Tableau( grille, out stringTab);
                    Console.WriteLine(stringTab);
                }
                if (choix == 2)
                {
                    mesOutils.LireReel("nombre de ligne : ", out nbligne);
                    mesOutils.LireReel("nombre de colonne : ", out nbcolonne);
                    mesOutils.Generation_Tableau(out t1, nbligne, nbcolonne);
                    mesOutils.String_Tableau(t1, out stringTab);
                    Console.WriteLine(stringTab);

                    mesOutils.LireReel("nombre de ligne : ", out nbligne);
                    mesOutils.LireReel("nombre de colonne : ", out nbcolonne);
                    mesOutils.Generation_Tableau(out t2, nbligne, nbcolonne);
                    mesOutils.String_Tableau(t2, out stringTab);
                    Console.WriteLine(stringTab);

                    mesOutils.Addition_Matrices(t1, t2, out t3, out addition, nbligne, nbcolonne);
                    mesOutils.String_Tableau(t3, out stringTab);
                    Console.WriteLine(stringTab);
                }
                if (choix == 3)
                {
                    mesOutils.LireReel("nombre de ligne : ", out nbligne);
                    mesOutils.LireReel("nombre de colonne : ", out nbcolonne);
                    mesOutils.Generation_Tableau(out t1, nbligne, nbcolonne);
                    mesOutils.String_Tableau(t1, out stringTab);
                    Console.WriteLine(stringTab);

                    mesOutils.LireReel("nombre de ligne : ", out nbligne);
                    mesOutils.LireReel("nombre de colonne : ", out nbcolonne);
                    mesOutils.Generation_Tableau(out t2, nbligne, nbcolonne);
                    mesOutils.String_Tableau(t2, out stringTab);
                    Console.WriteLine(stringTab);


                    mesOutils.multiplicationMatrice(t1, t2, out matriceMulti, out test, nbligne, nbcolonne);
                    mesOutils.String_Tableau(matriceMulti, out stringTab);
                    Console.WriteLine(stringTab);
                }
            } while (true);


        }
    }
    
}
