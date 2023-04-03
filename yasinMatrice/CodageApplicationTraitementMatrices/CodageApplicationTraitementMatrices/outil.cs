using System;
using System.Collections.Generic;
using System.Text;

namespace CodageApplicationTraitementMatrices
{
    public void Main(string[] args)
    {
        outils mesOutils = new outils();
        int choix;
        int ligne = 0;
        int colonne = 0;
        int[,] grille = new int[ligne,colonne];
        int[] tableau;
        string aff;
        string stringTab;
        int[,] tab1;
        int[,] tab2;
        int[,] tab3;
        bool addition;
        int nombre;
        int min;
        int max;
        do
        {
            mesOutils.LireReel("quel matrices choississez-vous ? \n   1 = Generation_Tableau\n   2 = String_Tableau\n   3 =Addition_Matrices \n", out choix);
            mesOutils.LireReel("dimension de la matrice", out nombre);
            mesOutils.LireReel("min", out min);
            mesOutils.LireReel("max", out max);
            mesOutils.creationAleatoire(nombre, min, max, out tableau);

            if (choix == 1)
            {
                mesOutils.Generation_Tableau(out grille);
                mesOutils.affichage(tableau, out aff);
            }
            if (choix == 2)
            {
                mesOutils.String_Tableau(grille, out stringTab);
                mesOutils.affichage(tableau, out aff);
            }
            if (choix == 3)
            {
                mesOutils.Addition_Matrices(tab1, tab2, out tab3, out addition);
                mesOutils.affichage(tableau, out aff);
            }
        } while (true);
        
    }
}
