using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using gestion_conservatoire_musique.Controleur;
using gestion_conservatoire_musique.Modele;
using gestion_conservatoire_musique.Vue;

namespace gestion_conservatoire_musique
{
    public partial class Form_adh_principal : Form
    {

/*INITIALISATION & VARIABLE */

        Mgr monManager;
        public List<Adherent> liste_adh_form = new List<Adherent>();
        public List<Inscription> liste_inscription_form = new List<Inscription>();

        public Form_adh_principal()
        {
            InitializeComponent();
            monManager = new Mgr();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            liste_adh_form = monManager.chargement_liste_adh();
            if(liste_adh_form.Count != 0) 
            { 
                update_listbox_adh(0); 
            }
        }


/*UPDATE ON CLICK*/

        /*METHODE : click (ou pas) listbox des inscriptions, pour 1 adherent selectionne*/
        private void listBox_adherent_SelectedIndexChanged(object sender, EventArgs e)
        {

            int i = listBox_adherent.SelectedIndex;

            if (i != -1)
            {

                /*Adherent adh_selectionne = (Adherent)liste_adh_form[i];*/
                Adherent adh_selectionne = liste_adh_form[i];

                liste_inscription_form = monManager.chargement_liste_inscription(adh_selectionne);

                if (liste_inscription_form.Count != 0)
                {
                    update_listbox_inscription(0);
                }
                else
                {
                    update_listbox_inscription_rien();
                }

            }

        }

        /*METHODE : click*/
        private void listBox_adherent_inscription_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btn_adherent_modify_Click(object sender, EventArgs e)
        {

            int i;
            i = listBox_adherent.SelectedIndex;

            Adherent adh_selectionne_modif = liste_adh_form[i];

            Form_adh_detail form_adh_detail_vue = new Form_adh_detail(adh_selectionne_modif);
            form_adh_detail_vue.ShowDialog();

            monManager.update_adh_info(adh_selectionne_modif);

            liste_adh_form = monManager.chargement_liste_adh();

            update_listbox_adh(i);
            MessageBox.Show("Modification effectuee");

        }

        private void btn_adherent_delete_Click(object sender, EventArgs e)
        {

            int i;
            i = listBox_adherent.SelectedIndex;

            Adherent adh_selectionne_suppr = liste_adh_form[i];

            DialogResult user_choix;

            user_choix = MessageBox.Show("Voulez-vous vraiment le supprimer ?", "Suppression adherent", 
                MessageBoxButtons.YesNo, MessageBoxIcon.Information);

            if(user_choix == DialogResult.Yes)
            {

                monManager.delete_adh(adh_selectionne_suppr);

                liste_adh_form = monManager.chargement_liste_adh();

                liste_adh_form.Count();
                update_listbox_adh(i);
                MessageBox.Show("Suppression effectuee");
            }



        }


/* FONCTIONS POUR CHARGER/UPDATE LES LISTBOX */

        /*METHODE : charger-update listbox des adherents*/
        private void update_listbox_adh(int index)
        {
            listBox_adherent.DataSource = null;
            listBox_adherent.DataSource = liste_adh_form;
            /*listBox_adherent.DisplayMember = Description;*/ /* PAS BESOIN, cela fait appel au toString */
            listBox_adherent.SetSelected(index, true);
        }

        /*METHODE : update listbox des inscriptions, pour AUCUN adherent selectionne*/
        private void update_listbox_inscription_rien()
        {
            listBox_adherent_inscription.DataSource = null;
            /*listBox_adherent_inscription.DisplayMember = "Description";*/
        }

        /*METHODE : update listbox des inscriptions, pour 1 adherent selectionne*/
        private void update_listbox_inscription(int index)
        {
            listBox_adherent_inscription.DataSource = null;
            // lBox.DataSource = lstcpt.Values.ToList();
            listBox_adherent_inscription.DataSource = liste_inscription_form;
            /*listBox_adherent_inscription.DisplayMember = "Description";*/
            listBox_adherent_inscription.SetSelected(index, true);
        }


    }
}
