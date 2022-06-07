using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gestion_conservatoire_musique.Modele
{
    public class Adherent : Person
    {

/*ATTRIBUTS*/ /*En plus*/
        private List<Inscription> inscriptions_liste = new List<Inscription>();


/*CONSTRUCTOR*/
        public Adherent(){   }

        public Adherent(int id, string nom, string prenom, string tel, string adresse, string mail) : base(id, nom, prenom, tel, adresse, mail)
        {

        }


/*GETTER - SETTER*/
        /*Rien de plus*/


/*METHODES*/
        public override string ToString() /*N'affiche pas tout*/
        {

            return ("N°Client : " + this.Id 
                + " || " + base.ToString() /*Affichage Nom et Prenom*/
                + " | " + "Adresse : " + this.Adresse);
        }


        public override void crediter(int sommeCredit) /*Non fonctionnelle*/
        {
            throw new NotImplementedException();
        }



    }
}
