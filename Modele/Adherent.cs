using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gestion_conservatoire_musique.Modele
{
    public class Adherent
    {


/*VARIABLES*/

        private int num;
        private string nom;
        private string prenom;
        private string telephone;
        private string adresse;
        private string mail;
        private List<Inscription> inscriptions_liste = new List<Inscription>();


/*CONSTRUCTOR*/

        public Adherent(){   }

        public Adherent(int num, string nom, string prenom, string telephone, string adresse, string mail)
        {
            this.num = num;
            this.nom = nom;
            this.prenom = prenom;
            this.telephone = telephone;
            this.adresse = adresse;
            this.mail = mail;
        }


/*GETTER - SETTER*/

        public int Num { get => num; }
        public string Nom { get => nom; }
        public string Prenom { get => prenom; }
        public string Tel { get => telephone; set => telephone = value; }
        public string Adresse { get => adresse; set => adresse = value; }
        public string Mail { get => mail; set => mail = value; }


/*METHODES*/

        public override string ToString() /*N'affiche pas tout*/
        {
            return ("N°Client : " + this.Num 
                + " || " + this.Nom + " " + this.Prenom 
                + " | " + "Adresse : " + this.Adresse);
        }



    }
}
