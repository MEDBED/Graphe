using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace $safeprojectname$
{
    class VerifComplet
    {
        int N;
        int[] arr1 = new int[100];
        private int[,] Matrice_de_g;
        public VerifComplet(int N, int[,] Matrice_de_g)
        {
            // TODO: Complete member initialization
            this.N = N;
            this.Matrice_de_g = Matrice_de_g;
        }
        public int som;
        public void verifgraphecomplet()
        {
            for(int i=0;i<=N;i++)
            {
                for(j=0;j<=N;j++)
                {
                    som = som + Matrice_de_g[i, j];
                }
                arr1[i] = som;
            }
            for(i=0;i<=N;i++)
            {
                if(arr1[i]<N-1)
                {
                    Console.WriteLine("graphe non complet");
                    break;
                }
            }
            if (i>= N)
            {
                Console.WriteLine("graphe non complet");
            }


        }

        public int i { get; set; }
        public int j { get; set; }
    }
}
