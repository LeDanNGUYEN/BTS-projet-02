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

            try
            {

                maConnexionSql = ConnexionSql.getInstance(Fabrique.ProviderMysql, Fabrique.DataBaseMysql, Fabrique.UidMysql, Fabrique.MdpMysql);

                maConnexionSql.openConnection();

                commandeSql = maConnexionSql.reqExec("SELECT * FROM adherent");

                MySqlDataReader reader = commandeSql.ExecuteReader();

                Adherent adherent_seul;

                while (reader.Read())
                {

                    int numero = (int)reader.GetValue(0);
                    string nom = (string)reader.GetValue(1);
                    string prenom = (string)reader.GetValue(2);
                    string telephone = (string)reader.GetValue(3);
                    string adresse = (string)reader.GetValue(4);
                    string mail = (string)reader.GetValue(5);

                    adherent_seul = new Adherent(numero, nom, prenom, telephone, adresse, mail);

                    list_adherents.Add(adherent_seul);

                }

                reader.Close();

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
                commandeSql = maConnexionSql.reqExec("UPDATE adherent adh " +
                    "SET adh.adresse = '" + adh_selectionne.Adresse + "', " +
                    "adh.tel = '" + adh_selectionne.Tel + "', " +
                    "adh.mail = '" + adh_selectionne.Mail + "' " +
                    "WHERE adh.adherent_id = " + adh_selectionne.Num );

                commandeSql.ExecuteNonQuery();
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
                commandeSql = maConnexionSql.reqExec("DELETE FROM adherent WHERE adherent.adherent_id = " + adh_selectionne.Num);

                commandeSql.ExecuteNonQuery();
            }
            catch (Exception emp)
            {
                throw (emp);
            }
        }



    }
}
