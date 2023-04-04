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
            do
            {
                mesOutils.LireReel("quel matrices choississez-vous ? \n   1 = generation_tableau\n   2 = concatenation \n   3 =Addition_Matrices \n  4 = multiplication \n", out choix);

                if (choix == 1)
                {
                    mesOutils.LireReel("ligne", out nbligne);
                    mesOutils.LireReel("colonne", out nbcolonne);
                    mesOutils.Generation_Tableau(out grille, nbligne, nbcolonne );
                    mesOutils.String_Tableau( grille, out stringTab);
                    Console.WriteLine(stringTab);
                }
                if (choix == 2)
                {
                    
                }
                if (choix == 3)
                {
                    
                }
            } while (true);

        }
    }
    
}
