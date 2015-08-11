using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace $safeprojectname$
{
    class VerifXPuits
    {
        public int i { get; set; }
        public int j { get; set; }
        Boolean verif=true;
        int n = 2;
        private int p;
        private int[,] Matrice_de_g;

        public VerifXPuits(int p, int[,] Matrice_de_g)
        {
            // TODO: Complete member initialization
            this.p = p;
            this.Matrice_de_g = Matrice_de_g;
        }
       
        //verifer tout les sommet d'un graphe 
        public void verifXPuit()
        {
            for (i=1;i<=n;i++)
            {
                for ( j = 1; j <= n; j++)
                {
                    if (Matrice_de_g[i, j] == 1)
                    {
                        verif = false;
                        break;
                    }
                }
                if(verif)
                {
                    Console.WriteLine("sommet " + i + "est une puit.");
                }
            }
                
        }
    }
}
