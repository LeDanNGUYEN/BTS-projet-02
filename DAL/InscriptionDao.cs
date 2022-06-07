using gestion_conservatoire_musique.Modele;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms; /* Pour pouvoir utilise MessageBox par exemple */
using MySql.Data.MySqlClient; /* Connexion à MySql */
using System.Threading.Tasks;
using gestion_conservatoire_musique.Modele;

namespace gestion_conservatoire_musique.DAL
{
    class InscriptionDao
    {

        private ConnexionSql maConnexionSql;
        private MySqlCommand maCommandeSql;

        public List<Inscription> getInscription_adh(Adherent adh_selectionne)
        {

            List<Inscription> liste_inscription = new List<Inscription>();

            try
            {

                maConnexionSql = ConnexionSql.getInstance(Fabrique.ProviderMysql, Fabrique.DataBaseMysql, Fabrique.UidMysql, Fabrique.MdpMysql);

                maConnexionSql.openConnection();

                maCommandeSql = maConnexionSql.reqExec(
                    "SELECT " +
                    "insc.inscription_adherentId, insc.inscription_coursId, " +
                    "c.cours_horaire, c.cours_nbPlaces, " +
                    "inst.instrument_nom, " +
                    "personProf.person_nom, personProf.person_prenom, " +
                    "insc.inscription_validee, insc.inscription_montantPaye, " +
                    "c.cours_prix " +
                    "FROM inscription AS insc " +
                    "INNER JOIN cours AS c ON insc.inscription_coursId = c.cours_id " +
                    "INNER JOIN instrument AS inst ON c.cours_instrumentId = inst.instrument_id " +
                    "INNER JOIN person AS personProf ON c.cours_professeurId = personProf.person_id " +
                    "WHERE insc.inscription_adherentId = " + adh_selectionne.Id
                    ); 

                MySqlDataReader reader = maCommandeSql.ExecuteReader();


                while (reader.Read())
                {

                    int num_adh = (int)reader.GetValue(0);
                    int num_cours = (int)reader.GetValue(1);

                    DateTime cours_horaire_0 = reader.GetDateTime(2);
                    string cours_horaire = cours_horaire_0.ToString();
                    /*string cours_horaire = reader.GetString(2);*/

                    int cours_nbPlace = (int)reader.GetValue(3);

                    string instrument_nom = reader.GetString(4);

                    string prof_nom = reader.GetString(5);
                    string prof_prenom = reader.GetString(6);

                    int payee = (int)reader.GetValue(7);
                    int montant_paye = (int)reader.GetValue(8);
                    int cours_prix = (int)reader.GetValue(9);


                    Inscription inscription_adherent_seule = new Inscription(
                        num_adh, num_cours,
                        cours_horaire,cours_nbPlace,
                        instrument_nom,
                        prof_nom,prof_prenom,
                        adh_selectionne,
                        payee, montant_paye,
                        cours_prix
                    );

                    liste_inscription.Add(inscription_adherent_seule);

                }

                reader.Close();

                maConnexionSql.closeConnection();

            }
            catch(Exception emp)
            {
                MessageBox.Show(emp.Message);
            }

            return liste_inscription;

        }

        public void updateInscriptionCreditBdd(Inscription inscription_a_changer)
        {
            try
            {

                maConnexionSql = ConnexionSql.getInstance(Fabrique.ProviderMysql, Fabrique.DataBaseMysql, Fabrique.UidMysql, Fabrique.MdpMysql);

                maConnexionSql.openConnection();

                maCommandeSql = maConnexionSql.reqExec("UPDATE inscription insc " +
                    "SET insc.inscription_montantPaye = " + inscription_a_changer.Inscription_montantPaye + ", " +
                    "insc.inscription_validee = " + inscription_a_changer.Inscription_validee + " " +
                    "WHERE insc.inscription_adherentId = " + inscription_a_changer.Num_adh + " " +
                    "AND insc.inscription_coursId = " + inscription_a_changer.Num_cours);

                maCommandeSql.ExecuteNonQuery();

                maConnexionSql.closeConnection();
            }
            catch(Exception emp)
            {
                throw (emp);
            }

        }

        public void deleteInscriptionBdd(Inscription inscription_adh_choisie)
        {
            try
            {

                if(inscription_adh_choisie.Inscription_montantPaye == 0)
                {
                    maConnexionSql = ConnexionSql.getInstance(Fabrique.ProviderMysql, Fabrique.DataBaseMysql, Fabrique.UidMysql, Fabrique.MdpMysql);

                    maConnexionSql.openConnection();

                    maCommandeSql = maConnexionSql.reqExec("DELETE FROM inscription " +
                        "WHERE inscription_adherentId = " + inscription_adh_choisie.Num_adh + " " +
                        "AND inscription_coursId = " + inscription_adh_choisie.Num_cours + " " +
                        "AND inscription_montantPaye = 0"
                        );
                    maCommandeSql.ExecuteNonQuery();

                    maConnexionSql.closeConnection();
                }
                else
                {
                    MessageBox.Show("Suppression impossible - règlement commencé", "Suppression inscription");
                }

            }
            catch
            {
                MessageBox.Show("Suppression impossible - ERREUR", "Suppression inscription");
            }
        }

    }
}
