using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using gestion_conservatoire_musique.DAL;
using gestion_conservatoire_musique.Modele;


namespace gestion_conservatoire_musique.Controleur
{
    class Mgr
    {

        AdherentDao adh_liste = new AdherentDao();
        InscriptionDao inscription_liste = new InscriptionDao();

        public List<Adherent> chargement_liste_adh()
        {
            return adh_liste.getAdherentsAll();
        }

        public List<Inscription> chargement_liste_inscription(Adherent adh_selectionne)
        {
            return inscription_liste.getInscription_adh(adh_selectionne);
        }

        public void update_adh_info(Adherent adh_selectionne)
        {
            adh_liste.updateAdhBdd(adh_selectionne);
        }

        public void delete_adh(Adherent adh_selectionne)
        {
            adh_liste.deleteAdhBdd(adh_selectionne);
        }

        public void update_inscription_credit(Inscription inscription_a_changer)
        {
            inscription_liste.updateInscriptionCreditBdd(inscription_a_changer);
        }

        public void delete_inscription(Inscription inscription_adh_choisie)
        {
            inscription_liste.deleteInscriptionBdd(inscription_adh_choisie);
        }
    }
}


