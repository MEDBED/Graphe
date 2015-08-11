using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace $safeprojectname$
{
    class GenererGra
    {
        public  int p=0;
        // Multidimensional array
        int[,] M = new int[100,100];
        public GenererGra(int p)
        {
            // TODO: Complete member initialization
            this.p = p;
            
        }
        
        // generer la grphe non orienter
        public int[,] genere_graphe(int p)
        {
            Random r = new Random();
            for (int i = 0; i < p;i++)
            {
                for(int j=0;j<p;j++)
                {
                    M[i, j] = r.Next(0, 10);
                }
            }
            return M;

        }
        //afficher la Mtrice du graphe
      public void affiche_matrice(int p)
        {
            for (int i = 0; i < p; i++)
            {
                Console.Write("\t\t\t");
                for (int j = 0; j < p; j++)
                {

                    Console.Write("["+M[i, j]+"]"); 
                }
                Console.WriteLine();
            }
        }

    }
}
