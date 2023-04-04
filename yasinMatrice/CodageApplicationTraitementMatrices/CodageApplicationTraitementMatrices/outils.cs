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
                    grille[ligne, colonne] = alea.Next(0, 20);
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
                stringTab += "\n";
            }

            
        }

        
    }
}
