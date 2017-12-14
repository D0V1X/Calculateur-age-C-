using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace TestDateTime
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
                try
                {
                    Console.Clear();
                    Console.WriteLine("Bonjour, ravis de vous voir {0} !", strNom);
                    Console.WriteLine("************************************************************");
                    Console.WriteLine("Pour calculer votre âge en jours, tapez [1] !");
                    Console.WriteLine("Pour savoir l'heure, tapez [2] !");
                    Console.WriteLine("Pour savoir la date actuelle, tapez [3] !");
                    Console.WriteLine("Pour quitter le programme, tapez [4] !");
                    Console.WriteLine("************************************************************");
                    cSaisie = Console.ReadKey().KeyChar;

                    switch (cSaisie)
                    {
                        case '1':
                            Console.Clear();
                            do
                            {
                                Console.WriteLine("*********************************************************************");
                                Console.WriteLine("Quel est votre jour de naissance ? ");
                                string strJour = Console.ReadLine();
                                Console.WriteLine("*********************************************************************");
                                iday = Convert.ToInt32(strJour);
                            }
                            while (iday < 1 || iday > 31);

                            do
                            {
                                Console.WriteLine("***********************************");
                                Console.WriteLine("Quel est votre mois de naissance ? ", strNom);
                                string strMois = Console.ReadLine();
                                Console.WriteLine("***********************************");
                                imonth = Convert.ToInt32(strMois);
                            }
                            while (imonth < 1 || imonth > 12);

                            do
                            {
                                Console.WriteLine("************************************");
                                Console.WriteLine("Quel est votre année de naissance ? ", strNom);
                                string strAnnee = Console.ReadLine();
                                Console.WriteLine("************************************");
                                iyear = Convert.ToInt32(strAnnee);
                            }
                            while (imonth < 1);

                            DateTime myBirthday = new DateTime(iyear, imonth, iday);
                            TimeSpan myAge = DateTime.Now.Subtract(myBirthday);

                            Console.Clear();
                            Console.WriteLine("**************************************************************************************************************");
                            Console.WriteLine("Vous êtes âgé de {0} jours ! Vous pouvez désormais fêter votre journiversaire avec vos amis et votre famille !", Math.Floor(myAge.TotalDays));
                            Console.WriteLine("**************************************************************************************************************");
                            Console.WriteLine("Pressez une touche pour continuer ...");
                            Console.ReadKey();
                            break;

                        case '2':
                            Console.Clear();
                            DateTime TimeSet = new DateTime();
                            TimeSpan Time = DateTime.Now.Subtract(TimeSet);

                            Console.WriteLine("**************************************************************************************************************");
                            Console.WriteLine("Il est {0}:{1}:{2}", (Time.Hours), (Time.Minutes), (Time.Seconds));
                            Console.WriteLine("**************************************************************************************************************");
                            Console.WriteLine("Pressez une touche pour continuer ...");
                            Console.ReadKey();
                            break;

                        case '3':
                            Console.Clear();
                            Console.WriteLine("**************************************************************************************************************");
                            Console.WriteLine("Nous sommes le {0}.{1}.{2}", DateTime.Now.Day, DateTime.Now.Month, DateTime.Now.Year);
                            Console.WriteLine("**************************************************************************************************************");
                            Console.WriteLine("Pressez une touche pour continuer ...");
                            Console.ReadKey();
                            break;

                        case '4':
                            Console.Clear();
                            Console.WriteLine("*****************************************");
                            Console.WriteLine("Voulez-vous vraiment quitter ??? [o/n]");
                            cSaisie = Console.ReadKey().KeyChar;

                            if (cSaisie == 'o')
                            {
                                Console.Clear();
                                Console.WriteLine("*****************************************");
                                Console.WriteLine("***************Aurevoir...***************");
                                Console.WriteLine("*****************************************");
                                System.Threading.Thread.Sleep(1000);
                                Environment.Exit(0);
                            }
                            break;
                    }
                }
                catch
                {
                    Console.WriteLine("Erreur d'entrée, merci de recommencer");
                    Thread.Sleep(2000);
                }
            }
            while (iNb == 0);
        }
    }
}
