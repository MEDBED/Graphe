using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace $safeprojectname$
{
    class Program
    {
        static void Main(string[] args)
        {
            string fermer="non";
            while(fermer!="oui")
            {
                switch (fermer)
                {
                    case "non":
                        Console.WriteLine("------Menue---------");
                        Console.WriteLine("1-Graphe orienté");
                        Console.WriteLine("2-Graphe non orienté");
                        Console.WriteLine("---------------------");
                        Console.WriteLine("Choisissez le type du graphe SVP :");
                        string ChoixDeGraphe = Console.ReadLine();
                        Console.Clear();
                        if (ChoixDeGraphe == "1")
                        {
                            //générer un graphe non orienté simple d'ordre n
                            Console.WriteLine("saissire le nombre de sommet du graphe");
                            string N = Console.ReadLine();
                            GenGraOrian g_o = new GenGraOrian(int.Parse(N));
                            int[,] Matrice_de_g = g_o.genere_graphe_orian(int.Parse(N));
                            Console.Clear();
                            Console.WriteLine("\t***********Matrice du Graphe **************");
                            g_o.affiche_matrice_orian(int.Parse(N));
                            Console.WriteLine("\t********************************************");
                            //Console.Clear();
                            //--------------------------------------------------------
                            string quitter = "a";
                            while (quitter != "q")
                            {
                                //Menu in order to test all the functions
                                Console.WriteLine("--------------Liste des Foction--------------");
                                Console.WriteLine("1)-degre_moins ");
                                Console.WriteLine("2)-degre_plus ");
                                Console.WriteLine("3)-ordre de graphe ");
                                Console.WriteLine("4)-densité d'un graphe ");
                                Console.WriteLine("5)-taille de graphe ");
                                Console.WriteLine("6)-successeurs de x");
                                Console.WriteLine("7)-verifer graphe simple");
                                Console.WriteLine("8)-verifier graphe complet ");
                                Console.WriteLine("9)-verier que x est une source ");
                                Console.WriteLine("10)-verier que x est une puit ");
                                Console.WriteLine("11)-dire si un sommet x est un point isolé");
                                Console.WriteLine("12)-ordonnancer graphe");
                                Console.WriteLine("13)-le nombre de chemins entre deux sommets source xi et destination xj donnés.");
                                Console.WriteLine("14)-le plus court chemin entre deux sommets source xi et destination xj donnés.");
                                Console.WriteLine("15)-les plus courts chemins entre une source et tous les autres sommets.");
                                Console.WriteLine("16)-Verifier si le graphe est fortement connexe.");
                                Console.WriteLine("17)-Verifier si le graphe est une arbre.");
                                Console.WriteLine("--------------------------------------------------");
                                Console.WriteLine("Choisissez la fonction à tester SVP ");
                                string choix = Console.ReadLine();
                                Console.Clear();
                                switch (choix)
                                {
                                    case "1":
                                        //test function 1
                                        DegMoinDeX deg_moin_g = new DegMoinDeX();
                                        break;
                                    case "2":
                                        //test function 2
                                        DegPlusDeX deg_plus_g = new DegPlusDeX();
                                        break;
                                    case "3":
                                        //test function 3
                                        OrdreGra Ordre_g = new OrdreGra(int.Parse(N));
                                        Ordre_g.OrdreGraphe();
                                        break;
                                    case "4":
                                        //test function 4
                                        DensiteGra den_g = new DensiteGra();
                                        break;
                                    case "5":
                                        //test function 5
                                        TailleGra t_g = new TailleGra(int.Parse(N), Matrice_de_g);
                                        break;
                                    case "6":
                                        //test function 6
                                        SuccesseursSom ss = new SuccesseursSom();
                                        break;
                                    case "7":
                                        //test function 7
                                        VerifSimple verif_g_simple = new VerifSimple(int.Parse(N), Matrice_de_g);
                                        break;
                                    case "8":
                                        //test function 8
                                        VerifComplet verif_complet = new VerifComplet(int.Parse(N), Matrice_de_g);
                                        break;
                                    case "9":
                                        //test function 9
                                        VerifXSource verif_x_source = new VerifXSource();
                                        break;
                                    case "10":
                                        //test function 10
                                        VerifXPuits verf_x_puit = new VerifXPuits(int.Parse(N), Matrice_de_g);
                                        break;
                                    case "11":
                                        //test function 11
                                        Console.WriteLine("saisir xi:");
                                        int i = int.Parse(Console.ReadLine());
                                        Console.WriteLine("saisir xj:");
                                        int j = int.Parse(Console.ReadLine());
                                        VerifXisoler verif_x_isoler = new VerifXisoler(int.Parse(N), Matrice_de_g,i,j);
                                        break;
                                    case "12":
                                        //test function 12
                                        OrdonancerGra Ordonancer_g = new OrdonancerGra(int.Parse(N), Matrice_de_g);
                                        break;
                                    case "13":
                                        //test function 13
                                        DonnerNombreDeCheminEntreXetY nbr_ch_de_x_a_g = new DonnerNombreDeCheminEntreXetY();
                                        break;
                                    case "14":
                                        //test function 14
                                        DonnerPlusCourtChemin Plus_Cour_Chemin = new DonnerPlusCourtChemin();
                                        break;
                                    case "15":
                                        //test function 15
                                        DonnerLesPlusCourtCheminDeXiVersToutLesYj p_c_ch_de_x_a_tout_yj = new DonnerLesPlusCourtCheminDeXiVersToutLesYj();
                                        break;
                                    case "16":
                                        //test function 16
                                        VerifFortementConnexe verif_g_for_conexe = new VerifFortementConnexe();
                                        break;
                                    case "17":
                                        //test function 17
                                        VerifArbre verif_arbre = new VerifArbre();
                                        break;                                        
                                    default:
                                        Console.WriteLine("Choix incorrecte");
                                        break;
                                }
                                Console.WriteLine("saisir la lettre q si vous vouler quitter le menux des fonction SVP ! ");
                                quitter = Console.ReadLine();
                                Console.Clear();
                            }
                        }
                        else
                        {
                            //générer un graphe non orienté simple d'ordre n
                            Console.WriteLine("saissire le nombre de sommet du graphe");
                            string N = Console.ReadLine();
                            GenererGra g_non_o = new GenererGra(int.Parse(N));
                            int[,] Matrice_de_g = g_non_o.genere_graphe(int.Parse(N));
                            Console.Clear();
                            Console.WriteLine("\t***********Matrice du Graphe **************");
                            g_non_o.affiche_matrice(int.Parse(N));
                            Console.WriteLine("\t********************************************");
                            //Console.Clear();
                            //--------------------------------------------------------

                            string quitter = "a";
                            while (quitter != "q")
                            { //Menu in order to test all the functions
                                Console.WriteLine("--------------Liste des Foction--------------");
                                Console.WriteLine("1)-degre d'une sommet ");
                                Console.WriteLine("2)-ordre de graphe ");
                                Console.WriteLine("3)-densité d'un graphe ");
                                Console.WriteLine("4)-taille de graphe");
                                Console.WriteLine("5)-verifer graphe simple");
                                Console.WriteLine("6)-verifier graphe complet ");
                                Console.WriteLine("7)-dire si un sommet x est un point isolé");
                                Console.WriteLine("8)-ordonnancer graphe");
                                Console.WriteLine("9)-le nombre de chemins entre deux sommets source xi et destination xj donnés. ");
                                Console.WriteLine("10)-le plus court chemin entre deux sommets source xi et destination xj donnés.");
                                Console.WriteLine("11)-Verifier si le graphe est fortement connexe.");
                                Console.WriteLine("12)-Verifier si le graphe est une arbre.");
                                Console.WriteLine("--------------------------------------------------");
                                Console.WriteLine("Choisissez la fonction à tester SVP ");
                                string choix = Console.ReadLine();
                                Console.Clear();
                                switch (choix)
                                {
                                    case "1":
                                        //test function 1
                                        DegDeX deg_x = new DegDeX();
                                        break;
                                    case "2":
                                        //test function 2
                                        OrdreGra Ordre_g = new OrdreGra(int.Parse(N));
                                        Ordre_g.OrdreGraphe();
                                        break;
                                    case "3":
                                        //test function 3
                                        DensiteGra den_g = new DensiteGra();
                                        break;
                                    case "4":
                                        //test function 4
                                        TailleGra t_g = new TailleGra(int.Parse(N), Matrice_de_g);
                                        break;
                                    case "5":
                                        //test function 5
                                        VerifSimple verif_g_simple = new VerifSimple(int.Parse(N), Matrice_de_g);
                                        break;
                                    case "6":
                                        //test function 6
                                        VerifComplet verif_complet = new VerifComplet(int.Parse(N),Matrice_de_g);
                                        break;
                                    case "7":
                                        //test function 7
                                        VerifXisoler verif_x_isoler = new VerifXisoler(int.Parse(N), Matrice_de_g);
                                        break;
                                    case "8":
                                        //test function 8
                                        OrdonancerGra Ordonancer_g = new OrdonancerGra(int.Parse(N), Matrice_de_g);
                                        break;
                                    case "9":
                                        //test function 9
                                        DonnerNombreDeCheminEntreXetY nbr_ch_de_x_a_g = new DonnerNombreDeCheminEntreXetY();
                                        break;
                                    case "10":
                                        //test function 10
                                        DonnerPlusCourtChemin Plus_Cour_Chemin = new DonnerPlusCourtChemin();
                                        break;
                                    case "11":
                                        //test function 11
                                        VerifFortementConnexe verif_g_for_conexe = new VerifFortementConnexe();
                                        break;
                                    case "12":
                                        //test function 12
                                        VerifArbre verif_arbre = new VerifArbre();
                                        break;
                                    default:
                                        Console.WriteLine("Choix incorrecte");
                                        break;
                                }
                                Console.WriteLine("saisir la lettre q si vous vouler quitter le menux des fonction SVP ! ");
                                quitter = Console.ReadLine();
                                Console.Clear();

                            }
                        }
                        break;
                    default:
                        Console.WriteLine("Choix incorrecte");
                        break;
                }
                Console.Clear();
                Console.WriteLine("voulez vous continuer à tester les autre Fonction ?");
                fermer = Console.ReadLine();
                Console.Clear();
            }
        }
    }
}
