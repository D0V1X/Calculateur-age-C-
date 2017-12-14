using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculateur_age
{
    class Program
    {
        static void Main(string[] args)
        {
            int iNb = 0;
            int iyear;
            int imonth;
            int iday;
            string strNom;
            char cSaisie;

            Console.WriteLine("************************************************************");
            Console.WriteLine("Bienvenue sur le calculateur d'âge. Quel est votre prénom ? ");
            strNom = Console.ReadLine();
            Console.WriteLine("************************************************************");
            do
            {
                Console.Clear();
                Console.WriteLine("Bonjour, ravis de vous voir {0} !", strNom);
                Console.WriteLine("************************************************************");
                Console.WriteLine("Pour calculer votre âge en jours, tapez [1] !");
                Console.WriteLine("Pour savoir l'heure, tapez [2] !");
                Console.WriteLine("Pour quitter le programme, tapez [3] !");
                Console.WriteLine("************************************************************");
                cSaisie = Console.ReadKey().KeyChar;

                switch (cSaisie)
                {
                    case '1':
                        break;

                    case '2':
                        break;

                    case '3':
                        break;

                    case '4':
                        break;
                }
            }
            while (iNb == 0);
        }
    }
}
