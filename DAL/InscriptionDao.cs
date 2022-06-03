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
        private AdherentDao adh_bdd;

        public List<Inscription> getInscription_adh(Adherent adh_selectionne)
        {

            List<Inscription> liste_inscription = new List<Inscription>();

            try
            {

                maConnexionSql = ConnexionSql.getInstance(Fabrique.ProviderMysql, Fabrique.DataBaseMysql, Fabrique.UidMysql, Fabrique.MdpMysql);

                maConnexionSql.openConnection();

                maCommandeSql = maConnexionSql.reqExec(
                    "SELECT " +
                    "insc.idAdherent, insc.idCours, " +
                    "c.horaire, c.nbPlace, " +
                    "inst.instrument_nom, " +
                    "p.prof_nom, p.prof_prenom, " +
                    "a.nom, a.prenom, a.tel, a.adresse, a.mail, " +
                    "insc.paye " +
                    "FROM inscription AS insc " +
                    "INNER JOIN adherent AS a ON insc.idAdherent = a.adherent_id " +
                    "INNER JOIN cours AS c ON insc.idCours = c.cours_id " +
                    "INNER JOIN instrument AS inst ON c.idInstrument = inst.instrument_id " +
                    "INNER JOIN professeur AS p ON c.idProfesseur = p.professeur_id "+
                    "WHERE insc.idAdherent = " + adh_selectionne.Num
                    );

                MySqlDataReader reader = maCommandeSql.ExecuteReader();


               

                while (reader.Read())
                {

                    int num_adh = (int)reader.GetValue(0);
                    int num_cours = (int)reader.GetValue(1);

                    string cours_horaire = reader.GetString(2);
                    int cours_nbPlace = (int)reader.GetValue(3);

                    string instrument_nom = reader.GetString(4);

                    string prof_nom = reader.GetString(5);
                    string prof_prenom = reader.GetString(6);

                    string adh_nom = reader.GetString(7);
                    string adh_prenom = reader.GetString(8);
                    string adh_tel = reader.GetString(9);
                    string adh_adresse = reader.GetString(10);
                    string adh_mail = reader.GetString(11);

                    int payee = (int)reader.GetValue(12);

                    Inscription inscription_adherent_seule = new Inscription(
                        num_adh, num_cours,
                        cours_horaire,cours_nbPlace,
                        instrument_nom,
                        prof_nom,prof_prenom,
                        adh_selectionne,
                        payee
                    );

                    liste_inscription.Add(inscription_adherent_seule);

                }

                reader.Close();

                /*maConnexionSql.closeConnection();*/

            }
            catch(Exception emp)
            {
                MessageBox.Show(emp.Message);
            }

            return liste_inscription;

        }
    }
}
