using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP2
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = new Random().Next(0, 50); // nombre aléatoire
            int tentative = 0; // nombre de tentatives
            bool trouve = false; // variable booléenne
            Console.WriteLine("Veuillez deviner un nombre compris entre 0 et 50");
            while (!trouve) // Démarrage de la boucle while avec négation de la valeur booléenne
            {
                string rep = Console.ReadLine();
                int saisie;
                if (int.TryParse(rep, out saisie)) // conversion string en int et démarrage de la 1ière boucle if
                {
                    if (saisie == n)
                        trouve = true; // permet de continuer la boucle while tant que trouve est false
                    else
                    {
                        if (saisie < n)
                            Console.WriteLine("Le chiffre est trop petit ..."); // nombre trop petit
                        else
                            Console.WriteLine("Le chiffre est trop grand ..."); // nombre trop grand
                    }
                    tentative++; // incrémentation du nombre de tentatives
                }
                else
                    Console.WriteLine("La valeur saisie est incorrecte, veuillez recommencer ...");
            }
            Console.WriteLine("Vous avez trouvé le chiffre en " + tentative + " foi(s)");
            Console.ReadKey();
            }

        }
    
}
