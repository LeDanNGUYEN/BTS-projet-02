using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gestion_conservatoire_musique.Modele
{
    public class Prof : Person
    {

/*ATTRIBUTS*/ /*en plus de la base*/
        private int salaire = 0;


/*CONSTRUCTOR*/
        public Prof() { }
        public Prof(int id, string nom, string prenom, string tel, string adresse, string mail) : base(id, nom, prenom, tel, adresse, mail)
        {

        }

/*GETTER - SETTER*/ /*En plus de ceux de la classe mère Person*/
        public int Salaire { get => salaire; }


/*METHODES*/
        public override string ToString()
        {
            return ("N°Client : " + this.Id
                + " || " + base.ToString() /*Affichage Nom et Prenom*/
                + " | " + "Adresse : " + this.Adresse);
        }

        public override void crediter(int sommeCredit) /*Pas fonctionnelle pour le moment*/
        {
            throw new NotImplementedException();
        }


    }
}
