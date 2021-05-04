using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data;
using MySql.Data.MySqlClient;
using System.Data.Sql;

namespace PPE_2

{
    public abstract class Gestion_Date
    {

        //Retourne le mois precedent le mois actuel

        static public string GetMoisPrecedent()
        {

            // appelle de la methode GetMoisPrecedent qui prend des parametres
            return GetMoisPrecedent(DateTime.Today); 
           
        }

        //retourne le mois precedent par rapport à la date entrer en paramettre
        static public string GetMoisPrecedent(DateTime date)
        {

            return date.AddMonths(-1).ToString("MM");

        }

        //retourne le mois suivant du mois actuel
        static public string GetMoisSuivant()
        {
            // appelle de la methode GetMoisSuivant qui prend des parametres
            return GetMoisSuivant(DateTime.Today); 

        }

        /// <summary>
        /// retourne le mois suivant la date entré en parametre 
        /// </summary>
        /// <param name="date"></param>
        /// <returns></returns>

        static public string GetMoisSuivant(DateTime date)
        {

            return date.AddMonths(+1).ToString("MM");
         
        }

        /// <summary>
        /// return true si la date du jour se trouve entre les deux jours entrés en paramètre
        /// </summary>
        /// <param name="jour1"></param>
        /// <param name="jour2"></param>
        /// <returns></returns>
        /// 
        static public Boolean Entre(int jour1, int jour2)
        {

            return Entre(jour1, jour2, DateTime.Today);

        }

    
        /// <summary>
        /// Return true si la date entrer en parametre se trouve entre les deux jours 
        /// </summary>
        /// <param name="jour1"></param>
        /// <param name="jour2"></param>
        /// <param name="date"></param>
        /// <returns></returns>
        /// 
        static public Boolean Entre(int jour1, int jour2, DateTime date)
        {
;
            int jour = date.Day;
       
            if (jour1 <= jour & jour <= jour2)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// Permet de n'avoir que l'annee de la date entrer en paramètre
        /// </summary>
        /// <param name="date"></param>
        /// <returns></returns>
        /// 
        public static String getAnnee(DateTime date)
        {
            date = date.AddMonths(-1);
            String annee = date.ToString("yyyy");
            return annee;
        }

    }
}
