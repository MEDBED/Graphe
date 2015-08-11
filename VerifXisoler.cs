using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace $safeprojectname$
{
    class VerifXisoler
    {
        public int p,i,j,soml=0,somc=0;
        private int[,] Matrice_de_g;
        public VerifXisoler(int p, int[,] Matrice_de_g,int i,int j)
        {
            // TODO: Complete member initialization
            this.p = p;
            this.Matrice_de_g = Matrice_de_g;
            this.i=i;
            this.j = j;
        }

        public void isoler()
        {
            int k = i;
            while(k<p)
            {
                soml = soml + Matrice_de_g[k, j];
                k++;
            }
            while (j < p)
            {
                somc = somc + Matrice_de_g[i, j];
                j++;
            }
            if((soml+somc)==0)
            {
                Console.WriteLine("le point isoler");
            }
        }
       
        
    }
}
