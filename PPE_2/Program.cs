using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;
using System.Data.Sql;
using System;
using System.Timers;

namespace PPE_2
{ class Program
    {
        private static System.Timers.Timer aTimer;
        static void Main(string[] args)
        {

            SetTimer();
            Console.ReadLine();
            aTimer.Stop();
            aTimer.Dispose();

        }

        private static void SetTimer()
        {

            // Création d'un timer à 2 secondes d'intervalle
            aTimer = new System.Timers.Timer();
            aTimer.Interval = 2000;

            aTimer.Elapsed += OnTimedEvent;
            aTimer.AutoReset = true;
            aTimer.Enabled = true;
        }

        private static void OnTimedEvent(Object source, ElapsedEventArgs e)
        {

            //Connexion à la bdd et création du curseur:

            
             connexionbdd crs = new connexionbdd("SERVER=127.0.0.1; DATABASE=frais; UID=root; PASSWORD=");

             

            //On vérifie qu'on est bien entre le 1 et le 10 du mois:
            if (Gestion_Date.Entre(1, 10) == true)
            {
                //Récupération des fiches du mois précédent et maj de celles-ci:
                
                 String moisPrecedent = Gestion_Date.GetMoisPrecedent();
       
                 String annee = Gestion_Date.getAnnee(DateTime.Today);

                 string mois = annee + moisPrecedent;
                 crs.reqUpdate("update fichefrais set idetat='CL' where mois =" + mois + " and idetat='CR'");

            }

            //Si on est après le 20 du mois:
            if (Gestion_Date.Entre(20, 31) == true)
            {
                
                //Récupération des fiches du mois précédent et maj de celles-ci:

                String moisPrecedent = Gestion_Date.GetMoisPrecedent();
                String annee = Gestion_Date.getAnnee(DateTime.Today);

                string mois = annee + moisPrecedent;

                crs.reqUpdate("update fichefrais set idetat='RB' where mois = " + mois + " and idetat='VA'");
     
            }
        }

       
    }
}
