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

        
        public void Generation_Tableau(out int[,] grille , int nbligne ,int nbcolonne)
        {
            Random alea = new Random();

            grille = new int[nbligne, nbcolonne];
            for (int ligne = 0; ligne  <= nbligne - 1; ligne++)
            {
                for (int colonne = 0; colonne <= nbcolonne - 1; colonne++)
                {
                    grille[ligne, colonne] = alea.Next(0, 10);
                }
            }
        }

        public void String_Tableau(int[,] grille, out string stringTab)
        {
            
            stringTab = "";
            for (int ligne = 0; ligne < grille.GetLength(0); ligne++)
            {
                for (int colonne = 0; colonne < grille.GetLength(1); colonne++)
                {
                    stringTab += grille[ligne, colonne] + "  |  ";
                }
                stringTab += "\n";
            }

            
        }
        public void Addition_Matrices(int[,] t1, int[,] t2, out int[,] t3, out bool addition, int nbLigne, int nbColonne)
        {
            t3 = new int[nbLigne, nbColonne];
            addition = true;
            if (t1.GetLength(0) == t2.GetLength(0) && t1.GetLength(1) == t2.GetLength(1))
            {
                for (nbLigne = 0; nbLigne < t1.GetLength(0) - 1; nbLigne++)
                {
                    for (nbColonne = 0; nbColonne < t1.GetLength(1) - 1; nbColonne++)
                    {
                        t3[nbLigne, nbColonne] += t1[nbLigne, nbColonne] + t2[nbLigne, nbColonne];
                    }
                }
            }
        }

        public void multiplicationMatrice(int[,] t1, int[,] t2, out int[,] matriceMulti, out bool test, int nbLigne, int nbColonne)
        {
            matriceMulti = new int[nbLigne, nbColonne];
            test = true;
            if (t1.GetLength(1) == t2.GetLength(0))
            {
                for (int ligne = 0; ligne < t1.GetLength(0) - 1; ligne++)
                {
                    for (int colonne = 0; colonne < t1.GetLength(1) - 1; colonne++)
                    {
                        matriceMulti[ligne, colonne] = 0;
                        for (int i = 0; i < t1.GetLength(1) - 1; i++)
                        {
                            matriceMulti[ligne, colonne] += t1[ligne, i] * t2[i, colonne];
                        }
                    }
                }
                test = false;
            }
        }


    }
}
