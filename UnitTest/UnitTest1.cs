using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PPE_2;

namespace UnitTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod()]
        public void GetMoisPrecedentTest()
        {

            String moisPrecedent = Gestion_Date.GetMoisPrecedent();
            // DateTime moisActuel = DateTime.Today ;
            String result = DateTime.Today.AddMonths(-1).ToString("MM");
            Assert.AreEqual(moisPrecedent, result);

        }

        [TestMethod()]
        public void GetMoisPrecedentDecembreTest()
        {
            // Créez un objet DateTime (année, mois, jour, heure, minutes, secondes)
            DateTime aDateTime = new DateTime(2005, 01, 23);

            String decembre = Gestion_Date.GetMoisPrecedent(aDateTime);
            Assert.AreEqual(decembre, "12");


        }

        [TestMethod()]
        public void GetMoisSuivantTest()
        {
            String moisSuivant = Gestion_Date.GetMoisSuivant();
            // DateTime moisActuel = DateTime.Today ;
            String result = DateTime.Today.AddMonths(+1).ToString("MM");
            Assert.AreEqual(moisSuivant, result);
        }

        [TestMethod()]
        public void GetMoisSuivantTestDecembre()
        {
            // Créez un objet DateTime (année, mois, jour)
            DateTime aDateTime = new DateTime(2005, 12, 23);

            String decembre = Gestion_Date.GetMoisSuivant(aDateTime);
            Assert.AreEqual(decembre, "01");

        }

        [TestMethod()]
        public void EntreTestJourEgal()
        {

            // Créez un objet DateTime (année, mois, jour)
            DateTime Date = new DateTime(2019, 12, 04);
            bool faux = Gestion_Date.Entre(01, 04, Date);
            Assert.AreEqual(faux, true);
        }


    }
}
