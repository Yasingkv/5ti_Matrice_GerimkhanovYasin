using System;

namespace CodageApplicationTraitementMatrices
{
    public struct outils
    {

        public void LireReel(string question, out int n)
        {
            string nUser;
            Console.Write(question);
            nUser = Console.ReadLine();
            while (!int.TryParse(nUser, out n))
            {
                Console.WriteLine("Attention ! vous devez taper un nombre réel !");
                nUser = Console.ReadLine();
            }
        }

        public void affichage(int[] tableau, out string aff)
        {
            aff = "";
            for (int i = 0; i < tableau.Length; i++)
            {
                aff = aff + tableau[i] + "|";
            }
        }

        public void creationAleatoire(int nombre, int max, int min, out int[] tableau)
        {
            tableau = new int[nombre];
            Random alea = new Random();
            for (int i = 0; i < tableau.Length; i++)
            {
                tableau[i] = alea.Next(min, max + 1);
            }
        }
        public void Generation_Tableau(out int[,] grille)
        {
            int ligne = 0;
            int colonne = 0;
            grille = new int[ligne, colonne];
            for (ligne = 0; ligne < grille.GetLength(0)-1; ligne++)
            {
                for (colonne = 0; colonne < grille.GetLength(1)-1; colonne++)
                {
                    grille[ligne, colonne] = alea(0, 20);
                }
            }
        }

        public void String_Tableau(int[,] grille, out string stringTab)
        {
            stringTab = "";
            for (int ligne = 0; ligne < grille.GetLength(0)-1; ligne++)
            {
                for (int colonne = 0; colonne < grille.GetLength(1)-1; colonne++)
                {
                    stringTab += grille[ligne, colonne] + "|";
                }
            }
            stringTab[ligne, colonne] = "\n";
        }

        public void Addition_Matrices(int[,] tab1, int[,] tab2, out int[,] tab3, out bool addition)
        {
            int ligne;
            int colonne;
            tab1 = new int[ligne, colonne];
            tab2 = new int[ligne, colonne];
            addition = true;
            if (tab1.GetLength(0) == tab2.GetLength(0) && tab1.GetLength(1) == tab2.GetLength(1))
            {
                for (int ligne = 0; ligne < tab1.GetLength(0)-1; ligne++)
                {
                    for (int colonne = 0; colonne < tab1.GetLength(1)-1; colonne++)
                    {
                        tab3[ligne, colonne] += tab1[ligne, colonne] + tab2[ligne, colonne];
                    }
                }
            }
        }
    }
}
