using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gestion_conservatoire_musique.Modele
{

    /*ATTENTION : ici une inscription, même si elle peut avoir plusieurs adhérents qui y participe, est liée à UN SEUL ADH*/
    public class Inscription
    {

        private int num_adh;
        private int num_cours;
        private int inscription_validee; /*Validation de l'inscription SI tout a été payé*/
        private int inscription_montantPaye;

        private string cours_horaire;
        private int cours_nbPlace;
        private int cours_prix;

        private string instrument_nom;

        private string prof_nom;
        private string prof_prenom;

        private Adherent adherent_inscription_selectionne;


/*CONSTRUCTOR*/

        public Inscription() { }

        public Inscription(
            int num_adh, int num_cours,
            string cours_horaire, int cours_nbPlace, 
            string instrument_nom, 
            string prof_nom, string prof_prenom, 
            Adherent adherent_inscription_selectionne,
            int inscription_validee, int inscription_montantPaye,
            int cours_prix
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
            this.inscription_validee = inscription_validee;
            this.inscription_montantPaye = inscription_montantPaye;
            this.cours_prix = cours_prix;
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
        public int Inscription_validee { get => inscription_validee; set => inscription_validee = value; }
        public int Inscription_montantPaye { get => inscription_montantPaye; set => inscription_montantPaye = value; }
        public int Cours_prix { get => cours_prix; }



        /*METHODES*/

        public override string ToString()
        {
            string texte = "N°Cours :" + this.Num_cours
                            + " | " + this.Cours_horaire
                            + " | " + this.Cours_nbPlace + " places"
                            + " | " + this.Instrument_nom
                            + " | " + "Prof : " + this.Prof_nom + " " + this.Prof_prenom
                            /*+ " | " + "PAYE : " + this.inscription_validee*/
                            + " | " + "Prix cours : " + this.Cours_prix;

            if (this.Inscription_validee == 0)
            {

                texte = texte + " | " + "PAYE : " + this.Inscription_montantPaye
                                    + " | " + "RESTE A PAYER : ";

                if (this.cours_prix != this.Inscription_montantPaye)
                {
                    texte = texte + "" + (this.Cours_prix - this.Inscription_montantPaye);
                }
                else
                {
                    texte = texte + "rien"
                                    + " | " + "INVALIDEE";
                }

            } else if(this.inscription_validee == 1)
            {
                if (this.cours_prix != this.Inscription_montantPaye)
                {
                    texte = texte + " | " + "PAYE : " + this.Inscription_montantPaye
                                    + " | " + "RESTE A PAYER : " + (this.Cours_prix - this.Inscription_montantPaye)
                                    + " | " + "mais VALIDEE";
                }
                else
                {
                    texte += " | VALIDEE";
                }

            }

            return texte;    
        }

        public void modifier_inscription_credit(Inscription inscription_a_crediter, int credit_valeur)
        {

            int inscription_validee_bool = inscription_a_crediter.Inscription_validee;

            int montant_aCrediter = credit_valeur;

            int montant_paye = inscription_a_crediter.Inscription_montantPaye;
            int prix_cours = inscription_a_crediter.Cours_prix;
            int montant_restantApayer = prix_cours - montant_paye;

            /*
             * DETAIL des IFs successifs : 
             * SI l'inscription n'est pas encore validée
             * SI la valeur du CREDIT entrée par l'utilisateur est bien positive (CHANGER PLACE)
             * SI il reste bien quelque chose à payer (prix cours > somme déjà payée) (CHANGER PLACE ?)
             * SI le crédit n'est pas trop grand (crédit < somme restante à payer)
             * ALORS je fais le crédit
             * APRES SI on a bien tout payé, inscription VALIDEE.
             */

            if (inscription_validee_bool == 0) /*Cas où l'inscription n'est pas validée, càd pas encore payée entièrement*/
            {

                if (montant_aCrediter >= 0) /*Cas où le crédit est bien positif*/
                {

                    if (montant_restantApayer > 0) /*Cas où il reste quelque chose à payer*/
                    {

                        if(montant_restantApayer >= montant_aCrediter) /*MOYEN : si crédit > montant restant à payer, refus*/
                        {

                            /*ESSENTIEL MAIS... variable pas en trop ? Test apres avec montant_paye et prix_cours ?*/
                            montant_restantApayer -= montant_aCrediter;
                            montant_paye += montant_aCrediter; 
                            inscription_a_crediter.Inscription_montantPaye = montant_paye;

                            if (montant_restantApayer == 0) /*Si montant totalement payé avec crédit, VALIDATION*/
                            {
                                inscription_a_crediter.Inscription_validee = 1;
                                MessageBox.Show("INSCRIPTION VALIDEE", "Crédit inscription");
                            }
                            else
                            {
                                MessageBox.Show("Il reste à payer " + montant_restantApayer + " euros", "Crédit inscription");
                            }

                        }
                        else
                        {
                            MessageBox.Show("Crédit invalidé car trop grand - Réessayez", "Crédit inscription");
                        }

                    }
                    else
                    {
                        MessageBox.Show("Refus crédit - inscription déjà validée", "Crédit inscription");
                    }
                }
                else
                {
                    MessageBox.Show("Montant crédit INVALIDE - valeur positive attendue", "Crédit inscription");
                }
            }
            else
            {
                MessageBox.Show("Crédit refusé - inscription déjà validée ", "Crédit inscription");
            }

        }



    }
}
