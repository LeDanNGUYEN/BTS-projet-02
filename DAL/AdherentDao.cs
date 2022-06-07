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
    class AdherentDao
    {

        private ConnexionSql maConnexionSql;

        private MySqlCommand commandeSql;

        public List<Adherent> getAdherentsAll()
        {

            List<Adherent> list_adherents = new List<Adherent>();
            List<int> list_idAdherents = new List<int>();

            try
            {

                maConnexionSql = ConnexionSql.getInstance(Fabrique.ProviderMysql, Fabrique.DataBaseMysql, Fabrique.UidMysql, Fabrique.MdpMysql);

                maConnexionSql.openConnection();

                commandeSql = maConnexionSql.reqExec("SELECT * FROM adherent");

                MySqlDataReader reader = commandeSql.ExecuteReader();

                while (reader.Read())
                {
                    int idAdherent = (int)reader.GetValue(0);
                    list_idAdherents.Add(idAdherent);
                }

                reader.Close();

                foreach(int i in list_idAdherents)
                {

                    commandeSql = maConnexionSql.reqExec("SELECT * FROM person WHERE person_id = " + i);

                    MySqlDataReader reader2 = commandeSql.ExecuteReader();

                    Adherent adherent_seul;

                    while (reader2.Read())
                    {

                        int id = (int)reader2.GetValue(0);
                        string nom = (string)reader2.GetValue(1);
                        string prenom = (string)reader2.GetValue(2);
                        string tel = (string)reader2.GetValue(3);
                        string adresse = (string)reader2.GetValue(4);
                        string mail = (string)reader2.GetValue(5);

                        adherent_seul = new Adherent(id, nom, prenom, tel, adresse, mail);

                        list_adherents.Add(adherent_seul);

                    }

                    reader2.Close();
                }

                maConnexionSql.closeConnection();

            }
            catch(Exception emp)
            {
                MessageBox.Show(emp.Message);
            }

            return list_adherents;

        }


        public void updateAdhBdd(Adherent adh_selectionne)
        {
            try
            {

                maConnexionSql = ConnexionSql.getInstance(Fabrique.ProviderMysql, Fabrique.DataBaseMysql, Fabrique.UidMysql, Fabrique.MdpMysql);

                maConnexionSql.openConnection();

                commandeSql = maConnexionSql.reqExec("UPDATE person p " +
                    "SET p.person_adresse = '" + adh_selectionne.Adresse + "', " +
                    "p.person_tel = '" + adh_selectionne.Tel + "', " +
                    "p.person_mail = '" + adh_selectionne.Mail + "' " +
                    "WHERE p.person_id = " + adh_selectionne.Id);

                commandeSql.ExecuteNonQuery();

                maConnexionSql.closeConnection();
            }
            catch (Exception emp)
            {
                throw (emp);
            }
        }


        public void deleteAdhBdd(Adherent adh_selectionne)
        {
            try
            {

                maConnexionSql = ConnexionSql.getInstance(Fabrique.ProviderMysql, Fabrique.DataBaseMysql, Fabrique.UidMysql, Fabrique.MdpMysql);

                maConnexionSql.openConnection();

                commandeSql = maConnexionSql.reqExec("DELETE FROM adherent WHERE adherent_id = " + adh_selectionne.Id);
                commandeSql.ExecuteNonQuery();

                maConnexionSql.closeConnection();
            }
            catch
            {
                MessageBox.Show("Suppression impossible - inscrit(e) à des cours","Suppression adhérent");
            }
        }


    }
}
