using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gestion_conservatoire_musique.Modele
{

    /*ATTENTION : ici une inscription, même si elle peut avoir plusieurs adhérents qui y participe, est liée à UN SEUL ADH*/
    public class Inscription
    {

        private int num_adh;
        private int num_cours;
        private int inscription_payee;

        private string cours_horaire;
        private int cours_nbPlace;

        private string instrument_nom;

        private string prof_nom;
        private string prof_prenom;

        private Adherent adherent_inscription_selectionne;
/*        
private string adh_nom;
private string adh_prenom;
private string adh_tel;
private string adh_adresse;
private string adh_mail;
*/


/*CONSTRUCTOR*/

        public Inscription() { }

        public Inscription(
            int num_adh, int num_cours,
            string cours_horaire, int cours_nbPlace, 
            string instrument_nom, 
            string prof_nom, string prof_prenom, 
            Adherent adherent_inscription_selectionne,
             int inscription_payee
            )
        {
            this.num_adh = num_adh;
            this.num_cours = num_cours;
            this.cours_horaire = cours_horaire;
            this.cours_nbPlace = cours_nbPlace;
            this.instrument_nom = instrument_nom;
            this.prof_nom = prof_nom;
            this.prof_prenom = prof_prenom;
            this.adherent_inscription_selectionne = adherent_inscription_selectionne;
            this.inscription_payee = inscription_payee;
        }


/*GETTER - SETTER*/

        public int Num_adh { get => num_adh; }
        public int Num_cours { get => num_cours; }
        public string Cours_horaire { get => cours_horaire; }
        public int Cours_nbPlace { get => cours_nbPlace; }
        public string Instrument_nom { get => instrument_nom; }
        public string Prof_nom { get => prof_nom; }
        public string Prof_prenom { get => prof_prenom; }
        public Adherent Adherent_inscription_selectionne { get => adherent_inscription_selectionne; }
        public int Inscription_payee { get => inscription_payee; }


        /*METHODES*/

        public override string ToString()
        {
            return ("N°Cours :" + this.Num_cours
                + " | " + "Horaire : " + this.Cours_horaire
                + " | " + "Places disponibles : " + this.Cours_nbPlace
                + " | " + "Instrument : " + this.Instrument_nom
                + " | " + "Professeur : " + this.Prof_nom + " " + this.Prof_prenom)
                + " | " + "PAYE : " + this.Inscription_payee;
        }





    }
}
